using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Young3.FMSearch.Business.Managers;
using Young3.FMSearch.Business.Offsets;

namespace Young3.FMSearch.Business.Entities.InGame
{
    public class TechnicalSkills : BaseObject
    {
        public TechnicalSkills(int memoryAddress)
            : base(memoryAddress)
        { }

        public sbyte Corners
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Corners);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Corners);
            }
        }

        public sbyte Crossing
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Crossing);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Crossing);
            }
        }

        public sbyte Dribbling
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Dribbling);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Dribbling);
            }
        }

        public sbyte Finishing
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Finishing);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Finishing);
            }
        }

        public sbyte FirstTouch
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.FirstTouch);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.FirstTouch);
            }
        }

        public sbyte Freekicks
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Freekicks);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Freekicks);
            }
        }

        public sbyte Heading
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Heading);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Heading);
            }
        }

        public sbyte LongShots
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.LongShots);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.LongShots);
            }
        }

        public sbyte Longthrows
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Longthrows);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Longthrows);
            }
        }

        public sbyte Marking
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Marking);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Marking);
            }
        }

        public sbyte Passing
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Passing);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Passing);
            }
        }

        public sbyte PenaltyTaking
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.PenaltyTaking);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.PenaltyTaking);
            }
        }

        public sbyte Tackling
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Tackling);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Tackling);
            }
        }

        public sbyte Technique
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Technique);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Technique);
            }
        }
    }

    public class GoalKeepingSkills : BaseObject
    {
        public GoalKeepingSkills(int memoryAddress)
            : base(memoryAddress)
        { }

        public sbyte AerialAbility
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.AerialAbility);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.AerialAbility);
            }
        }

        public sbyte CommandOfArea
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.CommandOfArea);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.CommandOfArea);
            }
        }

        public sbyte Communication
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Communication);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Communication);
            }
        }

        public sbyte Eccentricity
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Eccentricity);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Eccentricity);
            }
        }

        public sbyte Handling
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Handling);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Handling);
            }
        }

        public sbyte Kicking
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Kicking);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Kicking);
            }
        }

        public sbyte OneOnOnes
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.OneOnOnes);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.OneOnOnes);
            }
        }

        public sbyte Reflexes
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Reflexes);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Reflexes);
            }
        }

        public sbyte RushingOut
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.RushingOut);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.RushingOut);
            }
        }

        public sbyte TendencyToPunch
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.TendencyToPunch);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.TendencyToPunch);
            }
        }

        public sbyte Throwing
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Throwing);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Throwing);
            }
        }
    }

    public class HiddenSkills : BaseObject
    {
        public HiddenSkills(int memoryAddress)
            : base(memoryAddress)
        { }

        public sbyte Consistency
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Consistency);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Consistency);
            }
        }

        public sbyte Dirtyness
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Dirtyness);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Dirtyness);
            }
        }

        public sbyte ImportantMatches
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.ImportantMatches);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.ImportantMatches);
            }
        }

        public sbyte InjuryProness
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.InjuryProness);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.InjuryProness);
            }
        }

        public sbyte Versatility
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Versatility);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Versatility);
            }
        }
    }

    public class MentalSkills : BaseObject
    {
        public MentalSkills(int memoryAddress)
            : base(memoryAddress)
        { }

        public sbyte Aggression
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Aggression);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Aggression);
            }
        }

        public sbyte Anticipation
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Anticipation);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Anticipation);
            }
        }

        public sbyte Bravery
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Bravery);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Bravery);
            }
        }

        public sbyte Composure
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Composure);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Composure);
            }
        }

        public sbyte Concentration
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Concentration);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Concentration);
            }
        }

        public sbyte Creativity
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Creativity);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Creativity);
            }
        }

        public sbyte Decisions
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Decisions);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Decisions);
            }
        }

        public sbyte Determination
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Determination);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Determination);
            }
        }

        public sbyte Flair
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Flair);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Flair);
            }
        }

        public sbyte Influence
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Influence);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Influence);
            }
        }

        public sbyte OffTheBall
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.OffTheBall);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.OffTheBall);
            }
        }

        public sbyte Positioning
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Positioning);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Positioning);
            }
        }

        public sbyte Teamwork
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Teamwork);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Teamwork);
            }
        }

        public sbyte Workrate
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Workrate);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Workrate);
            }
        }
    }

    public class PhysicalSkills : BaseObject
    {
        public PhysicalSkills(int memoryAddress)
            : base(memoryAddress)
        { }

        public sbyte Acceleration
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Acceleration);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Acceleration);
            }
        }

        public sbyte Agility
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Agility);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Agility);
            }
        }

        public sbyte Balance
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Balance);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Balance);
            }
        }

        public sbyte Jumping
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Jumping);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Jumping);
            }
        }

        public sbyte LeftFoot
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.LeftFoot);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.LeftFoot);
            }
        }

        public sbyte NaturalFitness
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.NaturalFitness);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.NaturalFitness);
            }
        }

        public sbyte Pace
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Pace);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Pace);
            }
        }

        public sbyte RightFoot
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.RightFoot);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.RightFoot);
            }
        }

        public sbyte Stamina
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Stamina);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Stamina);
            }
        }

        public sbyte Strength
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + SkillOffsets.Strength);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + SkillOffsets.Strength);
            }
        }
    }
}
