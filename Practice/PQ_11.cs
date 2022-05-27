using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PQ_11
{
    public string solution(int a, int b)
    {
        //string[] day = new string[] { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU" };
        //int[] month = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        //string answer = "";
        //int cnt = 0;
        //// ( a - 1 ) * 30 + b
        //for(int i = 0; i < a - 1; i++)
        //{
        //    cnt += month[i];
        //}
        //cnt += b;
        //cnt %= 7;
        //cnt--;
        //if (cnt == -1) cnt = 6;
        //answer = day[cnt];
        //return answer;

        string answer = "";
        DateTime date = new DateTime(2016, a, b);
        answer = date.DayOfWeek.ToString().Substring(0, 3).ToUpper();
        return answer;
    }

    //public static void Main()
    //{
    //    PQ_11 pQ_11 = new PQ_11();
    //    pQ_11.solution(5, 24);
    //}
}
