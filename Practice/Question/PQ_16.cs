using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PQ_16
{
    public string solution(string s)
    {
        string answer = "";
        char[] c = s.ToCharArray().OrderByDescending(x => x).ToArray();
        answer = new string(c);
        return answer;
    }

    //public static void Main()
    //{
    //    PQ_16 solution = new PQ_16();
    //    string s = "Zbcdefg";
    //    Console.WriteLine(solution.solution(s));
    //}
}
