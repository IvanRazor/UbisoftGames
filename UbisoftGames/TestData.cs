using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UbisoftGames.Data;

namespace UbisoftGames
{
    public static class TestData
    {
        public static void AddTestData(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<GameContext>();

                var testGame1 = new Models.Game
                {
                    Name = "Assassin's Creed Odyssey",
                    Image = "/images/ac_franchise-odyssey.jpg",
                    Description = @"Write your own epic odyssey and become a legendary Spartan hero in Assassin's Creed® Odyssey, an inspiring adventure where you must forge your destiny and define your own path in a world on the brink of tearing itself apart. Influence how history unfolds as you experience a rich and ever-changing world shaped by your decisions.",
                    IsReleased = true
                };
                context.Games.Add(testGame1);

                context.Games.Add(new Models.Game
                {
                    Name = "For Honor",
                    Image = "/images/fh_fire-promo_thumb_fh_marchfire.jpg",
                    Description = @"After a great cataclysm, 3 of the fiercest warrior factions in history clash in an epic battle for survival. Join the war as a bold Knight, brutal Viking, or deadly Samurai and fight for your faction’s honor. Carve a path of destruction across the battlefield in this fast-paced thriller that mixes skill with visceral melee combat.
Since its launch in February 2017, the game has undergone continual updates and improvements. The addition of dedicated servers have provided a stable and seamless experience for players and new training modes have given players the tools to go from Apprentice to Master while earning rewards. Take your new found skills to brand new modes and customize your heroes with thousands of gear items added since launch.",
                    IsReleased = true
                });

                context.Games.Add(new Models.Game
                {
                    Name = "The Settlers",
                    Image = "/images/settlers_logo-thumb-750x422_331700.jpg",
                    Description = @"The Settlers is a video game series. The first game in the series is The Settlers (1993). There are eight games in the series, including remakes. All the games were developed by the German studio Blue Byte, and were published by either Blue Byte or Ubisoft, the company that later acquired Blue Byte. The tablet version of the game is developed by Gameloft.",
                    IsReleased = true
                });

                context.Games.Add(new Models.Game
                {
                    Name = "ANNO 1800",
                    Image = "/images/1anno-100-thumbnail-750x422_mobile_297543.jpg",
                    Description = @"Anno 1800 is a city building real-time strategy video game, developed by Blue Byte and published by Ubisoft, and is set to be launched within April 2019. It is the seventh game in the Anno series, and returns to the use of a historical setting following the last two titles, Anno 2070 and Anno 2205, taking place during the Industrial Revolution in the 19th century. Following the previous installment, the game returns to the series' traditional city-building and ocean combat mechanics, but introduces new aspects of gameplay, such as tourism, 'blue - printing', and the effects of industrialisation influences on island inhabitants.",
                    IsReleased = true
                });

                context.Games.Add(new Models.Game
                {
                    Name = "Tom Clancy's The Division 2",
                    Image = "/images/division2-ubicomgamepage-search_thumbnail-750x422_mobile_328763.jpg",
                    Description = @"om Clancy’s The Division is a revolutionary experience that combines robust RPG customization with tactical action combat. There’s never been a better time to jump in and join the fight to save NYC.",
                    IsReleased = true
                });

                context.Games.Add(new Models.Game
                {
                    Name = "Far Cry 5",
                    Image = "/images/fc5-wideart-table-search_thumnail_290060.jpg",
                    Description = @"With the announcement of Far Cry New Dawn, it's clear that things did not turn out well for Hope County, Montana in Far Cry 5. How did it all go so apocalyptically wrong? How did the Project at Eden's Gate cult gain a stranglehold on the people and places of Hope County? What did the local resistance do to push them back? And why was Joseph Seed—the manipulative and murderous cult leader known as The Father—able to command such a powerful following?",
                    IsReleased = true
                });

                context.Games.Add(new Models.Game
                {
                    Name = "Just Dance 2019",
                    Image = "/images/jd19-ubicom_search_thumbnail-750x422_325114.jpg",
                    Description = @"Just Dance 2019 is a dance rhythm game developed by Ubisoft. It was unveiled on June 11, 2018, during its E3 press conference, and was released on October 23, 2018 on Nintendo Switch, Wii, Wii U, PlayStation 4, Xbox One and Xbox 360 in North America. It was also released on October 26, 2018 in Europe and Australia.",
                    IsReleased = true
                });

                context.Games.Add(new Models.Game
                {
                    Name = "Watch Dogs 2",
                    Image = "/images/wd2_free-search-thumbnail-ncsa_mobile_285807.jpg",
                    Description = @"Watch Dogs 2 (stylized as WATCH_DOGS 2) is an action-adventure video game developed by Ubisoft Montreal and published by Ubisoft. It is the sequel to 2014's Watch Dogs and was released worldwide for PlayStation 4, Xbox One and Microsoft Windows in November 2016. Set within a fictionalized version of the San Francisco Bay Area, the game is played from a third-person perspective and its open world is navigated on-foot or by vehicle.",
                    IsReleased = true
                });

                context.Games.Add(new Models.Game
                {
                    Name = "The Crew",
                    Image = "/images/thecrew_logo-game_search-thumbnail_166219.jpg",
                    Description = @"The Crew received a mixed reception upon release. Critics praised the game's world design but criticized the always-online aspect, which created technical glitches and other issues, the difficult-to-understand user interface, and the presence of microtransactions. The game shipped two million copies by January 1, 2015. It received an expansion, titled The Crew: Wild Run, which was released on November 17, 2015. Another expansion, entitled The Crew: Calling All Units, was announced at Gamescom 2016 and released on November 29, 2016. A sequel, The Crew 2, was released worldwide on June 29, 2018.",
                    IsReleased = true
                });

                context.Games.Add(new Models.Game
                {
                    Name = "Prince of Persia The Forgotten Sands",
                    Image = "/images/poptfs_searchthumbnail_mobile_158098.jpg",
                    Description = @"Prince of Persia: The Forgotten Sands is a multi-platform video game produced by Ubisoft, which was released on May 18, 2010, in North America and on May 20 in Europe. The games mark a return to the storyline started by Prince of Persia: The Sands of Time. Prince of Persia: The Forgotten Sands is the title of four separate games with different storylines. The main game was developed for PlayStation 3, Xbox 360, and Microsoft Windows, while the other three are for the PlayStation Portable, Nintendo DS, and Wii.",
                    IsReleased = true
                });

                context.SaveChanges();
            }
        }
    }
}
