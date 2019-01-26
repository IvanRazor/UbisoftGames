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
                    Id = 1,
                    Name = "Assassin's Creed Odyssey",
                    Image = "/images/ac_franchise-odyssey.jpg",
                    Description = @"Write your own epic odyssey and become a legendary Spartan hero in Assassin's Creed® Odyssey, an inspiring adventure where you must forge your destiny and define your own path in a world on the brink of tearing itself apart. Influence how history unfolds as you experience a rich and ever-changing world shaped by your decisions.",
                    IsReleased = true
                };
                context.Games.Add(testGame1);

                context.Games.Add(new Models.Game
                {
                    Id = 2,
                    Name = "For Honor",
                    Image = "/images/fh_fire-promo_thumb_fh_marchfire.jpg",
                    Description = @"After a great cataclysm, 3 of the fiercest warrior factions in history clash in an epic battle for survival. Join the war as a bold Knight, brutal Viking, or deadly Samurai and fight for your faction’s honor. Carve a path of destruction across the battlefield in this fast-paced thriller that mixes skill with visceral melee combat.
Since its launch in February 2017, the game has undergone continual updates and improvements. The addition of dedicated servers have provided a stable and seamless experience for players and new training modes have given players the tools to go from Apprentice to Master while earning rewards. Take your new found skills to brand new modes and customize your heroes with thousands of gear items added since launch.",
                    IsReleased = true
                });

                context.Games.Add(new Models.Game
                {
                    Id = 3,
                    Name = "Tom Clancy's The Division 2",
                    Image = "/images/division2-ubicomgamepage-search_thumbnail-750x422_mobile_328763.jpg",
                    Description = @"om Clancy’s The Division is a revolutionary experience that combines robust RPG customization with tactical action combat. There’s never been a better time to jump in and join the fight to save NYC.",
                    IsReleased = true
                });

                context.Games.Add(new Models.Game
                {
                    Id = 4,
                    Name = "Far Cry 5",
                    Image = "/images/fc5-wideart-table-search_thumnail_290060.jpg",
                    Description = @"With the announcement of Far Cry New Dawn, it's clear that things did not turn out well for Hope County, Montana in Far Cry 5. How did it all go so apocalyptically wrong? How did the Project at Eden's Gate cult gain a stranglehold on the people and places of Hope County? What did the local resistance do to push them back? And why was Joseph Seed—the manipulative and murderous cult leader known as The Father—able to command such a powerful following?",
                    IsReleased = true
                });

                context.Games.Add(new Models.Game
                {
                    Id = 5,
                    Name = "Just Dance 2019",
                    Image = "/images/",
                    Description = @"",
                    IsReleased = true
                });

                context.Games.Add(new Models.Game
                {
                    Id = 6,
                    Name = "Watch Dogs 2",
                    Image = "/images/",
                    Description = @"",
                    IsReleased = true
                });

                context.Games.Add(new Models.Game
                {
                    Id = 7,
                    Name = "The Crew",
                    Image = "/images/",
                    Description = @"",
                    IsReleased = true
                });

                context.Games.Add(new Models.Game
                {
                    Id = 8,
                    Name = "Prince of Persia The Forgotten Sands",
                    Image = "/images/",
                    Description = @"",
                    IsReleased = true
                });

                context.SaveChanges();
            }
        }
    }
}
