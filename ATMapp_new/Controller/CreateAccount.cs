using BankAppWeek3.ErrorChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMapp_new.Controller
{
    public class CreateAccount
    {
        public readonly static List<AccountTransc> Customer = new List<AccountTransc>();

        public static void Create(string type)
        {

            Console.Write("Enter Your First Name: ");
            string FirstNameInput = Console.ReadLine();
            string FirstName = ErrorValidators.Checkename(FirstNameInput, "Wrong name Format, Name Must Start With a Capital Letter");

            Console.Write("Enter Your Last Name: ");
            string LastNameInput = Console.ReadLine();
            string LastName = ErrorValidators.Checkename(LastNameInput, "Wrong name Format, Name Must Start With a Capital Letter");

            string FullName = FirstName + ", " + LastName;

            Console.Write("Enter Your Email: ");
            string EmailInput = Console.ReadLine();
            string Email = ErrorValidators.Checkemail(EmailInput, "Wrong Email Format, Please in put a valid Email Format (xyz@wv.com)");

            foreach (var s in Customer)
            {
                while (s.accUpdate.AccountName == FullName && s.accUpdate.AccountType == type && s.accUpdate.Email == Email)
                {
                    Console.WriteLine($"A {type} Account With Same Details Exist, Try Again With Different Details. ");

                    ErrorValidators.Back2LoginMenu_DisplayMenu();
                }
            }

            Console.Write("Enter Your Password: ");
            string PasswordInput = Console.ReadLine();
            string Password = ErrorValidators.Checkpassword(PasswordInput, "Wrong Password Format/Length, Please in put a valid Password Format (xyz@wv.com)");


            var CustomerInstance = new AccountTransc(FirstName, LastName, Email, type, 0, Password);
            Customer.Add(CustomerInstance);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nAccount created Succefully");
            Console.WriteLine($"Account Number: {CustomerInstance.accUpdate.AccountNumber}");
            Console.WriteLine($"Account type:  {CustomerInstance.accUpdate.AccountType} Account");
            Console.WriteLine($"Account Name: {CustomerInstance.accUpdate.AccountName}\n");
            Console.WriteLine("Thank You For Choosing UNITED BANK FOR DECAGON");
            Console.WriteLine("The Bank You can Trust.\n");
            Console.ForegroundColor= ConsoleColor.White;

            ErrorValidators.Back2CreateMenu_DisplayMenu();
        }

    }
}
