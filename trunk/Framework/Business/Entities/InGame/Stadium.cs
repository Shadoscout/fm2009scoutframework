using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Young3.FMSearch.Business.Offsets;
using Young3.FMSearch.Business.Managers;

namespace Young3.FMSearch.Business.Entities.InGame
{
    public class Stadium : BaseObject
    {
        public Stadium(int memoryAddress)
            : base(memoryAddress)
        { }

        // Properties
        public int FieldLength
        {
            get
            {
                return ProcessManager.ReadInt32(MemoryAddress + StadiumOffsets.Length);
            }
            set
            {
                ProcessManager.WriteInt32(value, MemoryAddress + StadiumOffsets.Length);
            }
        }

        public int MaxCapacity
        {
            get
            {
                return ProcessManager.ReadInt32(MemoryAddress + StadiumOffsets.MaxCapacity);
            }
            set
            {
                ProcessManager.WriteInt32(value, MemoryAddress + StadiumOffsets.MaxCapacity);
            }
        }

        public int SeatingCapacity
        {
            get
            {
                return ProcessManager.ReadInt32(MemoryAddress + StadiumOffsets.SeatingCapacity);
            }
            set
            {
                ProcessManager.WriteInt32(value, MemoryAddress + StadiumOffsets.SeatingCapacity);
            }
        }


       public int StadiumCapacity
        {
            get
            {
                return ProcessManager.ReadInt32(MemoryAddress + StadiumOffsets.StadiumCapacity);
            }
            set
            {
                ProcessManager.WriteInt32(value, MemoryAddress + StadiumOffsets.StadiumCapacity);
            }
        }

        public int UsedCapacity
        {
            get
            {
                return ProcessManager.ReadInt32(MemoryAddress + StadiumOffsets.UsedCapacity);
            }
            set
            {
                ProcessManager.WriteInt32(value, MemoryAddress + StadiumOffsets.UsedCapacity);
            }
        }

        public int FieldWidth
        {
            get
            {
                return ProcessManager.ReadInt32(MemoryAddress + StadiumOffsets.Width);
            }
            set
            {
                ProcessManager.WriteInt32(value, MemoryAddress + StadiumOffsets.Width);
            }
        }

    }
}
