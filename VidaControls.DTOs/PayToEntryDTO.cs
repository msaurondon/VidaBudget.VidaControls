using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidaControls.DTOs
{
    public class PayToEntryDTO
    {
        public int PayeeID { get; set; }
        public string ToName { get; set; }
        public int DateOfMonthDue { get; set; }
        public decimal APR { get; set; }
        public decimal TotalOwed { get; set; }
        public decimal MinimumPayment { get; set; }
        public int DebtType { get; set; }
        public bool Suppressed { get; set; }
    }
}
