using System;
using System.Collections.Generic;

using System.Text;
using Young3.FMSearch.Business.Entities;
using System.Diagnostics;

namespace Young3.FMSearch.Business.Managers
{
    public static class ProcessManager
    {
        private static FMProcess fmProcess = null;
        public static FMProcess FMProcess
        { get {
                if (null == fmProcess)
                    fmProcess = LoadProcess();

                return fmProcess;
            }
        }

        /// <summary>
        /// Loads the current football manager process into a memory object
        /// </summary>
        /// <returns></returns>
        private static FMProcess LoadProcess()
        {
            FMProcess fmProcess = new FMProcess();
            {
                Process[] fmProcesses = Process.GetProcessesByName("fm");
                Process[] wsmProcesses = Process.GetProcessesByName("wsm");
                if (fmProcesses.Length > 0 || wsmProcesses.Length > 0)
                {
                    Process activeProcess;
                    if (fmProcesses.Length > 0)
                        activeProcess = fmProcesses[0];
                    else
                        activeProcess = wsmProcesses[0];

                    fmProcess.Pointer = ProcessMemoryApi.OpenProcess(0x38, 1, (uint)activeProcess.Id);
                    fmProcess.EndPoint = GetProcessEndPoint(fmProcess.Pointer);
                }
            }

            return fmProcess;
        }

        private static int GetProcessEndPoint(IntPtr process)
        {
            int bytesRead = 0;
            int memoryAddress = 0x6fffffff;
            int num3 = 0x1000000;
            for (int i = 1; i <= 7; i++)
            {
                ReadProcessMemory(process, memoryAddress, 1, out bytesRead);
                while (bytesRead == 0)
                {
                    memoryAddress -= num3;
                    ReadProcessMemory(process, memoryAddress, 1, out bytesRead);
                }
                memoryAddress += num3;
                num3 /= 0x10;
            }
            return memoryAddress;
        }

        private static byte[] ReadProcessMemory(IntPtr process, int memoryaddressess, uint bytesToRead, out int bytesRead)
        {
            IntPtr ptr;
            byte[] buffer = new byte[bytesToRead];
            ProcessMemoryApi.ReadProcessMemory(process, (IntPtr)memoryaddressess, buffer, bytesToRead, out ptr);
            bytesRead = ptr.ToInt32();
            return buffer;
        }

        public static byte ReadByte(int address)
        {
            return ReadProcessMemory(address, 1)[0];
        }

        public static DateTime ReadDateTime(int address)
        {
            byte[] buffer = ReadProcessMemory(address, 4);
            return Converters.DateConverter.FromFmDateTime(((buffer[3] + (buffer[2] * 0x100)) + (buffer[1] * 0x10000)) + (buffer[0] * 0x1000000));
        }

        public static int ReadInt16(int address)
        {
            byte[] buffer = ReadProcessMemory(address, 2);
            return (buffer[0] + (buffer[1] * 0x100));
        }

        public static int ReadInt32(int address)
        {
            byte[] buffer = ReadProcessMemory(address, 4);
            return (((buffer[0] + (buffer[1] * 0x100)) + (buffer[2] * 0x10000)) + (buffer[3] * 0x1000000));
        }

        public static sbyte ReadSByte(int address)
        {
            return (sbyte)ReadProcessMemory(address, 1)[0];
        }

        public static uint ReadUInt32(int address)
        {
            byte[] buffer = ReadProcessMemory(address, 4);
            return (uint)(((buffer[0] + (buffer[1] * 0x100)) + (buffer[2] * 0x10000)) + (buffer[3] * 0x1000000));
        }

        public static string ReadString(int currentAddress, int? addBufferIndex)
        {
            currentAddress = ProcessManager.ReadInt32(currentAddress);

            string str = "";
            int bytesRead = 0;

            byte[] buffer = ProcessManager.ReadProcessMemory(currentAddress, 0x30, out bytesRead);
            if (bytesRead < 0x30)
            {
                return "";
            }
            if (addBufferIndex.HasValue)
            {
                int memoryAddress = GetAddress(buffer, addBufferIndex.Value);
                if ((memoryAddress < ProcessManager.FMProcess.StartPoint) || (memoryAddress > ProcessManager.FMProcess.EndPoint))
                {
                    return "";
                }
                buffer = ProcessManager.ReadProcessMemory(memoryAddress, 0x30, out bytesRead);
                if (bytesRead < 0x30)
                {
                    return "";
                }
            }
            int address = GetAddress(buffer, 12);
            buffer = ProcessManager.ReadProcessMemory(address, 0x60, out bytesRead);
            for (int i = 0; (i < 0x60) && (buffer[i] != 0); i += 2)
            {
                str = str + Convert.ToChar((int)(buffer[i] + (buffer[i + 1] * 0x100)));
            }

            //byte[] test = StringToByteArray(str);

            return str;
        }

        public static void WriteByte(byte value, int address)
        {
            byte[] buffer = new byte[] { value };
            WriteProcessMemory(address, buffer, 1);
        }

        public static void WriteDateTime(DateTime value, int address)
        {
            WriteInt32(Converters.DateConverter.ToFmDateTime(value), address, true);
        }

        public static void WriteInt16(int value, int address)
        {
            WriteInt16(value, address, false);
        }

        public static void WriteInt16(int value, int address, bool reverse)
        {
            byte[] buffer = new byte[2];
            if (!reverse)
            {
                buffer[0] = (byte)(value & 0xff);
                buffer[1] = (byte)((value & 0xff00) >> 8);
            }
            else
            {
                buffer[1] = (byte)(value & 0xff);
                buffer[0] = (byte)((value & 0xff00) >> 8);
            }
            WriteProcessMemory(address, buffer, 2);
        }

        public static void WriteInt32(int value, int address)
        {
            WriteInt32(value, address, false);
        }

        public static void WriteInt32(int value, int address, bool reverse)
        {
            byte[] buffer = new byte[4];
            if (!reverse)
            {
                buffer[0] = (byte)(value & 0xff);
                buffer[1] = (byte)((value & 0xff00) >> 8);
                buffer[2] = (byte)((value & 0xff0000) >> 0x10);
                buffer[3] = (byte)((value & 0xff000000L) >> 0x18);
            }
            else
            {
                buffer[3] = (byte)(value & 0xff);
                buffer[2] = (byte)((value & 0xff00) >> 8);
                buffer[1] = (byte)((value & 0xff0000) >> 0x10);
                buffer[0] = (byte)((value & 0xff000000L) >> 0x18);
            }
            WriteProcessMemory(address, buffer, 4);
        }

        public static int WriteProcessMemory(int memoryaddressess, byte[] buffer, uint bytesToWrite)
        {
            IntPtr ptr;
            ProcessMemoryApi.WriteProcessMemory(FMProcess.Pointer, (IntPtr)memoryaddressess, buffer, bytesToWrite, out ptr);
            return ptr.ToInt32();
        }

        public static void WriteString(byte[] value, int address)
        {
            WriteProcessMemory(address, value, 4);
        }

        public static void WriteSByte(sbyte value, int address)
        {
            byte[] buffer = new byte[] { (byte)value };
            WriteProcessMemory(address, buffer, 1);
        }


        public static byte[] ReadProcessMemory(int memoryAdress, uint bytesToRead)
        {
            if (memoryAdress > 0)
            {
                int num;
                byte[] buffer = ReadProcessMemory(memoryAdress, bytesToRead, out num);
                if (num != bytesToRead)
                {
                    //throw new InvalidOperationException(string.Format("Only {0} bytes could be read from addressess {1:X}, expected {2}.", num, memoryAdress, bytesToRead));
                    return new byte[] { 0, 0, 0, 0 };
                }
                return buffer;
            }
            return new byte[4];
        }

        public static byte[] ReadProcessMemory(int memoryaddressess, uint bytesToRead, out int bytesRead)
        {
            IntPtr ptr;
            byte[] buffer = new byte[bytesToRead];
            ProcessMemoryApi.ReadProcessMemory(FMProcess.Pointer, (IntPtr)memoryaddressess, buffer, bytesToRead, out ptr);
            bytesRead = ptr.ToInt32();
            return buffer;
        }

        public static byte[] StringToByteArray(string inputString)
        {
            List<byte> buffer = new List<byte>();
            foreach (char c in inputString.ToCharArray())
            {
                byte[] twoBytes = { (byte)(c & 0xff), (byte)(c >> 8 & 0xff) };
                buffer.Add(twoBytes[0]);
                buffer.Add(twoBytes[1]);
            }
            return buffer.ToArray();
        }

        public static int GetAddress(byte[] buffer, int index)
        {
            int num = 0;
            try
            {
                num += buffer[index];
                num += buffer[index + 1] * 0x100;
                num += buffer[index + 2] * 0x10000;
                num += buffer[index + 3] * 0x1000000;
            }
            catch
            {
                return 0;
            }
            return num;
        }
    }
}
