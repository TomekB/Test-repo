using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POTSAM___Samolot
{
    class Program
    {
        static void Main(string[] args)
        {
            string dane = Console.ReadLine();
            string[] wartosci = dane.Split(new char[] { ' ' });
            int n1, k1, n2, k2;
            n1 = int.Parse(wartosci[0]);
            k1 = int.Parse(wartosci[1]);
            n2 = int.Parse(wartosci[2]);
            k2 = int.Parse(wartosci[3]);
           
            int x1, x2;
            x1 = n1 * k1;
            x2 = n2 * k2;
           
            int y = x1 + x2;
            Console.WriteLine(y);

            Console.ReadKey();            
        }
    }
}
