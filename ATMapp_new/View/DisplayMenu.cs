using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppWeek3.UI
{
    public static class DisplayMenu
    {

        //This is the first menu display.
        public static void Display()
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO UNITED BANK FOR DECAGON");
            Console.WriteLine();

            Console.WriteLine("What Operation Would You Like To Carry Out");

            Console.WriteLine("1: Login \n2: Create Account\n3: Exit");

            string input = Console.ReadLine();

            while (input != "1" && input != "2" && input != "3" && input != "4")
            {
                Console.Clear();
                Console.WriteLine("Invalid Input.(input 1, 2 or 3)");
                Console.WriteLine("Try Again");

                input = Console.ReadLine();
                
            }

            if (input == "1")
            {

                LoginMain.LoginMenue();
            }
            else if (input == "2")
            {
               CreateMenu.AccountsMenue();
            }
            //else if (input == "3")
            //{
            //    Help.Helper();
            //}
            else
            {
                Environment.Exit(0);
            }
        }

    }
}
