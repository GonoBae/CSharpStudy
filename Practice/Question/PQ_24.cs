using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Question.PQ_24
{
    public class Solution
    {
        public int solution(int[,] sizes)
        {
            int answer = 0;
            int xMax = 0, yMax = 0;
            
            for(int i = 0; i < sizes.GetLength(0); i++)
            {
                if (sizes[i, 0] < sizes[i, 1])
                {
                    int temp = sizes[i, 0];
                    sizes[i, 0] = sizes[i, 1];
                    sizes[i, 1] = temp;
                }    

                if(xMax < sizes[i, 0])
                {
                    xMax = sizes[i, 0];
                }
                
                if(yMax < sizes[i, 1])
                {
                    yMax = sizes[i, 1];
                }
            }

            answer = xMax * yMax;
            return answer;
        }

        public static void Main()
        {
            Solution solution = new Solution();
            int[,] sizes = { { 60, 50 }, { 30, 70 }, { 60, 30 }, { 80, 40 } };
            int[,] sizes1 = { { 10, 7 }, { 12, 3 }, { 8, 15 }, { 14, 7 }, { 5, 15 } };
            int[,] sizes2 = { { 14, 4 }, { 19, 6 }, { 6, 16 }, { 18, 7 }, { 7, 11 } };
            int n = solution.solution(sizes2);
            Console.WriteLine(n);
        }
    }
}
