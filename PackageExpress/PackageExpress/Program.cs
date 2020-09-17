using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express, Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("How much does your package weigh?");
            string entNum = Console.ReadLine();
            decimal numEnt = Convert.ToDecimal(entNum);

            if (numEnt > 50)
            {
                Console.WriteLine("This Package Is Too Heavy To Be Shipped By Package Express. Have A Good Day!");
            }
            Console.ReadLine();

            Console.WriteLine("Please enter the width of your package.");
            string entWidth = Console.ReadLine();
            decimal widthEnt = Convert.ToDecimal(entWidth);
            Console.ReadLine();

            Console.WriteLine("Please enter the height of your package.");
            string entHeight = Console.ReadLine();
            decimal heightEnt = Convert.ToDecimal(entHeight);
            Console.ReadLine();

            Console.WriteLine("Pleae enter the length of your package.");
            string entLength = Console.ReadLine();
            decimal lengthEnt = Convert.ToDecimal(entLength);
            Console.ReadLine();

            if (widthEnt > 50 && heightEnt > 50 && lengthEnt > 50)
            {
                Console.WriteLine("Sorry! Your Package Is Too Large To Be Shipped By Package Express. Have a good day!");
            }
            else
            {
                decimal shipCost = widthEnt * heightEnt * lengthEnt * numEnt;
                decimal shipTotal = shipCost / 100;
                string shipDisplay = string.Format("Your total shipping cost comes to ${0:0.00}, Thank You!", shipTotal);
                Console.WriteLine(shipDisplay);
            }
            Console.ReadLine();

        }
    }
}
