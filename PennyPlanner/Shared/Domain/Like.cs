using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyPlanner.Shared.Domain
{
    public class Like
    {
        public int LikeID { get; set; }
        public int UserID { get; set; }
        public int ArticleID { get; set; }
        public DateTime DateTime { get; set; }

        public required User User { get; set; }
        public required Article Article { get; set; }
    }
}
