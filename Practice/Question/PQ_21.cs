using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Question.PQ_21
{
    public class Solution
    {
        public int[] solution(int[] arr, int divisor)
        {
            List<int> answer = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % divisor == 0)
                {
                    answer.Add(arr[i]);
                }
            }
            if (answer.Count == 0) answer.Add(-1);
            answer.Sort();
            return answer.ToArray();
        }

        public static void Main1()
        {
            Solution solution = new Solution();
            int[] arr = { 5, 9, 7, 10 };
            int divisor = 5;
            int[] answer = solution.solution(arr, divisor);
            
            foreach (int i in answer)
            {
                Console.WriteLine(i);
            }
        }
    }
}
