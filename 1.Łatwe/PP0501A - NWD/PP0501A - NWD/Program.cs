using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP0501A___NWD
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilosc = int.Parse(Console.ReadLine());
            int[] zestaw = new int [ilosc];

            for (int x=0; x<ilosc; x++)
            {
                string wiersz = Console.ReadLine();
                string[] pozycja = wiersz.Split(new char[] { ' ' });
                int a = int.Parse(pozycja[0]);
                int b = int.Parse(pozycja[1]);
                while (a != b)
                {
                    if (a>b)
                    {
                        int c = a - b;
                        a = b;
                        b = c;                        
                    }
                    else
                    {
                        int c = b - a;
                        a = a;
                        b = c;
                    }
                }
                zestaw[x] = a;
                                

            }
            foreach (int wynik in zestaw)
            {
                Console.WriteLine(wynik);
            }
            Console.ReadKey();
        }
    }
}
