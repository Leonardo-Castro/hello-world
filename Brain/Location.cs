using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
   public class Location
   {
      public int ID { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
      public Location LocationToNorth { get; set; }
      public Location LocationToRight { get; set; }
      public Location LocationToSouth { get; set; }
      public Location LocationToLeft { get; set; }

      public Location(int id, string name, string description)
      {
         ID = id;
         Name = name;
         Description = description;         
      }
   }
}
