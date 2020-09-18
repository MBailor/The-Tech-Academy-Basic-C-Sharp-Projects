using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTimeStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mark";
            string brand = "Kawasaki";
            string track = "Washougal";

            string conCat = "Tomorrow you can see " + name + " Ride his " + brand + " \nFor the first time and he rips around the track at " + track + " Don't miss it!";

            string upper = conCat.ToUpper();

            Console.WriteLine(upper);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("A silly young man from Clyde \nIn a funeral procession was spied;");

            Console.WriteLine(sb);
            Console.ReadLine();

            sb.Append("\nWhen asked, \"Who is dead?\"\nHe giggled and said,");

            Console.WriteLine(sb);
            Console.ReadLine();

            sb.Append("\n\"I don't know, I've just came for the ride!\"");

            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
