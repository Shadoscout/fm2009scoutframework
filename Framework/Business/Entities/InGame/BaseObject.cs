using System;
using System.Collections.Generic;

using System.Text;

namespace Young3.FMSearch.Business.Entities.InGame
{
    public class BaseObject
    {
        public BaseObject(int memoryAddress)
        {
            MemoryAddress = memoryAddress;
        }

        public int MemoryAddress;

        public static bool operator ==(BaseObject a, BaseObject b)
        {
            if (System.Object.ReferenceEquals(a, b))
                return true;

            //cast to object, otherwise there will be a LOOOOONG loop
            if (((object)a == null) || ((object)b == null))
                return false;

            if (a.MemoryAddress == b.MemoryAddress)
                return true;
            else
                return false;
        }

        public static bool operator !=(BaseObject a, BaseObject b)
        {
            if (!System.Object.ReferenceEquals(a, b))
                return true;

            if (((object)a == null) || ((object)b == null))
                return true;

            if (a.MemoryAddress != b.MemoryAddress)
                return true;
            else
                return false;
        }
    }
}
