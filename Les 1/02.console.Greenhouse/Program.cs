using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.console.Greenhouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInputA;
            string userInputB;
            string userInputC;
            Console.WriteLine("***WELKOM BIJ GREENHOUSE RESTAURANT***");
            Console.WriteLine("========================================");
            
            Console.Write("Kies een grootte (kleine of grote):");
            userInputA = Console.ReadLine();
            
            Console.Write("Kies een basis (quinoa, rijst of salade):");
            userInputB = Console.ReadLine();
            
            Console.Write("Kies een soort (vegan, zalm of kip):");
            userInputC = Console.ReadLine();

            Console.WriteLine("Je besteling:" + " een " +  userInputA + " " +  userInputB  + " met " +  userInputC);
            Console.Read();
        }
    }
}
