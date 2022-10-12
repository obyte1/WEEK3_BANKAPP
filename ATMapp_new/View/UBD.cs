using ATMapp_new.Controller;
using ATMapp_new.View;
using BankAppWeek3.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMapp_new
{
    internal class UBD
    {
        static void Main(string[] args)
        {
            welcome.welcome_msg();
            DisplayMenu.Display();
            Console.ReadLine();
        }
    }
}
