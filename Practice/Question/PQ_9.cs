using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PQ_9
{
    public int[] solution(int[] numbers)
    {
        int[] answer = new int[] { };
        List<int> list = new List<int>();
        for(int i = 0; i < numbers.Length - 1; i++)
        {
            for(int j = i + 1; j < numbers.Length; j++)
            {
                list.Add(numbers[i] + numbers[j]);
            }
        }
        answer = list.OrderBy(x => x).ToArray();
        answer = answer.Distinct().ToArray();
        return answer;
    }
    //public static void Main()
    //{
    //    PQ_9 solution = new PQ_9();
    //    int[] numbers = new int[] { 2, 1, 3, 4, 1 };
    //    solution.solution(numbers);
    //}
}
