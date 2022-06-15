using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Question.PQ_20
{
    class PQ_20
    {
        public int solution(int left, int right)
        {
            int answer = 0;
            int num = 0;
            for(int i = left; i <= right; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        num++;
                    }
                }

                if (num % 2 != 0)
                {
                    answer -= i;
                }
                else
                    answer += i;
                num = 0;
            }
            return answer;
        }

        public static void Main()
        {
            PQ_20 solution = new PQ_20();
            Console.WriteLine(solution.solution(13, 17));
        }
    }
}
