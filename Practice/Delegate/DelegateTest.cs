using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ETC.DelegateTest
{
    delegate int Dele(int a, int b);
    class DelegateTest
    {
        static int Plus(int a, int b)
        {
            return a + b;
        }

        static void Main1()
        {
            Dele dele1 = Plus;
            Dele dele2 = delegate (int a, int b)
            {
                return a / b;
            };

            Console.WriteLine(dele1(4, 10));
            Console.WriteLine(dele2(14, 5));
        }
    }
}
