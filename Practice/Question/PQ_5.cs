using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PQ_5
{
    public string solution(string phone_number)
    {
        //string answer = "";
        //for (int i = 0; i < phone_number.Length; i++)
        //{
        //    if (i > phone_number.Length - 5)
        //    {
        //        answer += phone_number[i];
        //    }
        //    else
        //    {
        //        answer += "*";
        //    }
        //}
        //return answer;


        // Substring : Length - 4 부터 끝까지
        // PadLeft : 길이만큼 * 로 채운다.
        return phone_number.Substring(phone_number.Length - 4).PadRight(phone_number.Length, '*');
    }
    //public static void Main()
    //{
    //    PQ_5 solution = new PQ_5();
    //    string num = "01094802927";
    //    Console.WriteLine(solution.solution(num));
    //}
}
//return phone_number.Substring(phone_number.Length - 4).PadLeft(phone_number.Length, '*');