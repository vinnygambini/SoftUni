using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            DateTime dateTime;
            if (DateTime.TryParse(input, out dateTime))
            {
                DateTime inputTime = DateTime.Parse(input);
                DateTime start = Convert.ToDateTime("01:00 PM");
                DateTime end = Convert.ToDateTime("03:00 AM");
                if ((inputTime >= end) && (inputTime < start))
                {
                    Console.WriteLine("It's non-beer time");
                }
                else
                {
                    Console.WriteLine("It's beer time");
                }
            }
            else
            {
                Console.WriteLine("invalid time");
            }
        }
    }
}
