using System;
using System.Collections.Generic;
using System.Text;

namespace Young3.FMSearch.Business.Attributes
{
    public class MemoryAddressAttribute : Attribute
    {
        public int CountLength { get; set; }
        public int BytesToSkip { get; set; }

        public MemoryAddressAttribute(int CountLength, int BytesToSkip)
        {
            this.CountLength = CountLength;
            this.BytesToSkip = BytesToSkip;
        }

        public MemoryAddressAttribute() { }

    }
}
