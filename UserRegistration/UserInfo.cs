﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserInfo
    {
        public string FIRSTNAME = "^[A-Z]{1}[a-z]{2,}$";
        public string LASTNAME = "^[A-Z]{1}[a-z]{2,}";
        public string MAILID= "^[0-9A-Za-z]+([.][0-9A-Za-z]+)[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";

        public bool validateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname, FIRSTNAME);

        }
        public bool validateLastName(string lastName) 
        {
            return Regex.IsMatch(lastName,LASTNAME);

        }

        public bool validatemailid(string mailid)
        {
            return Regex.IsMatch(mailid, MAILID);
        }
    }
}
