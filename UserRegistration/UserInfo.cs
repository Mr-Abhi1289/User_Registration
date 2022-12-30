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
        public string MAILID= "^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\\.[a-zA-Z0-9-]+)*$";
        public string PHONENUMBER= "^[+][0-9]{1,3}[ ][6-9]{1}[0-9]{9}$";
        public static string PASSRULE1 = "^(?=.*[A-Z])(?=.*\\d)(?=[\\w]*[\\W][\\w]*$)[\\S]{8,}$";



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
        public bool validatephonenumber(string phonenumber)
        {
            return Regex.IsMatch(phonenumber,PHONENUMBER);
        }
        public bool validatepassword1(string password1)
        {
            return Regex.IsMatch(password1, PASSRULE1);
        }



    }
}
