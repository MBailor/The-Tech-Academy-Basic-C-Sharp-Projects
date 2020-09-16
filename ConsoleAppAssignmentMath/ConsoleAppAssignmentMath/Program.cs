using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignmentMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chose a number to multiply by 50!");
            string yourNum1 = Console.ReadLine();
            long entNum1 = Convert.ToInt64(yourNum1);
            long product = entNum1 * 50;
            Console.WriteLine(product);
            Console.ReadLine();

            Console.WriteLine("Chose a number to add to 25!");
            string yourNum2 = Console.ReadLine();
            long entNum2 = Convert.ToInt64(yourNum2);
            long adding = entNum2 + 25;
            Console.WriteLine(adding);
            Console.ReadLine();

            Console.WriteLine("Let's divide something by 12.5");
            string yourNum3 = Console.ReadLine();
            decimal entNum3 = Convert.ToInt64(yourNum3);
            decimal dividing = entNum3 / 12.5m;
            Console.WriteLine(dividing);
            Console.ReadLine();

            Console.WriteLine("Chose a number and this program will tell you if it's greater than 50");
            string yourNum4 = Console.ReadLine();
            int entNum4 = Convert.ToInt32(yourNum4);
            bool isFidy = entNum4 > 50;
            Console.WriteLine(isFidy);
            Console.ReadLine();

            Console.WriteLine("Let's divide a number by 7 and see what the remainder is");
            string yourNum5 = Console.ReadLine();
            long entNum5 = Convert.ToInt64(yourNum5);
            long divider = entNum5 / 7;
            long remainder = entNum5 % 7;
            Console.WriteLine(divider);
            Console.WriteLine(remainder);
            Console.ReadLine();

        }
    }
}
