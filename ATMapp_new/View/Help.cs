using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppWeek3.UI
{
    public class Help
    {
        public static void Helper()
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO UNITED BANK OF AFRICA");
            Console.WriteLine("ENTERPISE, EXCELLENCE AND EXECUTION");

            Console.WriteLine("Press 1: To Login To An Existing Account\npress 2: To Creat An Account (SAVINGS/CURRENT)\npress 3: To Go Back");
            string reply = Console.ReadLine();

            while(reply != "1" && reply != "2" && reply != "3")
            {
                Console.WriteLine("Invalid Input, Try Again With A valid Input From The Options Given: ");
                reply = Console.ReadLine();
            }
            if(reply == "1")
            {
                LoginMain.LoginMenue();
            }
            else if(reply == "2")
            {
                CreateMenu.AccountsMenue();
            }
            else
            {
                DisplayMenu.Display();
            }

            Console.ReadLine();

           

        }

    }
}
