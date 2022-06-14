using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PQ_15
{
    public string solution(string s)
    {
        string answer = "";
        int len = s.Length;
        if(len % 2 == 0)
        {
            answer += s[len / 2 - 1];
            answer += s[len / 2];
        }
        else
        {
            answer += s[len/2];
        }
        return answer;
    }

    //public static void Main()
    //{
    //    PQ_15 solution = new PQ_15();
    //    string s = "qwer";
    //    string answer = solution.solution(s);
    //}
}
