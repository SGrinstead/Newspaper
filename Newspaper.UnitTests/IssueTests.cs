using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newspaper.Models;

namespace Newspaper.UnitTests
{
    public class IssueTests
    {
        [Fact]
        public void Issue_CanSetProperties()
        {
            Issue issue = new Issue()
            {
                Date = DateTime.UtcNow
            };
            Assert.Equal(DateTime.UtcNow.ToShortDateString()
                , issue.Date.ToShortDateString());
            Assert.Equal(new List<Article>(), issue.Articles);
        }

        [Fact]
        public void Issue_ArticleCount_ReturnsCountOfArticles()
        {
            Reporter reporter = new Reporter()
            {
                Name = "Lois Lane",
                Specialty = "Politics"
            };
            Issue issue = new Issue()
            {
                Date = DateTime.UtcNow
            };
            Article article = new Article()
            {
                Title = "The Superman is Real, and He's American!",
                Content = "a bunch of words",
                Reporter = reporter,
                Issue = issue
            };

            issue.Articles.Add(article);
            issue.Articles.Add(article);
            issue.Articles.Add(article);

            Assert.Equal(3, issue.ArticleCount());
        }

        [Fact]
        public void Issue_ReporterCount_ReturnsCountOfUniqueReporters()
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

            Assert.Equal(2, issue.ReporterCount());
        }

        [Fact]
        public void Issue_ReporterNames_ReturnsListOfUniqueReporterNames()
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

            List<string> expected = new List<string>() { "Lois Lane", "Mr. Sportsball" };
            Assert.Equal(expected, issue.ReporterNames());
        }
    }
}
