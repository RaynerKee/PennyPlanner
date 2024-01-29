using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyPlanner.Shared.Domain {
    public class Article
    {
        public int ArticleID { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public int AuthorID { get; set; }
        public DateTime DateTime { get; set; }

        public required User Author { get; set; }
        public List<Like>? Likes { get; set; }
    }

}
