using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Young3.FMSearch.Business.Offsets;
using Young3.FMSearch.Business.Managers;

namespace Young3.FMSearch.Business.Entities.InGame
{
    public class ChairmanSkills : BaseObject
    {
        // Methods
        public ChairmanSkills(int memoryAddress)
            : base(memoryAddress)
        {
        }

        public sbyte Business
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.Business);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.Business);
            }
        }

        public sbyte Interference
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.Interference);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.Interference);
            }
        }

        public sbyte Patience
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.Patience);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.Patience);
            }
        }

        public sbyte Resources
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.Resources);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.Resources);
            }
        }
    }

    public class CoachingSkills : BaseObject
    {
        // Methods
        public CoachingSkills(int memoryAddress)
            : base(memoryAddress)
        {
        }

        public sbyte CoachingAttacking
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.CoachingAttacking);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.CoachingAttacking);
            }
        }

        public sbyte CoachingDefending
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.CoachingDefending);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.CoachingDefending);
            }
        }

        public sbyte CoachingFitness
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.CoachingFitness);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.CoachingFitness);
            }
        }

        public sbyte CoachingGoalkeepers
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.CoachingGoalkeepers);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.CoachingGoalkeepers);
            }
        }

        public sbyte CoachingMental
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.CoachingMental);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.CoachingMental);
            }
        }

        public sbyte CoachingPlayer
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.CoachingPlayer);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.CoachingPlayer);
            }
        }

        public sbyte CoachingTactical
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.CoachingTactical);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.CoachingTactical);
            }
        }

        public sbyte CoachingTechnical
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.CoachingTechnical);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.CoachingTechnical);
            }
        }

        public sbyte ManManagement
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.ManManagement);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.ManManagement);
            }
        }

        public sbyte WorkingWithYoungsters
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.WorkingWithYoungsters);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.WorkingWithYoungsters);
            }
        }
    }
    public class CoachMentalSkills : BaseObject
    {
        // Methods
        public CoachMentalSkills(int memoryAddress)
            : base(memoryAddress)
        {
        }

        public sbyte Adaptability
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.Adaptability);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.Adaptability);
            }
        }

        public sbyte JudgingPlayerAbility
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.JudgingPlayerAbility);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.JudgingPlayerAbility);
            }
        }

        public sbyte JudgingPlayerPotential
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.JudgingPlayerPotential);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.JudgingPlayerPotential);
            }
        }

        public sbyte LevelOfDiscipline
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.LevelOfDiscipline);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.LevelOfDiscipline);
            }
        }

        public sbyte Motivating
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.Motivating);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.Motivating);
            }
        }

        public sbyte Physiotherapy
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.Physiotherapy);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.Physiotherapy);
            }
        }

        public sbyte TacticalKnowledge
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.TacticalKnowledge);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.TacticalKnowledge);
            }
        }
    }

    public class MentalTraitsSkills : BaseObject
    {
        // Methods
        public MentalTraitsSkills(int memoryAddress)
            : base(memoryAddress)
        {
        }

        public sbyte Adaptability
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.CoachAdaptability);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.CoachAdaptability);
            }
        }

        public sbyte Ambition
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.CoachAmbition);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.CoachAmbition);
            }
        }

        public sbyte Controversy
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.CoachControversy);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.CoachControversy);
            }
        }

        public sbyte Determination
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.Determination);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.Determination);
            }
        }

        public sbyte Loyalty
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.CoachLoyalty);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.CoachLoyalty);
            }
        }

        public sbyte Pressure
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.CoachPressure);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.CoachPressure);
            }
        }

        public sbyte Professionalism
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.CoachProfessionalism);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.CoachProfessionalism);
            }
        }

        public sbyte Sportsmanship
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.CoachSportsmanship);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.CoachSportsmanship);
            }
        }

        public sbyte Temperament
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.CoachTemperament);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.CoachTemperament);
            }
        }
    }


    public class NonTacticalSkills : BaseObject
    {
        // Methods
        public NonTacticalSkills(int memoryAddress)
            : base(memoryAddress)
        {
        }

        public sbyte BuyingPlayers
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.BuyingPlayers);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.BuyingPlayers);
            }
        }

        public sbyte HardnessOfTraining
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.HardnessOfTraining);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.HardnessOfTraining);
            }
        }

        public sbyte MindGames
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.MindGames);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.MindGames);
            }
        }

        public sbyte SquadRotation
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.SquadRotation);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.SquadRotation);
            }
        }
    }

    public class RolesSkills : BaseObject
    {
        public RolesSkills(int memoryAddress)
            : base(memoryAddress)
        {
        }

        public sbyte AssistantManager
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.AssistantManager);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.AssistantManager);
            }
        }

        public sbyte Coach
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.Coach);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.Coach);
            }
        }

        public sbyte FitnessCoach
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.FitnessCoach);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.FitnessCoach);
            }
        }

        public sbyte GoalkeepingCoach
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.GoalkeepingCoach);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.GoalkeepingCoach);
            }
        }

        public sbyte Manager
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.Manager);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.Manager);
            }
        }

        public sbyte Physio
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.Physio);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.Physio);
            }
        }

        public sbyte Scout
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.Scout);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.Scout);
            }
        }
    }

    public class CoachTacticalSkills : BaseObject
    {
        
        public CoachTacticalSkills(int memoryAddress)
            : base(memoryAddress)
        {
        }

        public sbyte Attacking
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.Attacking);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.Attacking);
            }
        }

        public sbyte Depth
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.Depth);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.Depth);
            }
        }

        public sbyte Directness
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.Directness);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.Directness);
            }
        }

        public sbyte Flamboyancy
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.Flamboyancy);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.Flamboyancy);
            }
        }

        public sbyte Flexibility
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.Flexibility);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.Flexibility);
            }
        }

        public sbyte FreeRoles
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.FreeRoles);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.FreeRoles);
            }
        }

        public sbyte Marking
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.CoachMarking);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.CoachMarking);
            }
        }

        public sbyte OffSide
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.OffSide);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.OffSide);
            }
        }

        public sbyte Pressing
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.Pressing);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.Pressing);
            }
        }

        public sbyte SittingBack
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.SittingBack);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.SittingBack);
            }
        }

        public sbyte Tempo
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.Tempo);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.Tempo);
            }
        }

        public sbyte UseOfPlaymaker
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.UseOfPlaymaker);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.UseOfPlaymaker);
            }
        }

        public sbyte UseOfSubstitutions
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.UseOfSubstitutions);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.UseOfSubstitutions);
            }
        }

        public sbyte Width
        {
            get
            {
                return ProcessManager.ReadSByte(MemoryAddress + StaffSkillOffsets.Width);
            }
            set
            {
                ProcessManager.WriteSByte(value, MemoryAddress + StaffSkillOffsets.Width);
            }
        }
    }

}
