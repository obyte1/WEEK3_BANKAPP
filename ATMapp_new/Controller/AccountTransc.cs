using BankAppWeek3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMapp_new.Controller
{
    public class AccountTransc
    {
        public readonly AccountMod accUpdate = new AccountMod();

        public AccountTransc(string firstname, string lastname, string email, string type, decimal? balance, string password)
        {
            accUpdate.password = password;
            accUpdate.FirstName = firstname;
            accUpdate.LastName = lastname;
            accUpdate.Email = email;
            accUpdate.AccountType = type;
            accUpdate.Balance = balance;
            accUpdate.AccountNumber = numberCreator(8);
            accUpdate.TransactionList = new List<TransactionMod>();

        }// new AccountTransc(account)

        public void AddTransaction(decimal? OutAmt, string description)
        {
            TransactionMod Trans = new TransactionMod();
            {
                Trans.Description = description;
                Trans.AccountNumber = accUpdate.AccountNumber;
                Trans.Balance = accUpdate.Balance;
                Trans.outAmount = OutAmt;
                Trans.DateTime = DateTime.Now;
                Trans.TransactionId = accUpdate.AccountNumber + accUpdate.FirstName;
            };
            if (Trans != null)
            {
                accUpdate.TransactionList.Add(Trans);
            }
        }

        private static string numberCreator(int num)
        {
            var number = new Random();
            string str = string.Empty;
            for (int i = 0; i < num; i++)
                str = String.Concat(str, number.Next(8).ToString());
            return "20" + str;

        }
    }
}
