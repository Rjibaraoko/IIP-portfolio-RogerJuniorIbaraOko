using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.console.Eindcijfer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berekening eindcijfer");
            Console.WriteLine("=====================");
            Console.WriteLine("Geef het cijfer dagelijks werk (op 20):");
            
            Console.WriteLine("Geef het cijfer op het examen (op 20):");


            int input = Convert.ToInt32(Console.ReadLine());

            if (input <= 20)
            {
                Console.WriteLine("Geef het cijfer op het project (op 20):");
            }
        }
    }
}
