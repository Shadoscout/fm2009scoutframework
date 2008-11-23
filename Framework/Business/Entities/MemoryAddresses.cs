using System;
using System.Collections.Generic;

using System.Text;
using Young3.FMSearch.Business.Attributes;

namespace Young3.FMSearch.Business.Entities
{
    public enum MemoryAddresses
    {
        [MemoryAddressAttribute(CountLength = 8, BytesToSkip = 4)]
        City = 0x20536ac,
        [MemoryAddressAttribute(CountLength = 8, BytesToSkip = 4)]
        Club = 0x20536b0,
        [MemoryAddressAttribute(CountLength = 8, BytesToSkip = 4)]
        Continent = 0x20536b8,
        [MemoryAddressAttribute(CountLength=8, BytesToSkip=4)]
        Country = 0x20536d0,
        [MemoryAddressAttribute(CountLength = 8, BytesToSkip = 4)]
        Stadium = 0x20536fc,
        [MemoryAddressAttribute(CountLength = 8, BytesToSkip = 4)]
        Team = 0x2053708,
        [MemoryAddressAttribute(CountLength=4, BytesToSkip=0)]
        Player = 0x205371c,
        [MemoryAddressAttribute(CountLength = 4, BytesToSkip = 0)]
        Coach = 0x20537e8,
        CurrentDateTime = 0x20537f0,
        ActiveObject = 31750968
    }
}
