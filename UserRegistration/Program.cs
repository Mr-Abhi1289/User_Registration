using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Email");
            var Email=Console.ReadLine();
            var pattern = "^[0-9A-Za-z]+([.][0-9A-Za-z]+)[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
            Regex regex= new Regex(pattern);
            if( regex.IsMatch(Email))
            {
                Console.WriteLine(Email + " Valid Email id");
            }
            else
            {
                Console.WriteLine(Email + " Invalid Email id");               
            }
        }
    }
}