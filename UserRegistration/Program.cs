using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter LastName");
            var LastName=Console.ReadLine();
            var pattern = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex= new Regex(pattern);
            if( regex.IsMatch(LastName))
            {
                Console.WriteLine(LastName + " Valid Lastname ");
            }
            else
            {
                Console.WriteLine(LastName + " Invalid Lastname");               
            }
        }
    }
}