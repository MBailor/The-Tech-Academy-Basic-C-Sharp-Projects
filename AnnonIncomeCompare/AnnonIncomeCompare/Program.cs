using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnonIncomeCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.ReadLine();

            Console.WriteLine("Enter Hourly Rate");
            string yourRate = Console.ReadLine();
            decimal entRate = Convert.ToDecimal(yourRate);
            Console.ReadLine();

            Console.WriteLine("Enter Hours Worked Per Week");
            string hoursWrk = Console.ReadLine();
            decimal entWrk = Convert.ToInt32(hoursWrk);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("Enter Hourly Rate");
            string yourRate1 = Console.ReadLine();
            decimal entRate1 = Convert.ToDecimal(yourRate1);
            Console.ReadLine();
            
            Console.WriteLine("Enter Hours Worked Per Week");
            string hoursWrk1 = Console.ReadLine();
            decimal entWrk1 = Convert.ToDecimal(hoursWrk1);
            
            decimal p1AnualS = entRate * entWrk * 52;
            decimal p2AnualS = entRate1 * entWrk1 * 52;
            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine(p1AnualS);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2");
            Console.WriteLine(p2AnualS);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();
            bool isRich = p1AnualS > p2AnualS;
            Console.WriteLine(isRich);
            Console.ReadLine();

        }
    }
}
