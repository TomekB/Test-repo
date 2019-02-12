using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KC001___Dodawanie_liczb_całkowitych
{
    class Program
    {
        static void Main(string[] args)
        {
            //wczytanie 3 liczb
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            int sum = x + y + z;
            //wypisanie sumy
            Console.WriteLine(sum);
            Console.ReadKey();

            
        }
    }
}
