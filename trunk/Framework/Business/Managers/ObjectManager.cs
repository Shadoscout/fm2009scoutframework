using System;
using System.Collections.Generic;
using System.Text;
using Young3.FMSearch.Business.Entities.InGame;
using Young3.FMSearch.Business.Entities;
using Young3.FMSearch.Business.Attributes;
using System.Reflection;
using Young3.FMSearch.Business.Offsets;

namespace Young3.FMSearch.Business.Managers
{
    public static class ObjectManager
    {
        //changes alot
        public static List<Player> Players = RetrieveObjects<Player>(MemoryAddresses.Player);
        public static List<Team> Teams = RetrieveObjects<Team>(MemoryAddresses.Team);
        public static List<Club> Clubs = RetrieveObjects<Club>(MemoryAddresses.Club);
        public static List<Staff> NonPlayingStaff = LoadNonPlayingStaff();
        
        //never changes
        public static List<Country> Countries = RetrieveObjects<Country>(MemoryAddresses.Country);
        public static List<Continent> Continents = RetrieveObjects<Continent>(MemoryAddresses.Continent);
        public static List<City> Cities = RetrieveObjects<City>(MemoryAddresses.City);
        public static List<Stadium> Stadiums = RetrieveObjects<Stadium>(MemoryAddresses.Stadium);

        //generic load function
        private static List<T> RetrieveObjects<T>(MemoryAddresses baseObjectAddress)
        {
            List<T> internalList = (List<T>)typeof(List<T>).GetConstructor(Type.EmptyTypes).Invoke(new Object[0]);

            //detect attribute on memoryAddress object
            MemoryAddressAttribute memoryAttribute = new MemoryAddressAttribute(4,0);
            MemoryAddressAttribute[] attributes = (MemoryAddressAttribute[])baseObjectAddress.GetType().GetField(baseObjectAddress.ToString()).GetCustomAttributes(typeof(MemoryAddressAttribute), false);
            if(attributes != null && attributes.Length > 0)
            {
                memoryAttribute = attributes[0];
            }

            int memoryAddress = ProcessManager.ReadInt32((int)baseObjectAddress);
            if(memoryAttribute.BytesToSkip > 0)
                memoryAddress = ProcessManager.ReadInt32(memoryAddress + memoryAttribute.BytesToSkip);

            int numberOfObjects = 0;

            if (memoryAttribute.CountLength > 4)
            {
                numberOfObjects = ProcessManager.ReadInt32(memoryAddress + memoryAttribute.CountLength);
            }
            else
            {
                numberOfObjects = ProcessManager.ReadInt32((int)baseObjectAddress + memoryAttribute.CountLength);
            }

            if (memoryAttribute.BytesToSkip > 0)
                memoryAddress = ProcessManager.ReadInt32(memoryAddress + memoryAttribute.BytesToSkip);

            for (int i = 0; i < numberOfObjects; i++)
            {
                int objectAddress = ProcessManager.ReadInt32(memoryAddress + (i * 4));

                T newObject = (T)typeof(T).GetConstructor(new System.Type[] { typeof(int) }).Invoke(new object[] { objectAddress });
                internalList.Add(newObject);
            }

            return internalList;
        }

        public static void Reload()
        {
            Players.Clear();
            Teams.Clear();
            Clubs.Clear();

            Players = RetrieveObjects<Player>(MemoryAddresses.Player);
            Teams = RetrieveObjects<Team>(MemoryAddresses.Team);
            Clubs = RetrieveObjects<Club>(MemoryAddresses.Club);
        }


        /// <summary>
        /// Stupid staff
        /// </summary>
        /// <returns></returns>
        private static List<Staff> LoadNonPlayingStaff()
        {
            List<Staff> internalList = new List<Staff>();

                byte[] sb = new byte[] { 
        0x74, 120, 0xa4, 1, 0x60, 120, 0xa4, 1, 0x94, 0x4b, 0xa5, 1, 0xec, 0x4d, 0xa5, 1, 
        0x7c, 0xc6, 0xa4, 1, 0x6c, 0xc6, 0xa4, 1, 0xa4, 0xb8, 0xa8, 1, 0xc0, 0xb9, 0xa8, 1, 
        180, 0x48, 0xa6, 1, 0xa4, 0x48, 0xa6, 1, 140, 0x44, 0xa6, 1, 0x7c, 0x44, 0xa6, 1, 
        4, 0xad, 170, 1, 240, 0xac, 170, 1, 0xfc, 0x90, 0xa8, 1, 0xe8, 0x90, 0xa8, 1, 
        0xbc, 0x8e, 0xa8, 1, 0xa8, 0x8e, 0xa8, 1, 0x60, 0xe2, 170, 1, 0x60, 0xe5, 170, 1
                };

            uint byteBlockLength = 0x10000;
            int currentMemoryBlock = ProcessManager.ReadInt32((int)MemoryAddresses.Coach);
            int bytesRead = 0;

            //loop thru all the blocks in the FM process
            for (int indexIncrementer = 1; currentMemoryBlock < ProcessManager.FMProcess.EndPoint; indexIncrementer = 1)
            {
                byte[] buffer = ProcessManager.ReadProcessMemory(currentMemoryBlock, byteBlockLength, out bytesRead);
                int index = 0;
                while (index < (bytesRead - 0x10))
                {
                    /*if ((buffer[index + 3] != 1) || (buffer[index + 7] != 1))
                    {
                        index += 1;
                    }
                    else*/
                    {
                        indexIncrementer = 1;
                        //next block, is playing, staff or playercoach?
                        if ((((buffer[index] == sb[0x18]) && (buffer[index + 1] == sb[0x19])) && (buffer[index + 4] == sb[0x1c])) && (buffer[index + 5] == sb[0x1d]))
                        {
                            if (bytesRead > (index + StaffOffsets.StaffLength))
                            {
                                internalList.Add(new Staff(currentMemoryBlock + index));
                                indexIncrementer = StaffOffsets.StaffLength;
                            }
                        }
                    }
                    index += indexIncrementer;
                }
                currentMemoryBlock += ((int)byteBlockLength) - indexIncrementer;
            }
            return internalList;
        }
    }
}
