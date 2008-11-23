using System;
using System.Collections.Generic;

using System.Text;
using System.Diagnostics;

namespace Young3.FMSearch.Business.Entities
{
    public class FMProcess
    {
        public Process Process { get; set; }
        public IntPtr Pointer { get; set; }
        public int EndPoint { get; set; }
        public int StartPoint { get { return 0x400000; } }
    }
}
