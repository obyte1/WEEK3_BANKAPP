using ATMapp_new.Controller;
using BankAppWeek3.ErrorChecker;
using BankAppWeek3.Models;
using BankAppWeek3.TablePrinter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppWeek3.TransactionCodes
{
    public class TransactionsActions:CreateAccount
    {
        public static AccountMod DisplayMoney(string type, string mail, string pass)
        {
            Console.WriteLine("How much Do you wish To Deposit");

            string amount11 = Console.ReadLine();
            string amount1 = ErrorValidators.Amount_AccNumCheck(amount11, "Invalid, Amount Can only Be Positive Numbers");

            decimal? amount = Math.Abs(Convert.ToDecimal(amount1));

         

            foreach(var s in Customer)
            {
                if(s.accUpdate.AccountType == type && s.accUpdate.Email == mail && s.accUpdate.password == pass)
                {
                    s.accUpdate.Balance += amount;

                    s.AddTransaction(amount, $"Money Deposited");

                    Console.WriteLine($"Successfully Deposited {amount}, Your Balance is {s.accUpdate.Balance}");
                }
            }
            ErrorValidators.Back(type, mail, pass);

            return null;
        }

        public static void Withdraw(string type, string mail, string pass)
        {
            Console.WriteLine("How much Do you wish To Withdraw");

            string amount11 = Console.ReadLine();
            string amount1 = ErrorValidators.Amount_AccNumCheck(amount11, "Invalid, Amount Can only Be Positive Numbers");


            decimal? amount = Math.Abs(Convert.ToDecimal(amount1));

            decimal? typeLimit = type == "SAVINGS" ? 1000 : 0;

            foreach (var s in Customer)
            {
                if (s.accUpdate.AccountType == type && s.accUpdate.Email == mail && s.accUpdate.password == pass)
                {
                    
                    if(amount <= s.accUpdate.Balance - typeLimit)
                    {
                        s.accUpdate.Balance -= amount;

                        s.AddTransaction(amount, $"Money Withdrawn");

                        Console.WriteLine($"Successfully Withdrew {amount}, Your Balance is {s.accUpdate.Balance}");
                    }
                    else if ((s.accUpdate.Balance - typeLimit) - amount < 0)
                    {
                        Console.WriteLine("Account Balnce Can Not Be Negative After Transaction, Go back and Try again or Go To Main Menu");
                        ErrorValidators.Back(type, mail, pass);
                    }
                    else
                    {
                        Console.WriteLine("Account Balnce Can Not Be Lower Than 1000, Go back and Try again or Go To Main Menu");
                        ErrorValidators.Back(type, mail, pass);
                    }
                }
            }
            ErrorValidators.Back(type, mail, pass);
        }

        public static void GetBalance(string type,string  mail, string pass)
        {
            foreach (var s in Customer)
            {
                if(s.accUpdate.AccountType == type && s.accUpdate.Email == mail && s.accUpdate.password == pass)
                {
                    Console.WriteLine($"You Have {s.accUpdate.Balance} In Your {s.accUpdate.AccountType} Account, and Your Account Number is {s.accUpdate.AccountNumber}");
                }
            }
            ErrorValidators.Back(type, mail, pass);
        }

        public static void AmountTransfer(string type, string mail, string pass)
        {
            Console.WriteLine("How much Do you wish To Transfer");
            string amount11 = Console.ReadLine();
            string amount1 = ErrorValidators.Amount_AccNumCheck(amount11, "Invalid, Amount Can only Be Positive Numbers");

            decimal? amount = Math.Abs(Convert.ToDecimal(amount1));


            Console.WriteLine("Input Recipient Account Number");
            string recieverNum = Console.ReadLine();
           
            string reciever = ErrorValidators.Amount_AccNumCheck(recieverNum, "Invalid, Account NUmber Can Not Be Made Up Of Positive Numbers");

            decimal? typeLimit = type == "SAVINGS" ? 1000 : 0;

            foreach (var s in Customer)
            {
                if (s.accUpdate.AccountType == type && s.accUpdate.Email == mail && s.accUpdate.password == pass)
                {
                    if (amount <= s.accUpdate.Balance - typeLimit)
                    {
                        s.accUpdate.Balance -= amount;

                        s.AddTransaction(amount, $"Money Transfer");

                        Console.WriteLine($"Successfully Transfered {amount}, To {reciever}");
                    }
                    else if ((s.accUpdate.Balance - typeLimit) - amount < 0)
                    {
                        Console.WriteLine("Account Balance Can Not Be Negative After Transaction, Go back and Try again or Go To Main Menu");
                        ErrorValidators.Back(type, mail, pass);
                    }
                    else
                    {
                        Console.WriteLine("Account Balnce Can Not Be Lower Than 1000, Go back and Try again or Go To Main Menu");
                        ErrorValidators.Back(type, mail, pass);
                    }
                }
            }

            foreach (var s in Customer)
            {
                if (s.accUpdate.AccountNumber == reciever)
                {
                    s.accUpdate.Balance += amount;

                    s.AddTransaction(amount, $"Money Received from {mail}");
                }
            }
            ErrorValidators.Back(type, mail, pass);
        }
        public static void Accdetails(string type, string mail, string pass)
        {
            var Table = new PrintTable("Account Name", "Account Number", "Account Type", "Account Balance($)");
            Console.WriteLine($"ACCOUNT DETAILS");
            foreach (var s in Customer)
            {
                if(s.accUpdate.AccountType == type && s.accUpdate.Email == mail && s.accUpdate.password == pass)
                {
                    Table.AddRow(s.accUpdate.AccountName.Trim(), s.accUpdate.AccountNumber, s.accUpdate.AccountType, s.accUpdate.Balance.ToString());
                    Table.prints();
                    ErrorValidators.Back(type, mail, pass);
                }
            }
        }

        public static void AccStatement(string type, string mail, string pass)
        {
            var Table = new PrintTable("Date", "Description", "Amount", "Account Balnce");

            foreach(var s in Customer)
            {
               if(s.accUpdate.AccountType == type && s.accUpdate.Email == mail && s.accUpdate.password == pass)
                {
                    var w = s.accUpdate.TransactionList;

                    Console.WriteLine($"ACCOUNT STATEMENT FOR {s.accUpdate.AccountName} WITH ACCOUNT NUMBER {s.accUpdate.AccountNumber}");
                    foreach(var t in w)
                    {
                        if(t.TransactionId == s.accUpdate.AccountNumber + s.accUpdate.FirstName)
                        {
                            Table.AddRow(t.DateTime.ToString(), t.Description, t.outAmount.ToString(), t.Balance.ToString());
                        }
                    }
                    Table.prints();
                    ErrorValidators.Back(type, mail, pass);
                }
                    
            }
        }
    }

    
}
