using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.WriteLine("Hello Wereld! Wat is jouw naam?");
            userInput = Console.ReadLine();

            Console.WriteLine("Aangename kennismaking'{0}'", userInput);
            Console.WriteLine("Druk op een knop om verder te gaan....");


            Console.ReadKey();

        }
    }
}
