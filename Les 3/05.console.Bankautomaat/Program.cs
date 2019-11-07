using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.console.Bankautomaat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bankautomaat");
            Console.WriteLine("=============");

            Console.WriteLine("a. afhaling");
            Console.WriteLine("b. storting");
            Console.WriteLine("c. stoppen");

            int saldo = 500;
            char keuze;

            switch (keuze)
            {
                case 'a':
                    Console.WriteLine("Hoeveel wilt u afhalen?");
                    break;
                case 'b':
                    Console.WriteLine("Hoeveel wilt u toevoegen");
                    break;
                    default:
                    Console.WriteLine("Not a valid input!");
                    break;
            }
        }
    }
}
