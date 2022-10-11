using ATMapp_new.Controller;
using BankAppWeek3.AccountLogin;
using BankAppWeek3.TransactionCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppWeek3.UI
{
    public class LoginMain
    {
        public static void LoginMenue()
        {
            Console.Clear();

            Console.WriteLine("Which Account Do You Want To Access: ");
            Console.WriteLine("1: SAVING'S ACCOUNT\n2: CURRENT ACCOUNT\n3: Back");
            string reply = Console.ReadLine();

            while (reply != "1" && reply != "2" && reply != "3")
            {
                Console.Clear();
                Console.WriteLine("Invalid Input.(input 1 or 2)\nTry Again");

                reply = Console.ReadLine();
                Console.ResetColor();
            }
            if (reply == "1")
            {
                MenuLogin.Login2Account("SAVINGS");
            }
            else if (reply == "2")
            {
                MenuLogin.Login2Account("CURRENT");

            }
            else
            {
                DisplayMenu.Display();
            }
        }
        public static void TransMethod(string Type, string repl, string answer)
        {
            
            Console.Clear();
            Console.WriteLine($" \n WELCOME {repl.ToUpper()}\n");
            //Console.WriteLine()
            Console.WriteLine("Please choose from one of the following options");
            Console.WriteLine("1: Deposit");
            Console.WriteLine("2: Withdrawal");
            Console.WriteLine("3: Transfer");
            Console.WriteLine("4: Check Balance");
            Console.WriteLine("5: Print Statement");
            Console.WriteLine("6: print details");
            Console.WriteLine("7: Log Out");

            string reply = Console.ReadLine();

            while (reply == "1" && reply == "2" && reply == "3" && reply == "4" && reply == "5" && reply == "6" && reply == "7")
            {
                Console.WriteLine("Inavalid Input");
                Console.WriteLine("Input a number between 1 amd 6");
                reply =Console.ReadLine();
            }

            if (reply == "1")
            {
                TransactionsActions.DisplayMoney(Type, repl, answer);
            }
            else if (reply == "2")
            {
                TransactionsActions.Withdraw(Type, repl, answer);
            }
            else if (reply == "3")
            {
                TransactionsActions.AmountTransfer(Type, repl, answer);
            }
            else if (reply == "4")
            {
                TransactionsActions.GetBalance(Type, repl, answer);
            }
            else if (reply == "5")
            {
                TransactionsActions.AccStatement(Type, repl, answer);
            }
            else if (reply == "6")
            {
                TransactionsActions.Accdetails(Type, repl, answer);
            }
            else
            {
                DisplayMenu.Display();
            }
        }
    }
}
