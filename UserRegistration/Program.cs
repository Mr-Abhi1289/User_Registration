namespace UserRegistration
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

            Console.WriteLine("Enter your mail-id");
            string mailid= Console.ReadLine();
            Console.WriteLine(user.validatemailid(mailid));

            Console.WriteLine("Enter your phonenumber");
            string phonenumber = Console.ReadLine();
            Console.WriteLine(user.validatephonenumber(phonenumber));

            Console.WriteLine("Enter Password with min 8 characters ,Atleast 1 UpperCase, 1 NumericValue");
            string password1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(user.validatepassword1(password1));






        }
    }
}
