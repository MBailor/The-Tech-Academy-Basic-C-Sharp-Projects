using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ricky Carmichael #4, James Steuart #7, Chad Reed #22, Kevin Whindam #14");
            Console.WriteLine("Guess today's Rider Of The Day! to be entered into a raffle.");
            int rider = Convert.ToInt32(Console.ReadLine());
            bool number = rider == 14;

            do
            {
                switch (rider)
                {
                    case 4:
                        Console.WriteLine("Ricky is the GOAT, but he's not our Rider Of The Day! Try Again!");
                        Console.WriteLine("Guess today's Rider Of The Day! to be entered into a raffle.");
                        rider = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("James Stewart was very fast, but he's not our Rider Of The Day! Try Again!");
                        Console.WriteLine("Guess today's Rider Of The Day! to be entered into a raffle.");
                        rider = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 22:
                        Console.WriteLine("Speedy Chad Reed was almost alway ahead of the pack, but he's not our Rider Of The Day! Try Again!");
                        Console.WriteLine("Guess today's Rider Of The Day! to be entered into a raffle.");
                        rider = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 14:
                        Console.WriteLine("K-DUB! KEVIN WINDHAM IS OUR RIDER OF THE DAY!! You have been entered into the raffle!");
                        number = true;
                        break;
                    default:
                        Console.WriteLine("That's not one of our riders today, please Try Again!");
                        Console.WriteLine("Guess today's Rider Of The Day! to be entered into a raffle.");
                        rider = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!number);

            Console.ReadLine();
        }
    }
}
