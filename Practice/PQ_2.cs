using System;
using System.Collections.Generic;

public class PQ_2
{
    public int solution(int n, int[] lost, int[] reserve)
    {
        int answer = 0;
        bool[] check = new bool[reserve.Length];
        int student = 0;
        Array.Sort(lost);
        Array.Sort(reserve);
        foreach (int l in lost)
        {
            foreach (int r in reserve)
            {
                if (l == r)
                {
                    lost = lost.Where(x => x != l).ToArray();
                    reserve = reserve.Where(x => x != r).ToArray();
                    break;
                }
            }
        }

        // n = 전체 학생 수, lost = 도난당한 학생 번호, reserve = 체육복을 가져온 학생들의 번호
        for (int i = 0; i < lost.Length; ++i)
        {
            for (int j = 0; j < reserve.Length; ++j)
            {
                if ((Math.Abs(lost[i] - reserve[j]) <= 1) && !check[j])
                {
                    check[j] = true;
                    ++student;
                    break;
                }
            }
        }
        // Math.Abs(lost[i] - reserve[j]) <= 1)  && (check[j] == false)
        answer = n - lost.Length + student;
        return answer;
    }

    //public static void Main()
    //{
    //    PQ_2 solution = new PQ_2();
    //    int n = 5;
    //    int[] re = new int[3] { 3, 1, 2 };
    //    int[] lost = new int[2] { 3, 2 };
    //    Console.WriteLine(solution.solution(n, lost, re));
    //}
}