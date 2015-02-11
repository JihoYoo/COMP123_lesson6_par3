using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Deck myDeck = new Deck();


            Console.WriteLine(myDeck.pickCard(0));
         
           

            waitForAnyKey();

        }
            private static void waitForAnyKey()
            {
            Console.Write("\n");
            Console.WriteLine("+++++++++++++++++++++++++++++");
            Console.WriteLine("Pleace hit any key to exit...");
            Console.ReadKey();
            }
        }
    }

