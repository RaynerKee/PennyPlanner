using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyPlanner.Shared.Domain
{
    public class Savings
    {
        public int SavingsID { get; set; }
        public int UserID { get; set; }
        public required string Month { get; set; }
        public decimal SavingsAmount { get; set; }

        public required User User { get; set; }
    }
}
