using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6___Part_1
{
    class Program
    {
        enum Browser { IE = 1, CHROME, FIREFOX, SAFARI };

        static void Main(string[] args)
        {
            int favouriteBrowser;
            string prompt;
            bool answer;

            Console.WriteLine("What's your Favourite Browser: ");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("1  -  IE");
            Console.WriteLine("2  -  Chrome");
            Console.WriteLine("3  _  Firefox");
            Console.WriteLine("4  -  Safari");
            Console.Write("Please enter make your selection (1 to 4): ");

            prompt = Console.ReadLine();
            Console.Write("\n");
            favouriteBrowser = Convert.ToInt32(prompt);

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
            switch ((Browser)favouriteBrowser)
            {
                case Browser.IE:
                    Console.WriteLine("You chose IE");
                    break;
                case Browser.CHROME:
                    Console.WriteLine("You chose the most popular browser");
                    break;
                case Browser.FIREFOX:
                    Console.WriteLine("You chose Firefox");
                    break;
                case Browser.SAFARI:
                    Console.WriteLine("You like apple");
                    break;
                default:
                    Console.WriteLine("ERROR - Invalid Entry!!");
                    break;
            }

           answer = (Browser)favouriteBrowser == Browser.CHROME ? true : false;

            //Wait for a key to be pressed before continuing
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }
    }
}
