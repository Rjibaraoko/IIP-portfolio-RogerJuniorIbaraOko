using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.console.Raden
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            int RndNumber = rnd.Next(1, 10);
            int input = 0;
            Console.WriteLine("Raad een getal tussen 1 en 10");

            
            int length = 3;
            

            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine($"Poging {i}:");
                input = Convert.ToInt32(Console.ReadLine());

                if (input == RndNumber)
                {
                    Console.WriteLine("Geraden!");
                    break;
                }
          
            }

            if (input != RndNumber)
                {
                Console.WriteLine("Volgende keer beter!");
                }

            Console.Read();
        }
    }
}
