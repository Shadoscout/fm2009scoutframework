using System;
using System.Collections.Generic;

using System.Text;

namespace Young3.FMSearch.Business.Offsets
{
    public sealed class StadiumOffsets
    {
        public static byte Length = 0x4e;
        public static int MaxCapacity = 0x44;
        public static int Name = 0x1c;
        public static int SeatingCapacity = 0x2c;
        public static int StadiumCapacity = 40;
        public static int StadiumLength = 0x68;
        public static int UsedCapacity = 0x40;
        public static byte Width = 80;
    }
}
