using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newspaper.UnitTests
{
    public class ArticleTests
    {
        [Fact]
        public void Article_CanSetProperties()
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

            Assert.Equal("The Superman is Real, and He's American!", article.Title);
            Assert.Equal("a bunch of words", article.Content);
            Assert.Equal(reporter, article.Reporter);
            Assert.Equal(issue, article.Issue);
        }
    }
}
