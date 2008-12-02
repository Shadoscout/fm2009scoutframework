using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Young3.FMSearch.Business.Entities.InGame;
using System.Linq;

namespace Young3.FMSearch.Interface
{
    public static class Common
    {
        public static MemoryStream CreateShortlist(string name, List<Player> players)
        {
            var playerArray = (from p in players select new { p.ID }).ToArray();

            MemoryStream stream = new MemoryStream();
            using (BinaryWriter sw = new BinaryWriter(stream))
            {
                sw.Write(new byte[] { 0x02, 0x01, 0x66, 0x6C, 0x73, 0x2E, 0x01, 0x00, 0x00, 0x01, 0xC0, 0xD6, 0x64, 0x00 });
                sw.Write(FromIntToHex(name.Length));
                sw.Write(FromStringToHex(name));
                sw.Write(new byte[] { 0x00, 0x00 });
                sw.Write(FromIntToHex(playerArray.Length));
                foreach (var playerId in playerArray)
                {
                    sw.Write(FromIntToHex(playerId.ID));
                }
                sw.Write(0x00);
            }

            return stream;
        }

        private static byte[] FromIntToHex(int value)
        {
            byte[] buffer = new byte[4];
            {
                buffer[0] = (byte)(value & 0xff);
                buffer[1] = (byte)((value & 0xff00) >> 8);
                buffer[2] = (byte)((value & 0xff0000) >> 0x10);
                buffer[3] = (byte)((value & 0xff000000L) >> 0x18);
            }
            return buffer;
        }

        private static byte[] FromStringToHex(string value)
        {
            List<byte> bytes = new List<byte>();
            char[] chars = value.ToCharArray();
            foreach (char c in chars)
            {
                bytes.Add((byte)c);
                bytes.Add(0x00);
            }
            return bytes.ToArray();
        }
    }
}
