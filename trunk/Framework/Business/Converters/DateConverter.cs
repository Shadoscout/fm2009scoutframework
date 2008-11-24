using System;
using System.Collections.Generic;

using System.Text;
using Young3.FMSearch.Business.Entities.InGame;

namespace Young3.FMSearch.Business.Converters
{
    public static class DateConverter
    {
        public static DateTime FromFmDateTime(int date)
        {
            try
            {
                ushort year = (ushort)(((date & 0xff00) >> 8) + ((date & 0xff) << 8));
                ushort num2 = (ushort)(Math.Abs((long)((date & 0xff000000L) >> 0x18)) + ((date & 0xff0000) >> 8));
                DateTime time = new DateTime(year, 1, 1);
                return time.AddDays((double)num2);
            }
            catch { return Global.IngameDate; }
        }

        public static int ToFmDateTime(DateTime date)
        {
            ushort year = (ushort)date.Year;
            year = (ushort)((year << 8) + (year >> 8));
            ushort num2 = (ushort)(date.DayOfYear - 1);
            num2 = (ushort)((num2 << 8) + (num2 >> 8));
            return ((num2 << 0x10) + year);
        }
    }
}
