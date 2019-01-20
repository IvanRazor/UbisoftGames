using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UbisoftGames.Data;


namespace UbisoftGames
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<GameContext>(opt => opt.UseInMemoryDatabase("Games"));
            
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //var context = app.ApplicationServices.GetService<GameContext>();
            AddTestData(app);

            app.UseMvc(
            routes =>
            {
                routes.MapRoute("default", "{controller=Games}/{action=Index}/{id?}");
            });

            /*app.Run(async (context) =>
            {
                await context.Response.WriteAsync("MVC didn't find current route");
            });*/
        }



        private static void AddTestData(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<GameContext>();

                var testGame1 = new Models.Game
                {
                    Id = 1,
                    Name = "Assassin's Creed Odyssey",
                    Image = "",
                    Description = "",
                    IsReleased = true
                };
                context.Games.Add(testGame1);

                context.Games.Add(new Models.Game
                {
                    Id = 2,
                    Name = "For Honor",
                    Image = "",
                    Description = "",
                    IsReleased = true
                });

                context.Games.Add(new Models.Game
                {
                    Id = 3,
                    Name = "Tom Clancy's The Division 2",
                    Image = "",
                    Description = "",
                    IsReleased = true
                });

                context.Games.Add(new Models.Game
                {
                    Id = 4,
                    Name = "Far Cry 5",
                    Image = "",
                    Description = "",
                    IsReleased = true
                });

                context.Games.Add(new Models.Game
                {
                    Id = 5,
                    Name = "Just Dance 2019",
                    Image = "",
                    Description = "",
                    IsReleased = true
                });

                context.Games.Add(new Models.Game
                {
                    Id = 6,
                    Name = "Watch Dogs 2",
                    Image = "",
                    Description = "",
                    IsReleased = true
                });

                context.Games.Add(new Models.Game
                {
                    Id = 7,
                    Name = "The Crew",
                    Image = "",
                    Description = "",
                    IsReleased = true
                });

                context.Games.Add(new Models.Game
                {
                    Id = 8,
                    Name = "Prince of Persia The Forgotten Sands",
                    Image = "",
                    Description = "",
                    IsReleased = true
                });

                context.SaveChanges();
            }

            
        }


    }
}
