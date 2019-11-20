using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.console.Raden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Raad een getal tussen 1 en 10");

            int getal = 8;
            int input ;

            input = Convert.ToInt32(Console.ReadLine());

            if (getal > input)
            {
                Console.WriteLine("Je raad was te hoog!");

            }

            else if (getal < input) {

                Console.WriteLine("Je raad was te laag!");
            };

            Console.ReadLine();

        }
    }
}
