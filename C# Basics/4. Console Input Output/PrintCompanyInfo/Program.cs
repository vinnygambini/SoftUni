using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCompanyInfo
{
    class Program
    {
        static void Main(string[] args)

        {
            string CompanyName = "Microsoft";
            string Address = "Who Knows";            
            int Fax = 87654321;
            string WebSite = "http://microsoft.com";

            Console.WriteLine("Company's name is " + CompanyName);
            Console.WriteLine("Company's address is " +Address);
            Console.WriteLine("Company's fax is " + Fax);
            Console.WriteLine("Company's website is " + WebSite);
            
            Console.Write("Write down manager's first name ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Manager's first name is " + FirstName);
            
            Console.WriteLine("Write down manager's last name ");
            string LastName = Console.ReadLine();
            Console.WriteLine("Manager's last name is " + LastName);
            
            Console.Write("Write down manager's age ");
            byte Age = byte.Parse(Console.ReadLine());
            Console.Write("Manager's age is " + Age);

            Console.Write("Write down manager's phone number ");
            int PhoneNumber = int.Parse(Console.ReadLine());
            Console.Write("Manager's Phone Number is " + PhoneNumber);
        }
    }
}
