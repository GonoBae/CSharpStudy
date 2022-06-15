using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Question
{
    class PQ_19
    {
        int Solution(string _str)
        {
            int count = 0;
            count = _str.Split(' ').Length;
            return count;
        }
        public static void Main()
        {
            PQ_19 p = new PQ_19();
            p.Solution("std std std");
        }
    }
}
