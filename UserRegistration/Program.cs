﻿namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserInfo user = new UserInfo();
            Console.WriteLine("Enter first Name");
            string firstname = Console.ReadLine();
            Console.WriteLine(user.validateFirstName(firstname));

            Console.WriteLine("Enter last name");
            string Lastname = Console.ReadLine();
            Console.WriteLine(user.validateFirstName(Lastname));


        }
    }
}
