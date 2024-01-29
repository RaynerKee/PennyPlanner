using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PennyPlanner.Shared.Domain
{
    public class User
    {
        public int UserID { get; set; }
        public decimal? MonthlyIncome { get; set; }

        public  List<Expense>? Expenses { get; set; }
        public List<Savings>? Savings { get; set; }
        public List<Article>? Articles { get; set; }
        public List<Like>? Likes { get; set; }
    }
}
