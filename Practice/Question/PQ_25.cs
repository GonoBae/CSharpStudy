using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Question.PQ_25
{
    public class Solution
    {
        public long[] solution(int x, int n)
        {
            long[] answer = new long[n];
            for (long i = 1; i <= n; i++)
            {
                answer[i - 1] = (x * i);
            }
            return answer;
        }

        public static void Main1()
        {
            Solution so = new Solution();
            long[] answer = so.solution(2, 5);
            foreach(var x in answer)
            {
                Console.WriteLine(x);
            }
        }
    }
}
