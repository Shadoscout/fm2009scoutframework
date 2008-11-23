using System;
using System.Collections.Generic;
using System.Text;
using Young3.FMSearch.Business.Managers;
using Young3.FMSearch.Business.Offsets;
using System.Linq;

namespace Young3.FMSearch.Business.Entities.InGame
{
    public class Player : BaseObject
    {
        public Player(int memoryAddress)
            : base(memoryAddress)
        { }

        public void Heal()
        {
            ProcessManager.WriteByte(0, InjuryAddress + 20);
        }

        public string FirstName
        {
            get { return ProcessManager.ReadString(MemoryAddress + PlayerOffsets.FirstName, 0x20); }
        }

        public string LastName
        {
            get { return ProcessManager.ReadString(MemoryAddress + PlayerOffsets.LastName, 0x20); }
        }

        private int ContractAddress
        {
            get { return ProcessManager.ReadInt32(MemoryAddress + PlayerOffsets.ContractAddress); }
            set { ProcessManager.WriteInt32(value, MemoryAddress + PlayerOffsets.ContractAddress); }
        }

        private int SecondContractAddress
        {
            get { return ProcessManager.ReadInt32(MemoryAddress + PlayerOffsets.ContractAddress + 4); }
            set { ProcessManager.WriteInt32(value, MemoryAddress + PlayerOffsets.ContractAddress + 4); }
        }

        private int InjuryAddress
        {
            get { return ProcessManager.ReadInt32(MemoryAddress + PlayerOffsets.InjuryAddress); }
        }

        public int PotentialPlayingAbility
        {
            get { return ProcessManager.ReadInt16(MemoryAddress + PlayerOffsets.PotentialPlayingAbility); }
            set { ProcessManager.WriteInt16(value, MemoryAddress + PlayerOffsets.PotentialPlayingAbility); }
        }

        public int CurrentPlayingAbility
        {
            get { return ProcessManager.ReadInt16(MemoryAddress + PlayerOffsets.CurrentPlayingAbility); }
            set { ProcessManager.WriteInt16(value, MemoryAddress + PlayerOffsets.CurrentPlayingAbility); }
        }
        
        //TODO: Setting Team Address works a bit, but Team must be adjusted to create relation to the player, because player won't show up in any squad
        public int TeamAddress
        {
            get { return ProcessManager.ReadInt32(MemoryAddress + PlayerOffsets.TeamAddress); }
            set { ProcessManager.WriteInt32(value, MemoryAddress + PlayerOffsets.TeamAddress); }
        }

        private int NationalityAddress
        {
            get { return ProcessManager.ReadInt32(MemoryAddress + PlayerOffsets.Nationality); }
            set { ProcessManager.WriteInt32(value, MemoryAddress + PlayerOffsets.Nationality); }
        }

        public Country Nationality
        {
            get
            {
                if (NationalityAddress == 0) return null;
                return new Country(NationalityAddress);
            }
            set
            {
                NationalityAddress = value.MemoryAddress;
            }
        }

        public Contract Contract
        {
            get { return new Contract(ContractAddress); }
        }

        public Contract SecondContract
        {
            get
            {
                if (SecondContractAddress < 100) return null;
                else return new Contract(SecondContractAddress);
            }
        }

        public Team Team
        {
            get
            {
                try
                {
                    return new Team(TeamAddress);
                }
                catch { return null; }
            }
            set { TeamAddress = value.MemoryAddress; }
        }

        private int SkillsAddress
        {
            get { return ProcessManager.ReadInt32(MemoryAddress + PlayerOffsets.SkillsAddress); }
        }

        private int CityAddress
        {
            get { return ProcessManager.ReadInt32(MemoryAddress + PlayerOffsets.CityOfBirth); }
            set { ProcessManager.WriteInt32(value, MemoryAddress + PlayerOffsets.CityOfBirth); }
        }

        public City CityOfBirth
        {
            get { return new City(CityAddress); }
            set { CityAddress = value.MemoryAddress; }
        }

        #region Skills
        public GoalKeepingSkills GoalKeepingSkills
        {
            get { return new GoalKeepingSkills(SkillsAddress); }
        }

        public MentalSkills MentalSkills
        {
            get { return new MentalSkills(SkillsAddress); }
        }

        public PhysicalSkills PhysicalSkills
        {
            get { return new PhysicalSkills(SkillsAddress); }
        }

        public HiddenSkills HiddenSkills
        {
            get { return new HiddenSkills(SkillsAddress); }
        }

        public TechnicalSkills TechnicalSkills
        {
            get { return new TechnicalSkills(SkillsAddress); }
        }

        public PositionalSkills PositionalSkills
        {
            get { return new PositionalSkills(SkillsAddress); }
        }

        public NewPositionalSkills NewPositionalSkills
        {
            get { return new NewPositionalSkills(SkillsAddress); }
        }
        #endregion

        public int SaleValue
        {
            get
            {
                return ProcessManager.ReadInt32(MemoryAddress + PlayerOffsets.ClubOrderPrice);
            }
            set
            {
                ProcessManager.WriteInt32(value, MemoryAddress + PlayerOffsets.ClubOrderPrice);
            }
        }

        public int Condition
        {
            get
            {
                return (ProcessManager.ReadInt16(MemoryAddress + PlayerOffsets.Condition) / 100);
            }
            set
            {
                ProcessManager.WriteInt16(value * 100, MemoryAddress + PlayerOffsets.Condition);
            }
        }


        public DateTime DateOfBirth
        {
            get
            {
                return ProcessManager.ReadDateTime(MemoryAddress + PlayerOffsets.DateOfBirth);
            }
            set
            {
                ProcessManager.WriteDateTime(value, MemoryAddress + PlayerOffsets.DateOfBirth);
            }
        }

        public int Fitness
        {
            get
            {
                return (ProcessManager.ReadInt16(MemoryAddress + PlayerOffsets.Fitness) / 100);
            }
            set
            {
                ProcessManager.WriteInt16(value * 100, MemoryAddress + PlayerOffsets.Fitness);
            }
        }

        public byte InternationalCaps
        {
            get
            {
                return ProcessManager.ReadByte(MemoryAddress + PlayerOffsets.InternationalCaps);
            }
            set
            {
                ProcessManager.WriteByte(value, MemoryAddress + PlayerOffsets.InternationalCaps);
            }
        }

        public byte InternationalGoals
        {
            get
            {
                return ProcessManager.ReadByte(MemoryAddress + PlayerOffsets.InternationalGoals);
            }
            set
            {
                ProcessManager.WriteByte(value, MemoryAddress + PlayerOffsets.InternationalGoals);
            }
        }

        public byte Length
        {
            get
            {
                return ProcessManager.ReadByte(MemoryAddress + PlayerOffsets.Length);
            }
            set
            {
                ProcessManager.WriteByte(value, MemoryAddress + PlayerOffsets.Length);
            }
        }

        public byte Morale
        {
            get
            {
                return ProcessManager.ReadByte(MemoryAddress + PlayerOffsets.Morale);
            }
            set
            {
                ProcessManager.WriteByte(value, MemoryAddress + PlayerOffsets.Morale);
            }
        }

        public string Nickname
        {
            get
            {
                return ProcessManager.ReadString(MemoryAddress + PlayerOffsets.Nickname, 0x20);
            }
        }

        public int Value
        {
            get
            {
                return ProcessManager.ReadInt32(MemoryAddress + PlayerOffsets.OrderPrice);
            }
            set
            {
                ProcessManager.WriteInt32(value, MemoryAddress + PlayerOffsets.OrderPrice);
            }
        }

        public byte U21InternationalCaps
        {
            get
            {
                return ProcessManager.ReadByte(MemoryAddress + PlayerOffsets.U21InternationalCaps);
            }
            set
            {
                ProcessManager.WriteByte(value, MemoryAddress + PlayerOffsets.U21InternationalCaps);
            }
        }

        public byte U21InternationalGoals
        {
            get
            {
                return ProcessManager.ReadByte(MemoryAddress + PlayerOffsets.U21InternationalGoals);
            }
            set
            {
                ProcessManager.WriteByte(value, MemoryAddress + PlayerOffsets.U21InternationalGoals);
            }
        }

        public byte Weight
        {
            get
            {
                return ProcessManager.ReadByte(MemoryAddress + PlayerOffsets.Weight);
            }
            set
            {
                ProcessManager.WriteByte(value, MemoryAddress + PlayerOffsets.Weight);
            }
        }

        public int ID
        {
            get { return ProcessManager.ReadInt32(MemoryAddress + PlayerOffsets.Id); }
        }

        public int Age
        {
            get
            {
                return Convert.ToInt32(((Global.IngameDate - DateOfBirth)).Days / 365);
            }
        }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

    }
}
