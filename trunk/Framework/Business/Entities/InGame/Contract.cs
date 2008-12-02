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
                return new Club(ClubPointer);
            }
            set { ClubPointer = value.MemoryAddress; }
        }

        public DateTime ContractExpiryDate
        {
            get
            {
                return ProcessManager.ReadDateTime(MemoryAddress + ContractOffsets.ContractExpires);
            }
            set
            {
                ProcessManager.WriteDateTime(value, MemoryAddress + ContractOffsets.ContractExpires);
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

        public byte Happiness
        {
            get { return ProcessManager.ReadByte(MemoryAddress + ContractOffsets.Happiness); }
            set { ProcessManager.WriteByte(value, MemoryAddress + ContractOffsets.Happiness); }
        }

        public byte SquadNumber
        {
            get { return ProcessManager.ReadByte(MemoryAddress + ContractOffsets.SquadNumber); }
            set { ProcessManager.WriteByte(value, MemoryAddress + ContractOffsets.SquadNumber); }

        }
    }
}
