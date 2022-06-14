using System;
using System.Collections.Generic;
using System.Linq;

public class PQ_4
{
    public int[] solution(int[] array, int[,] commands)
    {
        //int[] answer = new int[] { };
        //List<int> lstAnswer = new List<int>();
        //List<int> list = new List<int>();
        //for (int i = 0; i < commands.GetLength(0); i++)
        //{
        //    for (int j = commands[i, 0] - 1; j <= commands[i, 1] - 1; j++)
        //    {
        //        list.Add(array[j]);
        //    }
        //    if(list.Count != 0)
        //    {
        //        list = list.OrderBy(x => x).ToList();
        //    }
        //    lstAnswer.Add(list[commands[i, 2] - 1]);
        //    list.Clear();
        //}
        //answer = lstAnswer.ToArray();
        //return answer;

        int[] answer = new int[commands.GetLength(0)];
        List<int> lst = new List<int>(array);
        for(int i = 0; i < commands.GetLength(0); i++)
        {
            int nStart = commands[i, 0];
            int nEnd = commands[i, 1];
            int nIndex = commands[i, 2];
            List<int> lstSub = lst.Where((x, idx) => idx >= nStart - 1 && idx < nEnd).OrderBy(x => x).ToList();
            answer[i] = lstSub[nIndex - 1];
        }
        return answer;
    }

    //public static void Main()
    //{
    //    PQ_4 solution = new PQ_4();
    //    int[] array = new int[] { 1, 5, 2, 6, 3, 7, 4 };
    //    int[,] commands = new int[,] { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
    //    int[] answer = solution.solution(array, commands);
    //    for(int i = 0; i < answer.Length; i++)
    //    {
    //        Console.Write(answer[i]);
    //    }
    //}
}