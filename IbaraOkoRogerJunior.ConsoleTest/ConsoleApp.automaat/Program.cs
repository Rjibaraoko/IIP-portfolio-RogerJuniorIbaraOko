using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.automaat
{
    class Program
    {
        static void Main(string[] args)
        {

            int saldo = 0;

            string a = "a";
            string b = "b";
            string c = "c";
            string d = "d";

            int drank = 2;
            double snoep = 1.5;

            

            double calc1 = saldo - drank;
            double calc2 = saldo - snoep;

            
                Console.WriteLine("AUTOMAAT");
                Console.WriteLine("===========");

                Console.WriteLine("a.geld inwerpen");
                Console.WriteLine("b.drank kopen (2 euro)");
                Console.WriteLine("c.snoep kopen(1,5 euro)");
                Console.WriteLine("d.stoppen");

                Console.WriteLine("Huidige saldo: 0 euro");

                Console.WriteLine("Maak je keuze:");

                string keuze = Console.ReadLine();


            for (int i = 0; i >= saldo; i++)
            {
            if (keuze == a)
                {
                    Console.WriteLine("hoeveel wilt u instorten?");
                    saldo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Bedrag: " + saldo);
                }

                else if (keuze == b)
                {
                    calc1 = saldo - drank;
                    
                    Console.WriteLine("Bedrag: " + saldo);
                }

                else if (keuze == c)
                {
                    calc2 = saldo - snoep;
                    
                    Console.WriteLine("Bedrag: " + saldo);
                }

                else if (keuze == d)
                {
                    Console.WriteLine("Je krijgt" + saldo + "euro terug.");
                    
                }

                else if (saldo < drank || saldo < snoep)
                {
                    Console.WriteLine("Je saldo is te laag; gelieve nog geld in te werpen");
                    
                    Console.WriteLine("Bedrag: " + saldo);
                    
                }

                

                

                Console.WriteLine("Huidige saldo:" + saldo + "euro");
                Console.Read();
            }
        }

    }
}
