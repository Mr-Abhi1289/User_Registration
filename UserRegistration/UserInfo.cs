using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserInfo
    {
        public static string FIRSTNAME = "^[A-Z]{1}[a-z]{2,}$";
        public static string LASTNAME = "^[A-Z]{1}[a-z]{2,}";

        public bool validateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname, FIRSTNAME);

        }
        public bool validateLastName(string lastName) 
        {
            return Regex.IsMatch(lastName,LASTNAME);

        }


    }
}
