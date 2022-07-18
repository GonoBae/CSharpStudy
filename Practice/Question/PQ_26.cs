using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Question.PQ26
{
    public class Solution
    {
        public string solution(string s, int n)
        {
            string answer = "";
            int a = 0;
            char b = ' ';
            foreach (var item in s)
            {
                a = Convert.ToInt32(item);
                // 대문자
                if (a >= 65 && a <= 90)
                {
                    if (a + n - 26 >= 65)
                    {
                        b = Convert.ToChar(a + n - 26);
                    }
                    else b = Convert.ToChar(a + n);
                }
                // 소문자
                else if (a >= 97 && a <= 122)
                {
                    if (a + n - 26 >= 97)
                    {
                        b = Convert.ToChar(a + n - 26);
                    }
                    else b = Convert.ToChar(a + n);
                }
                else if (a == 32) b = ' ';
                answer += b;
            }
            return answer;
        }

        public static void Main1()
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution("a B z", 4));
        }
    }
}
