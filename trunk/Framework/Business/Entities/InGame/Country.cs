using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Young3.FMSearch.Business.Managers;
using Young3.FMSearch.Business.Offsets;

namespace Young3.FMSearch.Business.Entities.InGame
{
    public class Country : BaseObject
    {
        public Country(int memoryAddress)
            : base(memoryAddress)
        { }

        private int CapitalAddress
        {
            get { return ProcessManager.ReadInt32(MemoryAddress + CountryOffsets.Capital); }
            set { ProcessManager.WriteInt32(value, MemoryAddress + CountryOffsets.Capital, false); }
        }

        public City Capital
        {
            get
            {
                if (CapitalAddress == 0) return null;
                return new City(CapitalAddress);
            }
        }

        private int ContinentAddress
        {
            get {return ProcessManager.ReadInt32(MemoryAddress + CountryOffsets.Continent);}
        }

        public Continent Continent
        {
            get
            {
                try { return new Continent(ContinentAddress); }
                catch { return null; }
            }
        }

        public CountryDevelopment Development
        {
            get
            {
                return (CountryDevelopment)ProcessManager.ReadByte(MemoryAddress + CountryOffsets.Development);
            }
            set
            {
                ProcessManager.WriteByte((byte)value, MemoryAddress + CountryOffsets.Development);
            }
        }

        public byte Economy
        {
            get
            {
                return ProcessManager.ReadByte(MemoryAddress + CountryOffsets.Economy);
            }
            set
            {
                ProcessManager.WriteByte(value, MemoryAddress + CountryOffsets.Economy);
            }
        }

        public CountryEUMember EuroMember
        {
            get
            {
                return (CountryEUMember)ProcessManager.ReadByte(MemoryAddress + CountryOffsets.EuroMember);
            }
            set
            {
                ProcessManager.WriteByte((byte)value, MemoryAddress + CountryOffsets.EuroMember);
            }
        }

        public byte FIFAPosition
        {
            get
            {
                return ProcessManager.ReadByte(MemoryAddress + CountryOffsets.FIFAPosition);
            }
            set
            {
                ProcessManager.WriteByte(value, MemoryAddress + CountryOffsets.FIFAPosition);
            }
        }

        public int FIFAScore
        {
            get
            {
                return ProcessManager.ReadInt16(MemoryAddress + CountryOffsets.FIFAScore);
            }
            set
            {
                ProcessManager.WriteInt16(value, MemoryAddress + CountryOffsets.FIFAScore);
            }
        }

        public CountryImportance Importance
        {
            get
            {
                return (CountryImportance)ProcessManager.ReadByte(MemoryAddress + CountryOffsets.Importance);
            }
            set
            {
                ProcessManager.WriteByte((byte)value, MemoryAddress + CountryOffsets.Importance);
            }
        }

        public byte LeagueImportancy
        {
            get
            { return ProcessManager.ReadByte(MemoryAddress + CountryOffsets.LeagueImportancy); }
            set
            { ProcessManager.WriteByte(value, MemoryAddress + CountryOffsets.LeagueImportancy); }
        }

        public int Reputation
        {
            get
            {
                return ProcessManager.ReadInt16(MemoryAddress + CountryOffsets.Reputation);
            }
            set { ProcessManager.WriteInt16(value, MemoryAddress + CountryOffsets.Reputation); }
        }

        public string Name
        {
            get
            { return ProcessManager.ReadString(MemoryAddress + CountryOffsets.Name, null); }
        }
    }

    public enum CountryDevelopment
    {
        FirstWorld = 1,
        SecondWorld = 2,
        ThirdWorld = 3
    }

    public enum CountryEUMember
    {
        No = 1,
        Yes = 2
    }

    public enum CountryImportance
    {
        NooneCares = 4,
        Important = 2,
        Unimportant = 3,
        VeryImportant = 1
    }
}
