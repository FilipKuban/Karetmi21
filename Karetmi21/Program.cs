using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karetmi21
{
    class Program
    {
        static void Main(string[] args)
        {
            NovaHra:
            Random nahodnaCisla = new Random();
            int kartyHrace = nahodnaCisla.Next(1, 12);
            int kartyPc = nahodnaCisla.Next(1, 12);
            DalsiKarta:
            Console.WriteLine("Chceš další kartu? ano/ne Máš " + kartyHrace + " Počítač má "+kartyPc);
            string volba = Console.ReadLine();
            if (volba.ToUpper()== "ANO")
            {
                kartyHrace += nahodnaCisla.Next(1, 12);

                if (kartyPc<15)
                {
                    kartyPc += nahodnaCisla.Next(1, 12);
                }
                    goto DalsiKarta;
            }
            else if (volba.ToUpper() == "NE")
            {
                if (kartyPc<15)
                {
                    do
                    {
                        kartyPc += nahodnaCisla.Next(1, 12);

                    } while (kartyPc<15);
                }
                Console.WriteLine($"Máš {kartyHrace}  Počítač má {kartyPc}");
            }
            if (kartyHrace > kartyPc && kartyHrace <=21 && kartyPc <21)
            {
                if (kartyHrace ==21)
                {
                    Console.WriteLine("Výhra OKO BERE !!!!");
                }
                else
                {
                    Console.WriteLine("Výhra GRATULUJI");
                }
            }
            else if (kartyPc > kartyHrace && kartyPc <=21 && kartyHrace < 21)
            {
                if (kartyPc == 21)
                {
                    Console.WriteLine("Prohra OKO BERE !!!!");
                }
                else
                {
                    Console.WriteLine("Prohra SMŮLA");
                }
            }
            else if (kartyHrace > 21 && kartyPc <=21)
            {
                if (kartyPc == 21)
                {
                    Console.WriteLine("Prohra OKO BERE !!!!");
                }
                else
                {
                    Console.WriteLine("Prohra SMŮLA");
                }
            }
            else if (kartyPc > 21 && kartyHrace <=21)
            {
                if (kartyHrace == 21)
                {
                    Console.WriteLine("Výhra OKO BERE !!!!");
                }
                else
                {
                    Console.WriteLine("Výhra GRATULUJI");
                }
            }
            else
            {
                Console.WriteLine("Prohra SMŮLA");
            }

            Console.WriteLine("\n Další hru?  ano/ne");
            volba = Console.ReadLine();
            if (volba.ToUpper()== "ANO")
            {
                Console.Clear();
                goto NovaHra;
            }
            else
            {
                Console.Clear();

            }
        }
    }
}
