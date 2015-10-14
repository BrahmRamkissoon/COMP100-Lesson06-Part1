using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06_Part1
{
    enum Browser 
    {
        IE = 1, CHROME, FIREFOX, SAFARI
    }

    class Program
    {
        static void Main ( string [] args )
        {
            int favouriteBrowser;
            string prompt;
            bool answer;

            Console.Write( "Q1. What's your favourite browser: " );
            Console.WriteLine( "++++++++++++++++++++++++++++++++" );
            Console.WriteLine( "1 - IE" );
            Console.WriteLine( "2 - Chrome" );
            Console.WriteLine( "3 - Firefox" );
            Console.WriteLine( "4 - Safari" );
            Console.WriteLine( "Please make your selection (1 to 4):" );
            prompt = Console.ReadLine();
            Console.Write( "\n");
            favouriteBrowser = Convert.ToInt32( prompt );
            Console.WriteLine("++++++++++++++++++++++++++++++++");

            switch ((Browser)favouriteBrowser)          // cast to ENUM
            {
                case Browser.IE:
                    Console.WriteLine( "You Chose IE" );
                    break;
                case Browser.CHROME:
                    Console.WriteLine( "You Chose the most popular browser" );
                    break;
                case Browser.FIREFOX:
                    Console.WriteLine("That browser is pretty good");
                    break;
                case Browser.SAFARI:
                    Console.WriteLine("You like apple, eh?");
                    break;
                default:
                    Console.WriteLine( $"ERROR - Invalid Entry!!" );
                    break;
            }


            answer = favouriteBrowser == 2 ? true : false;

            // Wait for a key to bre pressed before continuing
            Console.WriteLine("++++++++++++++++++++++++++++++++");
            Console.WriteLine( "Press any key to exit..." );
            Console.ReadKey();
        }
    }
}
