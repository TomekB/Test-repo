using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTROL___ROL
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilosc = int.Parse(Console.ReadLine());
            string[] wiersze = new string[ilosc];
            for (int i = 0; i < ilosc; i++ )
            {
                string dane = Console.ReadLine();
                string[] elementy = dane.Split(new char[] {' '});
                int dlugosc = elementy.Length-1;
                string[] nowelementy = new string[dlugosc];
                for (int j =0; j < dlugosc; j++)
                {
                    if (j == (dlugosc-1))
                    {
                        nowelementy[j] = elementy[1];
                        
                    }
                    else
                    {
                        nowelementy[j] = elementy[j + 2];
                        
                    }
                }
                wiersze[i] = string.Join(" ",nowelementy);
                

            }
            foreach (string i in wiersze)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
