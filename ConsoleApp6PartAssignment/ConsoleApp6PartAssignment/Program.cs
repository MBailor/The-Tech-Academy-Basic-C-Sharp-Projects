using System;
using System.Collections.Generic;


namespace ConsoleApp6PartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

                                           // This is the code for part one -- This is a on dimensional array of strings. Asks the user to input some text
                                           // and then loops through the list and prints the list to the screen, adding the users text to the end of the string.


            //string[] names = { "War and Peace, Written by: ", "Casa Blanca, Written by: ", "To Kill A Mockingbird, Written by: ", "Gone With The Wind, Written by: " };
            //Console.WriteLine("Please enter your name!");
            //string entName = Console.ReadLine();

            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j] + entName);
            //}
            //Console.ReadLine();


                                    //This is the code for part two -- This code creates an infinite loop


            ////for (int a = 0; a < 50; a--)
            ////{
            ////    Console.WriteLine("value : {0}", a);
            ////}
            ////Console.ReadLine(); 


                                              ////This it the code for part three -- This code loops and stops where the code above should have stopped 
                                              ////It also uses a "<" operator, a <= operator , and why not throw in a >=


            //for (int k = 0; k < 50; k++)
            //{
            //    Console.WriteLine(k);
            //}
            //Console.ReadLine();


            //for (int t = 4500; t >= 450; t--)
            //{
            //    Console.WriteLine(t);
            //}
            //Console.ReadLine();


            //for (int e = 200; e <= 375; e++)
            //{
            //    Console.WriteLine(e);
            //}
            //Console.ReadLine();


                            //// This codes is part 4 -- list of unique items, askes user to enter a word if the word is on the list, the program let's 
                            //// the user know and the program ends. If the user picks a word not on the list, the program informs the user and continues.


            //List<string> ranStrings = new List<string>();
            //ranStrings.Add("Pancakes");
            //ranStrings.Add("French Toast");
            //ranStrings.Add("Chicken Fried Steak");
            //ranStrings.Add("Bacon");
            //ranStrings.Add("Oatmeal");
            //ranStrings.Add("Fruit Cup");

            //Console.WriteLine("Please enter a Breakfast item to see if it's available");
            //string entFood = Console.ReadLine();
            //string ranStrings1 = Convert.ToString(ranStrings);
            //int getFoodIndex = ranStrings.FindIndex(s => String.Equals(s, entFood));
            //bool getFoodString = Convert.ToBoolean(getFoodIndex);
            //bool isMatch = false;

            //do
            //{
            //    if (ranStrings.Contains(entFood))
            //    {
            //        Console.WriteLine("Yum! You chose: " + entFood + " Excellant choice! This is Item #: " + getFoodIndex + "");
            //        isMatch = true;
            //        Console.ReadLine();
            //        return;
            //    }
            //    else if (!ranStrings.Contains(entFood))
            //    {
            //        Console.WriteLine("You have selected a food item that is unavailable.");
            //        Console.WriteLine("Please enter a Breakfast item to see if it's available");
            //        entFood = Console.ReadLine();
            //        ranStrings1 = Convert.ToString(ranStrings);
            //        getFoodIndex = ranStrings.FindIndex(s => String.Equals(s, entFood));
            //        getFoodString = Convert.ToBoolean(getFoodIndex);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Yum! You chose: " + entFood + " Excellant choice! This is Item #: " + getFoodIndex + "");
            //        isMatch = true;
            //        Console.ReadLine();
            //        return;
            //    }
            //} while (isMatch == false);


                                ////This is the code for Part 5 -- List w/ @least 2 identical strings ask user to select text to search through the 
                                ////list and display the indicesof the list that contain matching text and text that lets user know if the text they
                                ////entered is not on the list.
                                

            //List<string> officeSupplies = new List<string>();
            //List<int> dupIndex = new List<int>();
            //officeSupplies.Add("Pencil");
            //officeSupplies.Add("Pen");
            //officeSupplies.Add("Scissor");
            //officeSupplies.Add("Hole Punch");
            //officeSupplies.Add("Pen");
            //officeSupplies.Add("Paper");

            //Console.WriteLine("Please enter an office supply item to see if it's available");
            //string entSearch = Console.ReadLine();
            //string stringSearch1 = Convert.ToString(officeSupplies);
            //int getStringIndex = officeSupplies.FindIndex(s => String.Equals(s, entSearch));
            //int getStringIndex1 = officeSupplies.FindLastIndex(t => String.Equals(t, entSearch));
            //bool getIndexString = Convert.ToBoolean(getStringIndex);
            //bool isAMatch = false;

            //foreach (var supply in officeSupplies)
            //{


            //    if (officeSupplies.Contains(entSearch))
            //    {
            //        Console.WriteLine("You have chosen the office supply, " + entSearch + " Which has an index of: " + getStringIndex + "");
            //        Console.ReadLine();



            //        if (getStringIndex == getStringIndex1)
            //        {
            //            Console.WriteLine("You have chosen the office supply, " + entSearch + " Which has an idex of: " + getStringIndex + " and " + getStringIndex1 + "");
            //            Console.ReadLine();

            //        }
            //    }

            //    else
            //    {
            //        Console.WriteLine("You have chosen an office supply that is currently unavailable.");
            //        Console.ReadLine();
            //        return;
            //    }
            //    return;
            //}

                                                ////This is the code for Part 6 -- List w/ @least 2 identical strings, loops the through 
                                                ////the list and prints if the string has already appeared on he list. 

            //List<string> Motorcycles = new List<string>() { "Ducati", "Triumph", "Honda", "Kawasaki", "Suzuki", "Kawasaki", "Harley Davidson", "Triumph" };
            //List<string> lookForMore = new List<string>();

            //foreach (var Motorcycle in Motorcycles)
            //{
            //    if (lookForMore.IndexOf(Motorcycle) == -1)
            //    {
            //        lookForMore.Add(Motorcycle);
            //        Console.WriteLine(Motorcycle);
            //        Console.ReadLine();

            //    }
            //    else
            //    {

            //        Console.WriteLine($"{Motorcycle} \n\n{Motorcycle} has already appeared on the list");
            //        lookForMore.Add(Motorcycle);
            //        Console.ReadLine();
            //    }
                
            //}

        }
    }
}


