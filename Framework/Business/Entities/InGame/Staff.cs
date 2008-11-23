using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Young3.FMSearch.Business.Managers;
using Young3.FMSearch.Business.Offsets;

namespace Young3.FMSearch.Business.Entities.InGame
{
    public class Staff : BaseObject
    {
        public Staff(int memoryAddress)
            : base(memoryAddress)
        { }

        public int Age
        {
            get
            {
                return Convert.ToInt32(((Global.IngameDate - DateOfBirth)).Days / 365);
            }
        }

        private int CityOfBirthAddress
        {
            get { return ProcessManager.ReadInt32(MemoryAddress + StaffOffsets.CityOfBirth); }
            set { ProcessManager.WriteInt32(value, MemoryAddress + StaffOffsets.CityOfBirth, false); }
        }

        public City CityOfBirth
        {
            get { return new City(CityOfBirthAddress); }
            set { CityOfBirthAddress = value.MemoryAddress; }
        }

        public ChairmanSkills ChairmanSkills
        {
            get { return new ChairmanSkills(ProcessManager.ReadInt32(MemoryAddress + StaffOffsets.SkillsAdress)); }
        }

        public CoachingSkills CoachingSkills
        {
            get { return new CoachingSkills(ProcessManager.ReadInt32(MemoryAddress + StaffOffsets.SkillsAdress)); }
        }

        public CoachMentalSkills MentalSkills
        {
            get { return new CoachMentalSkills(ProcessManager.ReadInt32(MemoryAddress + StaffOffsets.SkillsAdress)); }
        }

        public MentalTraitsSkills MentalTraitsSkills
        {
            get { return new MentalTraitsSkills(ProcessManager.ReadInt32(MemoryAddress + StaffOffsets.SkillsAdress)); }
        }

        public NonTacticalSkills NonTacticalSkills
        {
            get { return new NonTacticalSkills(ProcessManager.ReadInt32(MemoryAddress + StaffOffsets.SkillsAdress)); }
        }

        public RolesSkills RolesSkills
        {
            get { return new RolesSkills(ProcessManager.ReadInt32(MemoryAddress + StaffOffsets.SkillsAdress)); }
        }

        public CoachTacticalSkills TacticalSkills
        {
            get { return new CoachTacticalSkills(ProcessManager.ReadInt32(MemoryAddress + StaffOffsets.SkillsAdress)); }
        }

        public Contract Contract
        {
            get
            {
                int address = ProcessManager.ReadInt32(MemoryAddress + StaffOffsets.ContractPointer);
                int memoryAddress = ProcessManager.ReadInt32(address);
                return new Contract(memoryAddress);
            }
        }

        public int CurrentCoachingAbility
        {
            get { return ProcessManager.ReadInt16(MemoryAddress + StaffOffsets.CurrentCoachingAbility); }
            set { ProcessManager.WriteInt16(value, MemoryAddress + StaffOffsets.CurrentCoachingAbility); }
        }

        public DateTime DateOfBirth
        {
            get { return ProcessManager.ReadDateTime(MemoryAddress + StaffOffsets.DateOfBirth); }
            set { ProcessManager.WriteDateTime(value, MemoryAddress + StaffOffsets.DateOfBirth); }
        }

        public string FirstName
        {
                get { return ProcessManager.ReadString(MemoryAddress + StaffOffsets.FirstName, 0x20); }
        }

        public byte InternationalCaps
        {
            get { return ProcessManager.ReadByte(MemoryAddress + StaffOffsets.InternationalCaps); }
            set { ProcessManager.WriteByte(value, MemoryAddress + StaffOffsets.InternationalCaps); }
        }

        public byte InternationalGoals
        {
            get { return ProcessManager.ReadByte(MemoryAddress + StaffOffsets.InternationalGoals); }
            set { ProcessManager.WriteByte(value, MemoryAddress + StaffOffsets.InternationalGoals); }
        }

        public string LastName
        {
            get { return ProcessManager.ReadString(MemoryAddress + StaffOffsets.LastName, 0x20); }
        }

        private int NationalityAddress
        {
            get { return ProcessManager.ReadInt32(MemoryAddress + StaffOffsets.Nationality); }
            set { ProcessManager.WriteInt32(value, MemoryAddress + StaffOffsets.Nationality, false); }
        }

        public Country Nationality
        {
            get { return new Country(NationalityAddress); }
            set { NationalityAddress = value.MemoryAddress; }
        }

        public string Nickname
        {
            get { return ProcessManager.ReadString(MemoryAddress + StaffOffsets.Nickname, 0x20); }
        }

        public int PotentialCoachingAbility
        {
            get { return ProcessManager.ReadInt16(MemoryAddress + StaffOffsets.PotentialCoachingAbility); }
            set { ProcessManager.WriteInt16(value, MemoryAddress + StaffOffsets.PotentialCoachingAbility); }
        }

        public byte U21InternationalCaps
        {
            get { return ProcessManager.ReadByte(MemoryAddress + StaffOffsets.U21InternationalCaps); }
            set { ProcessManager.WriteByte(value, MemoryAddress + StaffOffsets.U21InternationalCaps); }
        }

        public byte U21InternationalGoals
        {
            get { return ProcessManager.ReadByte(MemoryAddress + StaffOffsets.U21InternationalGoals); }
            set { ProcessManager.WriteByte(value, MemoryAddress + StaffOffsets.U21InternationalGoals); }
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
