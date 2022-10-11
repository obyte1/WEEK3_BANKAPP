using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankAppWeek3.Vallidators
{
    public class RegexVallidator
    {
        public static bool CheckEmail(string email)
        {
            string strRegex = @"^[a-z]+[0-9a-zA-Z_.+-]+[@]{1}[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return PerformRegEx(strRegex, email);
        }
        public static bool CheckName(string name)
        {
            string strRegex = @"^[A-Z]";
            return PerformRegEx(strRegex, name);
        }
        public static bool CheckPassword(string password)
        {
            string strRegex = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{6,}$";
            return PerformRegEx(strRegex, password);
        }
        private static bool PerformRegEx(string pattern, string value)
        {
            Regex re = new Regex(pattern);

            if (re.IsMatch(value))
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
    }
}
