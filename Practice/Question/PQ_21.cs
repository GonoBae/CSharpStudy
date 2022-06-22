using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프린터 => Queue 를 이용

namespace Practice.Question.PQ_21
{
    public class Solution
    {
        public int solution(int[] priorities, int location)
        {
            int answer = 0;
            Queue<KeyValuePair<int, int>> q = new Queue<KeyValuePair<int, int>>();
            
            for(int i = 0; i < priorities.Length; i++)
            {
                q.Enqueue(new KeyValuePair<int, int>(i, priorities[i]));
            }
            while (true)
            {
                int max = q.Max(x => x.Value);
                KeyValuePair<int, int> first = q.Dequeue();
                if (max == first.Value)
                {
                    if (first.Key == location) return answer + 1;
                    else
                    {
                        answer++;
                        continue;
                    }
                }
                q.Enqueue(first);
            }
        }

        public static void Main1()
        {
            Solution solution = new Solution();
            int[] priorites = { 1, 2, 3, 2, 3 };
            int location = 3;
            int answer = solution.solution(priorites, location);
            Console.WriteLine(answer);
        }
    }
}
