using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using MyScriptureJournal.Data;

namespace MyScriptureJournal.Pages.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "1 Nephi",
                        Chapter = "3",
                        Verse = "4",
                        Notes = "We should have the same 'go and do' attitude as Nephi.",
                        DateCreated = DateTime.Parse("2021-2-28")
                    },

                    new Scripture
                    {
                        Book = "Moroni",
                        Chapter = "10",
                        Verse = "4-5",
                        Notes = "If we ask with a sincere heart, we can know the truth.",
                        DateCreated = DateTime.Parse("2020-5-5")
                    },

                    new Scripture
                    {
                        Book = "2 Nephi",
                        Chapter = "25",
                        Verse = "23",
                        Notes = "We must do everything we can in order to be saved",
                        DateCreated = DateTime.Parse("2015-7-10")
                    },

                    new Scripture
                    {
                        Book = "Ether",
                        Chapter = "12",
                        Verse = "6",
                        Notes = "We must first have a trial of faith before we know anything.",
                        DateCreated = DateTime.Parse("2012-9-8")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
