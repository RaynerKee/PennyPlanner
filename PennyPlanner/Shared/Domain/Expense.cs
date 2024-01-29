using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyPlanner.Shared.Domain
{
    public class Expense
    {
        public int ExpenseID { get; set; }
        public int UserID { get; set; }
        public required string Description { get; set; }
        public required string Category { get; set; }
        public required decimal Amount { get; set; }
        public required DateTime DateTime { get; set; }

        public required User User { get; set; }
    }
}
