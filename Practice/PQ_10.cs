using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PQ_10
{
    public long solution(long n)
    {
        long answer = 0;
        //long min = 10;
        //List<int> list = new List<int>();
        //while(true)
        //{
        //    if (n == 0) break;
        //    int a = (int)(n % min);
        //    n /= min;
        //    list.Add(a);
        //}
        //list = list.OrderByDescending(x => x).ToList();
        //int ix = 0;
        //while(true)
        //{
        //    if(ix == list.Count || list[ix] == 0) break;
            
        //    answer += list[ix] * (long)Math.Pow(10, (list.Count - ix - 1));
            
        //    ix++;
        //}

        char[] cArr = n.ToString().ToCharArray();
        Array.Sort(cArr);
        Array.Reverse(cArr);
        answer = long.Parse(new String(cArr));

        return answer;
    }
    //public static void Main()
    //{
    //    PQ_10 solution = new PQ_10();
    //    Console.WriteLine(solution.solution(7233909059));
    //}
}
