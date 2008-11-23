using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Young3.FMSearch.Business.Managers;
using Young3.FMSearch.Business.Offsets;

namespace Young3.FMSearch.Business.Entities.InGame
{
    public class Finance : BaseObject
    {

        public Finance(int memoryAddress)
            : base(memoryAddress)
        { }

        public int Balance
        {
            get
            {
                return ProcessManager.ReadInt32(MemoryAddress + FinancialOffsets.Balance);
            }
            set
            {
                ProcessManager.WriteInt32(value, MemoryAddress + FinancialOffsets.Balance);
            }
        }

        public int RemainingTransferBudget
        {
            get
            {
                return ProcessManager.ReadInt32(MemoryAddress + FinancialOffsets.RemainingTransferBudget);
            }
            set
            {
                ProcessManager.WriteInt32(value, MemoryAddress + FinancialOffsets.RemainingTransferBudget);
            }
        }

        public int SeasonTransferBudget
        {
            get
            {
                return ProcessManager.ReadInt32(MemoryAddress + FinancialOffsets.SeasonTransferBudget);
            }
            set
            {
                ProcessManager.WriteInt32(value, MemoryAddress + FinancialOffsets.SeasonTransferBudget);
            }
        }

        public sbyte TransferRevenueMadeAvailable
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + FinancialOffsets.TransferRevenueMadeAvailable);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + FinancialOffsets.TransferRevenueMadeAvailable);
            }
        }

        public int WageBudget
        {
            get
            {
                return ProcessManager.ReadInt32(MemoryAddress + FinancialOffsets.WageBudget);
            }
            set
            {
                ProcessManager.WriteInt32(value, MemoryAddress + FinancialOffsets.WageBudget);
            }
        }
    }
}
