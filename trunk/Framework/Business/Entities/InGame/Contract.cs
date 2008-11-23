using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Young3.FMSearch.Business.Managers;
using Young3.FMSearch.Business.Offsets;

namespace Young3.FMSearch.Business.Entities.InGame
{
    public class Contract : BaseObject
    {
        public enum ContractOrigination
        {
            Player,

        }

        public Contract(int memoryAddress) : base(memoryAddress) { }

        public int AppearanceBonus
        {
            get
            {
                return ProcessManager.ReadInt32(MemoryAddress + ContractOffsets.AppearanceBonus);
            }
            set
            {
                ProcessManager.WriteInt32(value, MemoryAddress + ContractOffsets.AppearanceBonus);
            }
        }

        private int ClubPointer
        {
            get
            {
                return ProcessManager.ReadInt32(MemoryAddress + ContractOffsets.ClubPointer);
            }
            set
            {
                ProcessManager.WriteInt32(value, MemoryAddress + ContractOffsets.ClubPointer, false);
            }
        }

        public Club Club
        {
            get
            {
                int clubAddress = ClubPointer;
                clubAddress = ProcessManager.ReadInt32((int)MemoryAddresses.Club + clubAddress);
                //return new Club(clubAddress);
                return new Club(ClubPointer);
            }
            //set { ClubAddress = value.MemoryAddress; }
        }

        public DateTime ContractExpiryDate
        {
            get
            {
                //TODO: Can't get it to work
                try {
                    int year = ProcessManager.ReadInt16(MemoryAddress + ContractOffsets.ContractExpiresYear);
                    int days = ProcessManager.ReadInt16(MemoryAddress + ContractOffsets.ContractExpiresDays);

                    DateTime bla = new DateTime(year, 1, 1);
                    bla.AddDays(days);

                    return bla;
                }
                catch { return new DateTime(1900,1,1); }
                
            }
            set
            {
                TimeSpan t = value - new DateTime(value.Year, 1, 1);
                int days = t.Days;
                int year = value.Year;

                ProcessManager.WriteInt16(days, MemoryAddress + ContractOffsets.ContractExpiresDays);
                ProcessManager.WriteInt16(year, MemoryAddress + ContractOffsets.ContractExpiresYear);
            }
        }

        public DateTime ContractStarted
        {
            get
            {
                return ProcessManager.ReadDateTime(MemoryAddress + ContractOffsets.ContractStarted);
            }
            set
            {
                ProcessManager.WriteDateTime(value, MemoryAddress + ContractOffsets.ContractStarted);
            }
        }

        public int GoalBonus
        {
            get
            {
                return ProcessManager.ReadInt32(MemoryAddress + ContractOffsets.GoalBonus);
            }
            set
            {
                ProcessManager.WriteInt32(value, MemoryAddress + ContractOffsets.GoalBonus);
            }
        }

        public int WagePerWeek
        {
            get
            {
                return ProcessManager.ReadInt32(MemoryAddress + ContractOffsets.Wages);
            }
            set
            {
                ProcessManager.WriteInt32(value, MemoryAddress + ContractOffsets.Wages);
            }
        }
    }
}
