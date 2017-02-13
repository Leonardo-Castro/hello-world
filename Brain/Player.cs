using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
   public class Player
   {
      public int Credits { get; set; }
      public int XP { get; set; }
      public int Level { get; set; }
      public Location CurrentLocation { get; set; }

      public Player(int currentHealth, int maximumHealth, int credits, int xp, int level)         
      {
         Credits = credits;
         XP = xp;
         Level = level;       
      }      
   }
}