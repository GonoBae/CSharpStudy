using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public static string solution(int[] numbers)
    {
        string answer = "";
        Array.Sort(numbers, new Comparer());
        
        answer = string.Join("", numbers);
        
        return answer;
    }

    //public static void Main()
    //{
    //    int[] numbers = new int[] { 6, 10, 2, 90 };
    //    string str = solution(numbers);
    //    Console.WriteLine(str);
    //}
}

public class Comparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        string sx = x.ToString();
        string sy = y.ToString();

        string compareX = sx + sy;
        string compareY = sy + sx;

        return Convert.ToInt32(compareY) - Convert.ToInt32(compareX);
    }
}
