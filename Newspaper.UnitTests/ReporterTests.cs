using System.Net;
using Newspaper.Models;

namespace Newspaper.UnitTests
{
    public class ReporterTests
    {
        [Fact]
        public void Reporter_CanSetProperties()
        {
            Reporter reporter = new Reporter()
            {
                Name = "Lois Lane",
                Specialty = "Politics"
            };

            Assert.Equal("Lois Lane", reporter.Name);
            Assert.Equal("Politics", reporter.Specialty);
            Assert.Equal(new List<Article>(), reporter.Articles);
        }
    }
}