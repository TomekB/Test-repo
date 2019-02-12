using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDCOFTI__NWD_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string wers1 = Console.ReadLine();
            string wers2 = Console.ReadLine();
            string wers3 = Console.ReadLine();
            UInt64 a = Convert.ToUInt64(wers1);
            UInt64 b = Convert.ToUInt64(wers2);
            UInt64 c = Convert.ToUInt64(wers3);
            ulong[] wartosci = { a, b, c, };
            {
                while((a !=b)||(a !=b)||(b!= c))
                {
                    if ((a>b)&&(b>c))
                    {
                        
                    }


                }
                Console.WriteLine(a);
                Console.ReadKey();
            }
        }
    }
}
