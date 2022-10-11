using ATMapp_new.View;
using BankAppWeek3.UI;
using BankAppWeek3.Vallidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppWeek3.ErrorChecker
{
    public class ErrorValidators
    {
        public static string Checkename(string input, string description)
        {
            while (true)
            {
                if (RegexVallidator.CheckName(input))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine(description);
                    Console.WriteLine("Try Again With Valid Format: ");
                    input = Console.ReadLine();
                }            
            }
        }
        public static string Checkemail(string input, string description)
        {
            while (true)
            {
                if (RegexVallidator.CheckEmail(input))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine(description);
                    Console.WriteLine("Try Again With Valid Format: ");
                    input = Console.ReadLine();
                }
            }
        }
        public static string Checkpassword(string input, string description)
        {
            while (true)
            {
                if (RegexVallidator.CheckPassword(input))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine(description);
                    Console.WriteLine("Try Again With Valid Format: ");
                    input = Console.ReadLine();
                }
            }
        }
        public static void Back(string type, string mail, string pass)
        {
            Console.WriteLine();
            Console.Write("press 0 to go back or 1 to Go to Main Menu: ");

            string back = Console.ReadLine();

            while (back != "0" && back != "1")
            {
                Console.WriteLine("Invalid Input, Try Again: ");
                back = Console.ReadLine();
            }
            if (back == "0")
            {
                LoginMain.TransMethod(type, mail, pass);
            }
            else
            {
                DisplayMenu.Display();
            }
        }
        public static void Back2LoginMenu_DisplayMenu()
        {
            Console.WriteLine("press 0 To go Back or 1 to Go To Main Menu");
            string answer = Console.ReadLine();
            while (answer != "0" && answer != "1")
            {
                Console.WriteLine("Invalid Input Try Again");
                answer = Console.ReadLine();
            }
            if (answer == "0")
            {
                LoginMain.LoginMenue();
            }
            else
            {
                DisplayMenu.Display();
            }
        }

        public static void Back2CreateMenu_DisplayMenu()
        {
            Console.Write("Press 0 to go back or 1 to go to Main Menu: ");
            string reply = Console.ReadLine();

            while (reply != "0" && reply != "1")
            {
                Console.WriteLine("Inavlid input");
                Console.Write("TryAgain: ");
                reply = Console.ReadLine();
            }
            if (reply == "0")
            {
                CreateMenu.AccountsMenue();
            }
            else { DisplayMenu.Display(); }

        }

        public static string Amount_AccNumCheck(string num, string description)
        {
            int recieverAmount = 0;
            while (!int.TryParse(num, out recieverAmount))
            {
                Console.WriteLine(description);
                Console.WriteLine("Input Valid Number");
                num = Console.ReadLine();
            }
            return num;
        }
    }
}
