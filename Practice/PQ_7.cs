using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PQ_7
{
    public int[,] solution(int[,] arr1, int[,] arr2)
    {
        int[,] answer = new int[arr1.GetLength(0),arr1.GetLength(1)];
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                answer[i, j] = arr1[i, j] + arr2[i, j];
            }
        }
        return answer;
    }

    //public static void Main()
    //{
    //    PQ_7 solution = new PQ_7();
    //    int[,] arr1 = new int[,] { { 1, 2 }, { 2, 3 } };
    //    int[,] arr2 = new int[,] { { 3, 4 }, { 5, 6 } };
    //    int[,] answer = solution.solution(arr1 , arr2);
    //    for (int i = 0; i < arr1.GetLength(0); i++)
    //    {
    //        for(int j = 0; j < arr1.GetLength(1); j++)
    //        {
    //            Console.Write(answer[i, j]);
    //        }
    //        Console.WriteLine();
    //    }
    //}
}