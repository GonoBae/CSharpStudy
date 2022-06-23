using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Question.PQ_23
{
    public class Solution
    {
        public int solution(string name)
        {
            int answer = 0;
            int n = name.Length;
            int leftOrRight = name.Length - 1;
            for(int i = 0; i < n; i++)
            {
                int next = i + 1;
                char target = name[i];
                if (target <= 'N') answer += target - 'A';
                else answer += 'Z' - target + 1;

                while (next < n && name[next] == 'A') next++;
                leftOrRight = Math.Min(leftOrRight, i + n - next + Math.Min(i, n - next));
            }
            answer += leftOrRight;
            return answer;
        }

        public static void Main1()
        {
            Solution solution = new Solution();
            string str = "BBAAABAAAAAAAAAAAABA";
            int num = solution.solution(str);
            Console.WriteLine(num);
        }
    }
}
