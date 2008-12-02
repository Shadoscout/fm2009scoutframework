using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Young3.FMSearch.Business.Offsets;
using Young3.FMSearch.Business.Managers;

namespace Young3.FMSearch.Business.Entities.InGame
{
   public class PositionalSkills : BaseObject
    {
       public PositionalSkills(int memoryAddress)
           : base(memoryAddress)
       {
       }


       public override string ToString()
       {
           string baseString = "";

           if (this.Goalkeeper > 15) baseString += "/GK";
           if (this.Defender > 15) baseString += "/D";
           if (this.WingBack > 15) baseString += "/WB";
           if (this.DefensiveMidfielder > 15) baseString += "/DM";
           if (this.Midfielder > 15) baseString += "/M";
           if (this.AttackingMidfielder > 15) baseString += "/AM";
           if (this.Attacker > 15) baseString += "/S";

           baseString += " ";

           if (this.Right > 15) baseString += "R";
           if (this.Left > 15) baseString += "L";
           if (this.Centre > 15) baseString += "C";

           baseString = baseString.Substring(1, baseString.Length - 1);

           return baseString;
       }

       public sbyte Attacker
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.Attacker);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.Attacker);
           }
       }

       public sbyte AttackingMidfielder
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.AttackingMidfielder);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.AttackingMidfielder);
           }
       }

       public sbyte Centre
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.Centre);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.Centre);
           }
       }

       public sbyte Defender
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.Defender);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.Defender);
           }
       }

       public sbyte DefensiveMidfielder
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.DefensiveMidfielder);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.DefensiveMidfielder);
           }
       }

       public sbyte FreeRole
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.FreeRole);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.FreeRole);
           }
       }

       public sbyte Goalkeeper
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.Goalkeeper);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.Goalkeeper);
           }
       }

       public sbyte Left
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.Left);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.Left);
           }
       }

       public sbyte Midfielder
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.Midfielder);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.Midfielder);
           }
       }

       public sbyte Right
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.Right);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.Right);
           }
       }

       public sbyte Sweeper
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.Sweeper);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.Sweeper);
           }
       }

       public sbyte WingBack
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.WingBack);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.WingBack);
           }
       }
    }

   public class NewPositionalSkills : BaseObject
   {
       public NewPositionalSkills(int memoryAddress)
           : base(memoryAddress)
       {
       }

       public sbyte AttackerCentral
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.NewAttCentre);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.NewAttCentre);
           }
       }

       public sbyte AttackingMidCentral
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.NewAttMidCentre);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.NewAttMidCentre);
           }
       }

       public sbyte AttackingMidLeft
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.NewAttMidLeft);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.NewAttMidLeft);
           }
       }

       public sbyte AttackingMidRight
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.NewAttMidRight);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.NewAttMidRight);
           }
       }

       public sbyte DefenderCentral
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.NewDefCentre);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.NewDefCentre);
           }
       }

       public sbyte DefenderLeft
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.NewDefLeft);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.NewDefLeft);
           }
       }

       public sbyte DefenderRight
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.NewDefRight);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.NewDefRight);
           }
       }

       public sbyte DefensiveMidfielderCentral
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.NewDefMidCentre);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.NewDefMidCentre);
           }
       }

       public sbyte MidfielderCentral
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.NewMidCentre);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.NewMidCentre);
           }
       }

       public sbyte MidfielderLeft
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.NewMidLeft);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.NewMidLeft);
           }
       }

       public sbyte MidfielderRight
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.NewMidRight);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.NewMidRight);
           }
       }

       public sbyte WingBackLeft
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.NewWingBackLeft);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.NewWingBackLeft);
           }
       }

       public sbyte WingBackRight
       {
           get
           {
               return ProcessManager.ReadSByte(MemoryAddress + PositionOffsets.NewWingBackRight);
           }
           set
           {
               ProcessManager.WriteSByte(value, MemoryAddress + PositionOffsets.NewWingBackRight);
           }
       }

   }
}
