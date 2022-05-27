using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PQ_8
{
    public int solution(int[] d, int budget)
    {
        int answer = 0;
        Array.Sort(d);
        for (int i = 0; i < d.Length; i++)
        {
            if(d[i] <= budget)
            {
                budget -= d[i];
                answer++;
            }
        }
        return answer;
    }
}
