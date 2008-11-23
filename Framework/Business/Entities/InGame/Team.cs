using System;
using System.Collections.Generic;
using System.Text;
using Young3.FMSearch.Business.Managers;
using Young3.FMSearch.Business.Offsets;
using System.Linq;

namespace Young3.FMSearch.Business.Entities.InGame
{
    public class Team : BaseObject
    {
        public Team(int memoryAddress)
            : base(memoryAddress)
        { }

        public int ClubAddress
        {
            get { return ProcessManager.ReadInt32(MemoryAddress + TeamOffsets.ClubAddress); }
            set { ProcessManager.WriteInt32(value, MemoryAddress + TeamOffsets.ClubAddress); }
        }

        public Club Club
        {
            get
            {
                try
                {
                    return new Club(ClubAddress);
                }
                catch { return null; }
            }
            set { ClubAddress = value.MemoryAddress; }
        }

        public int NumberOfPlayers
        {
            get { return ProcessManager.ReadInt32(MemoryAddress + TeamOffsets.NumberOfPlayers); }
            set { ProcessManager.WriteInt32(value, MemoryAddress + TeamOffsets.NumberOfPlayers); }
        }

        private int StadiumAddress
        {
            get { return ProcessManager.ReadInt32(MemoryAddress + TeamOffsets.StadiumAddress); }
            set { ProcessManager.WriteInt32(value, MemoryAddress + TeamOffsets.StadiumAddress); }
        }

        public Stadium Stadium
        {
            get { return ObjectManager.Stadiums.Single(a => a.MemoryAddress == StadiumAddress); }
            set { ProcessManager.WriteInt32(value.MemoryAddress, StadiumAddress); }
        }
    }
}
