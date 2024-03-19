using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ice_TASK_ONE.Data;
using System;
using System.Linq;

namespace Ice_TASK_ONE.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new Ice_TASK_ONEContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<Ice_TASK_ONEContext>>()))
        {
            // Look for any movies.
            if (context.Game.Any())
            {
                return;   // DB has been seeded
            }
            context.Game.AddRange(
                new Game
                {
                    Title = "GTA V ",
                    ReleaseDate = DateTime.Parse("2013-6-14"),
                    Genre = "Open World",
                    Price = 8.99M , 
                    Publisher="Rock Star Studios"
                },
                new Game
                {
                    Title = "SONIC",
                    ReleaseDate = DateTime.Parse("2000-5-19"),
                    Genre = "Fantsy",
                    Price = 1.99M ,
                    Publisher = "CAPCOM"
                },
                new Game
                {
                    Title = "Mega MAN",
                    ReleaseDate = DateTime.Parse("1998-8-23"),
                    Genre = "Fantsy",
                    Price = 9.99M ,
                    Publisher = "CAPCOM"
                },
                new Game
                {
                    Title = "Evolve",
                    ReleaseDate = DateTime.Parse("2018-8-15"),
                    Genre = "RPG",
                    Price = 3.99M ,
                    Publisher = "Turtle Rock Studios"
                },
                 new Game
                 {
                     Title = "Genshin Impact",
                     ReleaseDate = DateTime.Parse("2020-6-19"),
                     Genre = "Open World",
                     Price = 5.99M,
                     Publisher = "HOYO VERSE Studios"
                 },
                  new Game
                  {
                      Title = "Mobile Legends",
                      ReleaseDate = DateTime.Parse("2015-7-22"),
                      Genre = "RPG",
                      Price = 3.99M,
                      Publisher = "MOONTON Studios"
                  }
            );
            context.SaveChanges();
        }
    }
}

