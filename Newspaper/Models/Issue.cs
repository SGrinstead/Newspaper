using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newspaper.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<Article> Articles { get; set; } = new();

        public int ArticleCount()
        {
            return Articles.Count();
        }

        public int ReporterCount()
        {
            var reporters = Articles.Select(article => article.Reporter);
            return reporters.Distinct().Count();
        }

        public List<string> ReporterNames()
        {
            var names = Articles.Select(article => article.Reporter.Name);
            return names.Distinct().ToList();
        }
    }
}
