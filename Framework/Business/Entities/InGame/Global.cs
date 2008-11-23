using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Young3.FMSearch.Business.Managers;

namespace Young3.FMSearch.Business.Entities.InGame
{
    public static class Global
    {
        public static DateTime IngameDate
        {
            get
            {
                DateTime dateTime = ProcessManager.ReadDateTime((int)MemoryAddresses.CurrentDateTime);
                return dateTime;
            }
        }

        public static BaseObject ActiveObject
        {
            get
            {
                int objAddress = ProcessManager.ReadInt32((int)MemoryAddresses.ActiveObject);
                //objAddress = ProcessManager.ReadInt32(objAddress);

                if (ObjectManager.Players.Where(a => a.MemoryAddress == objAddress - 236).Count() > 0)
                    return ObjectManager.Players.Single(a => a.MemoryAddress == objAddress - 236);
                else
                    return null;
            }
        }
    }
}
