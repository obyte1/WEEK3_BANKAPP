using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppWeek3.Models
{
    public class TransactionMod
    {
        public string AccountNumber { get; set; }

        public string TransactionId { get; set; }

        public DateTime? DateTime { get; set; }

        public string Description { get; set; }

        public decimal? outAmount { get; set; }

        public decimal? Balance { get; set; }
    }
}
