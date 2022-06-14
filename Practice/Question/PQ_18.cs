using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Question
{
    class PQ_18
    {
        public int solution(int[] a, int[] b)
        {
            int answer = 0;
            for(int i = 0; i < a.Length; i++)
            {
                answer += a[i] * b[i];
            }
            return answer;
        }

        public static void Main1()
        {
            PQ_18 pq = new PQ_18();
            int[] a = { 1, 2, 3, 4 };
            int[] b = { -3, -1, 0, 2 };
            pq.solution(a, b);
        }
    }
}
