using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP0502B___Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilosc = int.Parse(Console.ReadLine());

            string[][] tablica = new string[ilosc][]; 
            
            for (int i = 0; i < ilosc; i++)
            {
                
                string ciag = Console.ReadLine();
                string [] elementy = ciag.Split(new char[] { ' ' });
                int dlugosc = elementy.Length;

                tablica[i] = new string[dlugosc];
                for (int j = 0; j < dlugosc; j++)
                {
                    tablica[i][j] = elementy[dlugosc-1 - j];
                }                                
            }

            for (int i = 0; i < ilosc; i++)
            {
                for (int j = 0; j < tablica[i].Length; j++)
                {
                    Console.Write("{0}",tablica[i][j]);
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
