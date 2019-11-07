using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.console.Lancering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoeveel seconden tot lancering?");

            int length = 1;

            int i = Convert.ToInt32(Console.ReadLine());

            for (; i >= length; i--)
            {
                Console.WriteLine(i + "....");
            }

            if ( i < 1 )
            {
                Console.WriteLine("Lift off!");
            }
            Console.Read();
        }
    }
}
