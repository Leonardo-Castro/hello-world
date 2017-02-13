using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain
{
   public class World
   {
      public static readonly List<Location> Locations = new List<Location>();     

      //All of the rooms in the Video game Museum

      //Main Locations
      public const int LOCATION_ID_LOBBY = 1;
      public const int LOCATION_ID_CLASSIC_HUB = 2;      
      public const int LOCATION_ID_MODERN_HUB = 3;

      //Nintendo Locations
      public const int LOCATION_ID_NINTENDO_HUB = 4;
      public const int LOCATION_ID_SNES_HUB = 5;
      public const int LOCATION_ID_WIIU_HUB = 6;
      public const int LOCATION_ID_SUPER_MARIO_WORLD = 7;
      public const int LOCATION_ID_SPLATOON = 8;

      //Sega Locations
      public const int LOCATION_ID_SEGA_HUB = 9;
      public const int LOCATION_ID_GENESIS_HUB = 10;
      public const int LOCATION_ID_SONIC_THE_HEDGEHOG = 10;
      public const int LOCATION_ID_DREAMCAST_HUB = 11;
      public const int LOCATION_ID_SHENMUE = 12;

      //Microsoft Locations
      public const int LOCATION_ID_MICROSOFT_HUB = 13;
      public const int LOCATION_ID_XBOX_360_HUB = 14;
      public const int LOCATION_ID_HALO3 = 15;
      public const int LOCATION_ID_XBOX_ONE_HUB = 16;
      public const int LOCATION_ID_SUNSET_OVERDRIVE = 17;

      //Sony Locations
      public const int LOCATION_ID_SONY_HUB = 18;
      public const int LOCATION_ID_PS3_HUB = 19;
      public const int LOCATION_ID_DEMONS_SOULS= 20;
      public const int LOCATION_ID_PS4_HUB = 21;
      public const int LOCATION_ID_UNTIL_DAWN = 22;


      static World()
      {         
         PopulateLocations();
      }    

      //These are the Main Hub Locaions and the Lobby starting area
      private static void PopulateLocations()
      {
         Location lobby = new Location(LOCATION_ID_LOBBY, "\n                                        Lobby", "\nWelcome to the Museum of Video Games! As you walk these hubs, you can explore and learn about the various companies, consoles, and video games that have come around over the years. Hope you enjoy your time here!\n\n                            North for Classic Hub");

         Location classicHub = new Location(LOCATION_ID_CLASSIC_HUB, "\n                                  Classic Hub", "\nWelcome to the Classic Hub! From this Hub you can access Nintendo Consoles and Games to the left. You can also access Sega consoles and games to the right.\n\n              North for Modern Hub,  Left for Nintendo,  Right for Sega");

         Location modernHub = new Location(LOCATION_ID_MODERN_HUB, "\n                                      Modern Hub", "\nWelcome to the Modern Hub! From this Hub you can access Microsoft consoles and games to the left. You can also access Sony consoles and games to the right.\n\n                     Left for Microsft,  Right for Sony");

         //Nintendo
         Location nintendoHub = new Location(LOCATION_ID_NINTENDO_HUB, "\n                                   Nintendo Hub", "\nWelcome to the Nintendo Hub! From this Hub you can access Nintendo consoles and games to the left. Nintendo was founded in 1889 by Fusajiro Yamauchi. The company actually started out making playing cards. It wasn't until the 1970's that they got into the video game market.\n\n                               Left for SNES Hub");

         Location snesHub = new Location(LOCATION_ID_SNES_HUB, "\n       Super Nintendo Entertainment System Hub(SNES)", "\nWelcome to the Super Nintendo Entertainment System Hub! You can access SNES games to the South. The SNES was released in 1990 and was the second major console release by Nintendo.\n\n             Left for WiiU, South for Super Mario World");

         Location superMarioWorld = new Location(LOCATION_ID_SUPER_MARIO_WORLD, "\n                          Super Mario World Room", "\nWelcome to the Super Mario World Room! Super Mario World was relesed in 1990 along side the SNES. To this day it remains one of the most influential platform games in history.\n\n                                     North for SNES Hub");

         Location wiiuHub = new Location(LOCATION_ID_WIIU_HUB, "\n                                      Wii U Hub", "\nWelcome to the Wii U Hub! You can access Wii U  games to the South. The Wii U was released in 2012 and is the most recent console release by Nintendo.\n\n              South for Splatoon,  Right for SNES Hub");

         Location splatoon = new Location(LOCATION_ID_SPLATOON, "\n                                      Splatoon", "\nWelcome to the Splatoon Room! Splatoon was released just earlier this year in 2015 and has since gone on to become a smash hit.\n\n                              North for Wii U Hub");

         //Sega
         Location segaHub = new Location(LOCATION_ID_SEGA_HUB, "\n                                                Sega Hub", "\nWelcome to the Sega Hub! From this Hub you can access Sega consoles and games to the right. Sega was founded in 1940 and initially only imported slot machines.\n\n                      Right for Genesis Hub");

         Location genesisHub = new Location(LOCATION_ID_GENESIS_HUB, "\n                                                Genesis Hub", "\nWelcome to the Genesis Hub! From this Hub you can access Sonic the Hedgehog to the south. The Genesis was released in 1988 and was the first 16 bit home console to be released.\n\n                      South for Sonic the Hedgehog,  Right for Dreamcast");

         Location sonicTheHedgehog = new Location(LOCATION_ID_SONIC_THE_HEDGEHOG, "\n                                                Sonic the Hedgehog", "\nWelcome to the Sonic the hedgehog Room! Sonic the Hedgehog was released in 1991 and Sonic went on to become the mascot for the Sega Genesis.\n\n                      North for Genesis Hub");

         Location dreamcastHub = new Location(LOCATION_ID_DREAMCAST_HUB, "\n                                                Dreamcast Hub", "\nWelcome to the Dreamcast Hub! The Dreamcast was released in 1998 and was the final console released by Sega.\n\n                      Left for Genesis Hub, South for Shenmue");

         Location shenmue = new Location(LOCATION_ID_SHENMUE, "\n                                                Shenmue", "\nWelcome to the Shenmue Room! Shenmue was released in 1999 and went on to spawn a sequel, also on the Dreamcast.\n\n                      North for Dreamcast Hub");

         //Microsoft Locations
         Location microsoftHub = new Location(LOCATION_ID_MICROSOFT_HUB, "\n                                                Microsoft Hub", "\nWelcome to the Microsoft Hub! From this Hub you can access Microsoft consoles and games to the Left. Microsoft was founded in 1975 by Bill gates and Paul Allen.\n\n               Left for XBOX 360 Hub,  Right for Modern hub");

         Location xbox360Hub = new Location(LOCATION_ID_XBOX_360_HUB, "\n                                                XBOX 360 Hub", "\nWelcome to the XBOX 360 Hub! From this Hub you can access Halo 3 to the South. The XBOX 360 was released in 2005 and was an improvement in every way over the original XBOX.\n\n           South for Halo 3,  Left for XBOX One Hub");

         Location halo3 = new Location(LOCATION_ID_HALO3, "\n                                                Halo 3", "\nWelcome to the Halo 3 Room! Halo 3 was released in 2007 and it's main character, Master Chief, went on to become the mascot for the XBOX 360.\n\n                      North for XBOX 360 Hub");

         Location xboxOneHub = new Location(LOCATION_ID_XBOX_ONE_HUB, "\n                                                XBOX One Hub", "\nWelcome to the XBOX One Hub! The XBOX One was released in 2013 and is the most current Microsoft console to be released.\n\n    Right for XBOX 360 Hub,  South for Sunset Overdrive");

         Location sunsetOverdrive = new Location(LOCATION_ID_SUNSET_OVERDRIVE, "\n                                                Sunset Overdrive", "\nWelcome to the Sunset Overdrive Room! Sunset Overdrive was released in 2014.\n\n                      North for XBOX One Hub");

         //Sony Locations
         Location sonyHub = new Location(LOCATION_ID_SONY_HUB, "\n                                                Sony Hub", "\nWelcome to the Sony Hub! From this Hub you can access Sony consoles and games to the Right. Sony was founded in 1946 by Masaru Ibuka and Akio Morita.\n\n               Left for Modern Hub,  Right for PS3 Hub");

         Location ps3Hub = new Location(LOCATION_ID_PS3_HUB, "\n                                                Playstation 3 Hub(PS3)", "\nWelcome to the PS3 Hub! From this Hub you can access Demons Souls to the South. The PS3 was released in 2006 and was an improvement in every way over the previous console, the PS2.\n\n           South for Demons Souls,  Right for PS4 Hub");

         Location demonsSouls = new Location(LOCATION_ID_DEMONS_SOULS, "\n                                                Demons Souls", "\nWelcome to the Demons Souls Room! Demons Souls is an action/RPG and was released in 2009. It went on to spawn 2 sequels, with a third slated for a 2016 release.\n\n                      North for PS3 Hub");

         Location ps4Hub = new Location(LOCATION_ID_PS4_HUB, "\n                                                PS4 Hub", "\nWelcome to the PS4 Hub! The PS4 was released in 2013 and is the most current Sony console to be released.\n\n      Left for PS3 Hub,  South for Until Dawn");

         Location untilDawn = new Location(LOCATION_ID_UNTIL_DAWN, "\n                                                Until Dawn", "\nWelcome to the Until Dawn Room! Until Dawn was released in 2015 and is more of an interactive horror story than a traditional gameplay release.\n\n                      North for PS4 Hub");

                 
         //Navigation

         //Spawn Point
         lobby.LocationToNorth = classicHub;

         //Main hub
         classicHub.LocationToNorth = modernHub;
         classicHub.LocationToSouth = lobby;
         classicHub.LocationToRight = segaHub;
         classicHub.LocationToLeft = nintendoHub;

         //Nintendo Navigation
         nintendoHub.LocationToRight = classicHub;
         nintendoHub.LocationToLeft = snesHub;

         snesHub.LocationToRight = nintendoHub;
         snesHub.LocationToSouth = superMarioWorld;
         snesHub.LocationToLeft = wiiuHub;

         superMarioWorld.LocationToNorth = snesHub;         
         
         wiiuHub.LocationToRight = snesHub;
         wiiuHub.LocationToSouth = splatoon;

         splatoon.LocationToNorth = wiiuHub;

         //Sega Navigation
         segaHub.LocationToRight = genesisHub;
         segaHub.LocationToLeft = classicHub;

         genesisHub.LocationToRight = dreamcastHub;
         genesisHub.LocationToSouth = sonicTheHedgehog;
         genesisHub.LocationToLeft = segaHub;

         sonicTheHedgehog.LocationToNorth = genesisHub;

         dreamcastHub.LocationToLeft = genesisHub;
         dreamcastHub.LocationToSouth = shenmue;

         shenmue.LocationToNorth = dreamcastHub;

         //Secondary Hub
         modernHub.LocationToSouth = classicHub;
         modernHub.LocationToLeft = microsoftHub;
         modernHub.LocationToRight = sonyHub;

         //Microsoft Navigation
         microsoftHub.LocationToLeft = xbox360Hub;
         microsoftHub.LocationToRight = modernHub;

         xbox360Hub.LocationToSouth = halo3;
         xbox360Hub.LocationToLeft = xboxOneHub;
         xbox360Hub.LocationToRight = microsoftHub;

         halo3.LocationToNorth = xbox360Hub;

         xboxOneHub.LocationToRight = xbox360Hub;
         xboxOneHub.LocationToSouth = sunsetOverdrive;

         sunsetOverdrive.LocationToNorth = xboxOneHub;

         //Sony Navigation
         sonyHub.LocationToLeft = modernHub;
         sonyHub.LocationToRight = ps3Hub;

         ps3Hub.LocationToSouth = demonsSouls;
         ps3Hub.LocationToLeft = sonyHub;
         ps3Hub.LocationToRight = ps4Hub;

         demonsSouls.LocationToNorth = ps3Hub;

         ps4Hub.LocationToLeft = ps3Hub;
         ps4Hub.LocationToSouth = untilDawn;

         untilDawn.LocationToNorth = ps4Hub;

         //Locations

         //Main Locations
         Locations.Add(lobby);
         Locations.Add(classicHub);
         Locations.Add(modernHub);

         //Nintendo Locations
         Locations.Add(nintendoHub);
         Locations.Add(snesHub);
         Locations.Add(superMarioWorld);
         Locations.Add(wiiuHub);
         Locations.Add(splatoon);

         //Sega Locations
         Locations.Add(segaHub);
         Locations.Add(genesisHub);
         Locations.Add(sonicTheHedgehog);
         Locations.Add(dreamcastHub);
         Locations.Add(shenmue);

         //Microsoft Locations
         Locations.Add(microsoftHub);
         Locations.Add(xbox360Hub);
         Locations.Add(halo3);
         Locations.Add(xboxOneHub);
         Locations.Add(sunsetOverdrive);

         //Sony Locations
         Locations.Add(sonyHub);
         Locations.Add(ps3Hub);
         Locations.Add(demonsSouls);
         Locations.Add(ps4Hub);
         Locations.Add(untilDawn);       
         
      }      

      public static Location LocationByID(int id)
      {
         foreach (Location location in Locations)
         {
            if (location.ID == id)
            {
               return location;
            }
         }

         return null;
      }
   }
}