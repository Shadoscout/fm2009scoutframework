using System;
using System.Collections.Generic;
using System.Text;
using Young3.FMSearch.Business.Managers;
using Young3.FMSearch.Business.Offsets;

namespace Young3.FMSearch.Business.Entities.InGame
{
    public class Club : BaseObject
    {
        public Club(int memoryAddress)
            : base(memoryAddress)
        { }

        public string Name
        {
            get { return ProcessManager.ReadString(MemoryAddress + ClubOffsets.Name, null); }
        }

        public byte NumberOfAffiliatedClubs
        {
            get
            {
                return ProcessManager.ReadByte(MemoryAddress + ClubOffsets.NumberOfAffiliatedClubs);
            }
            set
            {
                ProcessManager.WriteByte(value, MemoryAddress + ClubOffsets.NumberOfAffiliatedClubs);
            }
        }

        public byte MaxAffiliatedClubNumber
        {
            get
            {
                return ProcessManager.ReadByte(MemoryAddress + ClubOffsets.MaxAffiliatedClubNumber);
            }
        }

        public int ID
        {
            get { return ProcessManager.ReadInt32(MemoryAddress + ClubOffsets.ID); }
        }

        public int AverageAttendance
        {
            get
            {
                return ProcessManager.ReadInt32(MemoryAddress + ClubOffsets.AverageAttendance);
            }
            set
            {
                ProcessManager.WriteInt32(value, MemoryAddress + ClubOffsets.AverageAttendance);
            }
        }

        private int FinanceAddress
        {
            get { return ProcessManager.ReadInt32(MemoryAddress + ClubOffsets.FinanceAddress); }
            set { ProcessManager.WriteInt32(value, MemoryAddress + ClubOffsets.FinanceAddress); }
        }

        //TODO: offset not yet correct
        private int CountryAddress
        {
            get { return ProcessManager.ReadInt32(MemoryAddress + ClubOffsets.Country); }
            set { ProcessManager.WriteInt32(value, MemoryAddress + ClubOffsets.Country); }
        }

        public Country Country
        {
            get { return new Country(CountryAddress); }
            set { CountryAddress = value.MemoryAddress; }
        }
        


        public Finance Finances
        {
            get
            {
                return new Finance(FinanceAddress);
            }
        }

        public int MaximumAttendance
        {
            get
            {
                return ProcessManager.ReadInt32(MemoryAddress + ClubOffsets.MaximumAttendance);
            }
            set
            {
                ProcessManager.WriteInt32(value, MemoryAddress + ClubOffsets.MaximumAttendance);
            }
        }

        public int MinimumAttendance
        {
            get
            {
                return ProcessManager.ReadInt32(MemoryAddress + ClubOffsets.MinimumAttendance);
            }
            set
            {
                ProcessManager.WriteInt32(value, MemoryAddress + ClubOffsets.MinimumAttendance);
            }
        }

        public ClubStatus Status
        {
            get
            {
                return (ClubStatus)ProcessManager.ReadByte(MemoryAddress + ClubOffsets.Status);
            }
            set
            {
                ProcessManager.WriteByte((byte)value, MemoryAddress + ClubOffsets.Status);
            }
        }

        public byte TrainingGround
        {
            get
            {
                return ProcessManager.ReadByte(MemoryAddress + ClubOffsets.TrainingGround);
            }
            set
            {
                ProcessManager.WriteByte(value, MemoryAddress + ClubOffsets.TrainingGround);
            }
        }

        //TODO: Implement Kit

        //TODO: Implement Sponsor
    }

    public enum ClubStatus
    {
        Professional = 1,
        SemiProfessional = 2,
        Amateur = 3
    }


}
