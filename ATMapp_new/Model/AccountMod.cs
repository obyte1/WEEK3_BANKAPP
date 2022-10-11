using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankAppWeek3.Models
{
    public class AccountMod
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string AccountName
        {
            get { return FirstName + ", " + LastName; }
        }

        public string Email { get; set; }

        public string password { get; set; } 

        public string AccountNumber { get; set; }

        public string AccountType { get; set; }

        public decimal? Balance { get; set; } 

        public List<TransactionMod> TransactionList { get; set; }
    }
}
