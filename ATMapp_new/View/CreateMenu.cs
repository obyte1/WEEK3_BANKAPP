using ATMapp_new.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppWeek3.UI
{
    public class CreateMenu
    {
        public static void AccountsMenue()
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO THE ACCOUNT CREATION PAGE");

            Console.WriteLine("What type of Account Would You Like To Create");

            Console.WriteLine();

            Console.WriteLine("1: SAVINGS \n2: CURRENT\n3: Go back ");
            Console.WriteLine();
            string input = Console.ReadLine();

            while (input != "1" && input != "2" && input != "3")
            {
                Console.WriteLine("INVALID INPUT, Try Again");

                input = Console.ReadLine();
            }

            if (input == "1")
            {
                CreateAccount.Create("SAVINGS");
            }
            else if (input == "2")
            {
                CreateAccount.Create("CURRENT");
            }
            else
            {
                DisplayMenu.Display();
            }




        }
    }
    
}
