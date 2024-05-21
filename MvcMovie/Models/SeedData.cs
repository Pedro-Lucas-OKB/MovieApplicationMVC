using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<MvcMovieContext>>()))
        {
            if (context.Movie.Any())
            {
                return;
            }

            context.Movie.AddRange(
                new Movie {
                    Title = "Forrest Gump",
                    ReleaseDate = DateTime.Parse("1994-12-07"),
                    Genre = "Drama",
                    Price = 5.99m
                },

                new Movie {
                    Title = "Inglourious Basterds",
                    ReleaseDate = DateTime.Parse("2009-08-21"),
                    Genre = "Drama, Action",
                    Price = 7.99m
                },

                new Movie {
                    Title = "Captain America: The Winter Soldier",
                    ReleaseDate = DateTime.Parse("2014-03-13"),
                    Genre = "Action",
                    Price = 9.99m
                }
            );

            context.SaveChanges();
        }
    }
}
