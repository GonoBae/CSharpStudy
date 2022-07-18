using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Question.PQ_27
{
    public class Solution
    {
        public bool solution(int x)
        {
            bool answer = true;
            int a = 0, b = x, sum = 0;
            while (b != 0)
            {
                a = b % 10;
                b /= 10;
                sum += a;
            }
            if (x % sum == 0) answer = true;
            else answer = false;
            return answer;
        }

        public static void Main1()
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(10));
        }
    }
}
