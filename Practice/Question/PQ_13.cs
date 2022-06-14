using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PQ_13
{
    public int[] solution(int[] prices)
    {
        int[] answer = new int[prices.Length];
        
        for(int i = 0; i < prices.Length; i++)
        {
            for(int j = i + 1; j < prices.Length; j++)
            {
                if (prices[i] <= prices[j]) answer[i]++;
                else
                {
                    answer[i]++;
                    break;
                }
            }
        }
        return answer;
    }

    //public static void Main()
    //{
    //    PQ_13 solution = new PQ_13();
    //    int[] prices = new int[] { 2, 3, 3, 3, 1 };
        
    //    int[] answer = solution.solution(prices);
    //    for (int i = 0; i < prices.Length; i++)
    //    {
    //        Console.WriteLine(answer[i]);
    //    }
    //}
}
