using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.console.Hms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef het aantal seconden: {0}");
            
            

     
            int seconden = Convert.ToInt32(Console.ReadLine());


            int u = seconden / 60;
            int m = (seconden % 3600) / 60; 
            int s = seconden % 60;

            Console.WriteLine("Omgezet in hms formaat: {0} {1} {2}", u, m, s);
            Console.ReadLine();





        }
    }
}
