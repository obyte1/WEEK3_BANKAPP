using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMapp_new.View
{
    public static class welcome
    {
        internal static void welcome_msg()
        {
            Console.Clear();
            //Title of my App
            Console.Title = "UNITED BANK FOR DECAGON BY OBUTE";

            //Text color
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("\n\n ********************************** WELCOME TO OBUTE'S WEEK THREE TASK **********************************\n");


        }
    }
}
