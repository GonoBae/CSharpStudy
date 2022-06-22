using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 3진법 뒤집기

namespace Practice.Question.Q_22
{
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
            List<int> list = new List<int>();
            while(n > 0)
            {
                int num = n % 3;
                list.Add(num);
                n /= 3;
            }
            list.Reverse();
            for(int i = 0; i < list.Count; i++)
            {
                answer += (int)(list[i] * Math.Pow(3, i));
            }
            return answer;
        }
        public static void Main1()
        {
            Solution solution = new Solution();
            int answer = solution.solution(125);
            Console.WriteLine(answer);
        }
    }
}
