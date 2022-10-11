
using ATMapp_new.Controller;
using ATMapp_new.View;
using BankAppWeek3.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppWeek3.AccountLogin
{
    public class MenuLogin:CreateAccount
    {
        public static void Login2Account(string type)
        {
            Console.Write("Input Your Email: ");
            string reply = Console.ReadLine();

            Console.Write("Input Your Password: ");
            string answer = Console.ReadLine();

            var cus = MenuLogin.Login(Customer, reply, answer, type);

            if(cus != null)
            {
                LoginMain.TransMethod(type, reply, answer);
                
            }
            else
            {
                while(true)
                {
                    Console.WriteLine("Wrong Email or Password, Press 0 input with a Valid Log In Details or Press 1 To go Back");
                    string input = Console.ReadLine();
                    while(input != "0" && input != "1")
                    {
                        Console.WriteLine("Invalid Input, TryAgain");
                        input = Console.ReadLine();
                    }
                    if(input == "0")
                    {
                        Console.Write("Input Your Email: ");
                        reply = Console.ReadLine();
                        Console.Write("Input Your Password: ");
                        answer = Console.ReadLine();
                    }
                    else
                    {
                        LoginMain.LoginMenue();
                        

                    }
                }
            }          
        }
        public static AccountTransc Login(List<AccountTransc> Cust, string rep, string ans, string type)
        {
            foreach(var s in Customer)
            {
                if(rep == s.accUpdate.Email && ans == s.accUpdate.password && type == s.accUpdate.AccountType)
                {
                    return s;
                }
            }
            return null;
        }
    }
}
