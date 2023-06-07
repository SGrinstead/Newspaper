using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
