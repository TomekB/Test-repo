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
            string[] tablica = new string[ilosc]; 
            
            for (int i = 0; i < ilosc; i++)
            {
                
                string ciag = Console.ReadLine();
                string [] elementy = ciag.Split(new char[] { ' ' });
                int d³ugosc = int.Parse(elementy[0]);
                string[] newelementy = new string[d³ugosc];
                for (int j = 0; j < d³ugosc; j++)
                {                    
                    newelementy[j] = elementy[j+1]; 
                }
                Array.Reverse(newelementy);
                tablica[i] = String.Join(" ",newelementy);
            }

            foreach (string i in tablica)
            {
                Console.WriteLine(i);
            }


            Console.ReadKey();
        }
    }
}
