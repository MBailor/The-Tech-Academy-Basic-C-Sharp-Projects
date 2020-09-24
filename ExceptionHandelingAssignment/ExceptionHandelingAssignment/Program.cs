using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandelingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> nums = new List<int>() { 4, 7, 8, 9, 45, 76, 80, 442 };
                Console.WriteLine("Pick a number for some fun with division!");
                int numOne = Convert.ToInt32(Console.ReadLine());
                

                foreach (int num in nums)
                {
                    Console.WriteLine("Your number is: " + numOne + "");
                    int ansNum = num / numOne;
                    Console.WriteLine("Let's divide," + num + " by " + numOne + "and see what we get!");
                    Console.WriteLine(ansNum);
                    Console.ReadLine();
                } }         // Added ths catch to handle System.DivideByZeroException
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("YO! You Can't Divide By Zero. Idiot! Program Will Close Now!");
            }
                            //Added this catch to handle System.FormatException
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number, not a word, even if the word is a number!");
            }
                            //Added this catch because I couldnt make it error anymore, but who knows what someone else could come up with.
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            Console.WriteLine("The division part of the program has ended, And Now for Something Completely Different!");
            Console.ReadLine();
            }
        }
    }

