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
        public bool validateFirstName(string Fname)
        {
            return Regex.IsMatch(Fname, FIRSTNAME);
        }
    }
}
