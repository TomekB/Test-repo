using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIWTPZA___Prostokąty
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilosc = int.Parse(Console.ReadLine());
            string[] prostokat = new string [ilosc];
            int wiersz = 0;
            while (wiersz <= ilosc-1)
            {
                string Dane = Console.ReadLine();
                string[] znak = Dane.Split(new char[] { ' ' });
                int A, B, C, D;
                A = int.Parse(znak[0]);
                B = int.Parse(znak[1]);
                C = int.Parse(znak[2]);
                D = int.Parse(znak[3]);

                double x = Math.Sqrt(A ^ 2 + B ^ 2); 
                double y = Math.Sqrt(C ^ 2 + D ^ 2);

                if (x>y)
                {
                    prostokat[wiersz] = "TAK";
                }
                else
                {
                    prostokat[wiersz] = "NIE";
                }
                wiersz++;

            }

            foreach (string zawartosc in prostokat)
            {
                Console.WriteLine(zawartosc);
            }
            Console.ReadKey();
        }
    }
}
