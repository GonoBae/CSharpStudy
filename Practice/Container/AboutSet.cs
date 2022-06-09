using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class AboutSet
    {
        public static void Main()
        {
            SortedSet<int> iSet = new SortedSet<int>();
            iSet.Add(1);
            Console.WriteLine(iSet.Add(2));
        }
    }
}
