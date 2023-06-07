using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newspaper.Models;

namespace Newspaper.Data
{
    public class DataSeeder
    {
        public static void SeedData(NewspaperContext context)
        {
            if (!context.Issues.Any())
            {
                Issue issue = new Issue()
                {
                    Date = DateTime.UtcNow
                };
                Reporter lois = new Reporter()
                {
                    Name = "Lois Lane",
                    Specialty = "Politics"
                };
                Reporter sport = new Reporter()
                {
                    Name = "Mr. Sportsball",
                    Specialty = "Sports"
                };
                Article article1 = new Article()
                {
                    Title = "The Superman is Real, and He's American!",
                    Content = "a bunch of words",
                    Reporter = lois,
                    Issue = issue
                };
                Article article2 = new Article()
                {
                    Title = "Home Team Wins Game",
                    Content = "they won.",
                    Reporter = sport,
                    Issue = issue
                };
                Article article3 = new Article()
                {
                    Title = "Home Team Loses Game",
                    Content = "they lost.",
                    Reporter = sport,
                    Issue = issue
                };

                issue.Articles.Add(article1);
                issue.Articles.Add(article2);
                issue.Articles.Add(article3);

                context.Issues.Add(issue);
                context.SaveChanges();
            }
        }
    }
}
