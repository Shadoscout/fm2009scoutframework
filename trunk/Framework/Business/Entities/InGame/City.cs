using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Young3.FMSearch.Business.Managers;
using Young3.FMSearch.Business.Offsets;

namespace Young3.FMSearch.Business.Entities.InGame
{
   public class City : BaseObject
    {
        public City(int memoryAddress)
            : base(memoryAddress)
        { }

        public string Name
        {
            get { return ProcessManager.ReadString(MemoryAddress + CityOffsets.Name, null); }
        }
    }
}
