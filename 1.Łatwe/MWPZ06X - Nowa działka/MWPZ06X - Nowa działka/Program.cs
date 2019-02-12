using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWPZ06X___Nowa_działka
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilosc = int.Parse(Console.ReadLine());
            int[] kroki = new int[ilosc];
            for (int i = 0; i < ilosc; i++)
            {
                int x = int.Parse(Console.ReadLine());
                kroki[i] = x * x;
            }
            foreach (int i in kroki)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
