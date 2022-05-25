using System;
public class PQ_3
{
    public string solution(string s)
    {
        string answer = "";
        string[] words = s.Split(' ');
        foreach (string word in words)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (i == 0 || i % 2 == 0)
                {
                    answer += word[i].ToString().ToUpper();
                }
                else
                {
                    answer += word[i].ToString().ToLower();
                }
            }
        }
        return answer;
    }

    public static void Main()
    {
        PQ_3 solution = new PQ_3();
        Console.WriteLine(solution.solution("try hello world"));
    }
}