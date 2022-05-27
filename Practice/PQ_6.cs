using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PQ_6
{
    public string[] solution(string[] strings, int n)
    {
        string[] answer = new string[] { };
        Array.Sort(strings, (str1, str2) =>
        {
            string word1 = str1.Substring(n, 1);
            string word2 = str2.Substring(n, 1);

            if(word1.Equals(word2))
            {
                return str1.CompareTo(str2);
            }
            else
            {
                return word1.CompareTo(word2);
            }
        });
        answer = strings;
        //string[] answer = strings.OrderBy(word => word[n]).ThenBy(s => s).ToArray();
        //string[] answer = strings.OrderBy(x => x).OrderBy(word => word[n]).ToArray();
        return answer;
    }

    //public static void Main()
    //{
    //    PQ_6 solution = new PQ_6();
    //    string[] strings = new string[] { "sun", "bed", "car" };
    //    string[] answer = solution.solution(strings, 1);
    //    foreach (string s in answer)
    //    {
    //        Console.WriteLine(s);
    //    }
    //}
}
