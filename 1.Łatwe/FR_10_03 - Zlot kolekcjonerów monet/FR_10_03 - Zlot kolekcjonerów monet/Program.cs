using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR_10_03___Zlot_kolekcjonerów_monet
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilosc = int.Parse(Console.ReadLine());
            string w1 = Console.ReadLine();
            string w2 = Console.ReadLine();
            string[] odda = w1.Split(new char[] { ' ' });
            string[] chce = w2.Split(new char[] { ' ' });

            
            for (int moneta = 0;  moneta<ilosc;)
            {
                
                if (chce.Contains(odda[moneta]))
                {
                    if (moneta == (ilosc-1))
                    {
                        Console.WriteLine("TAK");
                        break;
                    }
                    else
                    {
                        moneta++;
                    }
                }
                else
                {
                    Console.WriteLine("NIE");
                    break;
                }
            }
            Console.ReadKey();
        }   
    }
}
