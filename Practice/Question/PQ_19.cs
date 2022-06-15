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
            string[] word = _str.Split(' ');
            int count = word.Length;

            if (word[0] == "") count--;
            if(word[word.Length - 1] == "") count--;
            return count;
        }
        public static void Main1()
        {
            PQ_19 p = new PQ_19();
            Console.WriteLine(p.Solution(" std std std sds"));
        }
    }
}
