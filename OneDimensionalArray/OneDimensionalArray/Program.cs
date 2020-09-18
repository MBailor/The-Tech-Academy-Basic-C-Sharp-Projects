using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
        
        int[] numArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Please select and index of the number array(0-9)");
        int number = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine(numArray[number]);
        Console.ReadLine();

        string[] strArray = new string[] { "H", "E", "L", "L", "O", "N", "E", "W", "M", "A", "N" };
        Console.WriteLine("Please select and index of the string array(0-10)");
        int word = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine(strArray[word]);
        Console.ReadLine();

    } 
    }

