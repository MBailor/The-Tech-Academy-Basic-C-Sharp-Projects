using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {

            //Daily Report Assignment
            Console.WriteLine("The Tech Academy.");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What is youe name?");
            string yourname = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string whatCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            string myPageNum = Console.ReadLine();
            int pageNum = Convert.ToInt32(myPageNum);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer \" True \" or \" False. \"");
            bool isTrue = true;
            bool isNot = false;
            string trueStatus = Convert.ToString(isTrue);
            string falseStatus = Convert.ToString(isNot);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please be specific.");
            string posExp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedBack = Console.ReadLine();

            Console.WriteLine("How many hours is you study today?");
            string myNumOfHours = Console.ReadLine();
            int numOfHours = Convert.ToInt32(myNumOfHours);
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();


        }    
    }
}
