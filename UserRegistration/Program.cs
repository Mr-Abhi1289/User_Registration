using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name");
            var FirstName=Console.ReadLine();
            var pattern = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex= new Regex(pattern);
            if( regex.IsMatch(FirstName))
            {
                Console.WriteLine(FirstName + " Valid Firstname ");
            }
            else
            {
                Console.WriteLine(FirstName + " Invalid Firstname");
                
            }

        }
    }
}