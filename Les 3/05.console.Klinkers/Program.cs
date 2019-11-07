using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.console.Klinkers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Geef een tekst:" );

            int klinker, medeKlinker, len;

            klinker = 0;
            medeKlinker = 0;

            string str = Console.ReadLine();

            len = str.Length;
            

            for (int i = 0; i < len; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'y' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U' || str[i] == 'Y')
                {
                    klinker++;
                }

                else if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    medeKlinker++;
                }

            }
            Console.WriteLine("Deze tekst bevat: " + klinker + " klinkers" );
            Console.WriteLine("En bevat: " + medeKlinker + " medeklinkers");
            Console.Read();
        }
    }
}
