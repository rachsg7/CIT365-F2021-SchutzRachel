using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "God's Army",
                        ReleaseDate = DateTime.Parse("2000-03-10"),
                        Genre = "Drama",
                        Price = 7.99M,
                        Rating = "PG",
                        Image = "/images/godsarmy.jpg"
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven ",
                        ReleaseDate = DateTime.Parse("2001-12-14"),
                        Genre = "Drama",
                        Price = 9.99M,
                        Rating = "PG",
                        Image = "/images/theothersideofheaven.jpg"
                    },

                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2003-02-14"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "PG",
                        Image = "/images/thebesttwoyears.jpg"
                    },

                    new Movie
                    {
                        Title = "Saints and Soliders",
                        ReleaseDate = DateTime.Parse("2003-11-12"),
                        Genre = "Drama",
                        Price = 9.99M,
                        Rating = "PG-13",
                        Image = "/images/saintsandsoldiers.jpg"
                    },

                    new Movie
                    {
                        Title = "The Saratov Approach",
                        ReleaseDate = DateTime.Parse("2013-10-09"),
                        Genre = "Action",
                        Price = 8.99M,
                        Rating = "PG-13",
                        Image = "/images/thesaratovapproach.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}