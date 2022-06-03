using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PQ14
{
    public int solution(string skill, string[] skill_trees)
    {
        int answer = 0;

        for(int i = 0; i < skill_trees.Length; i++)
        {
            bool flag = true;
            char[] skills = skill_trees[i].ToCharArray();
            int cnt = 0;

            for(int j = 0; j < skills.Length; j++)
            {
                if(cnt < skill.IndexOf(skills[j]))
                {
                    flag = false;
                    break;
                }
                else if(cnt == skill.IndexOf(skills[j]))
                {
                    cnt++;
                }
            }
            if(flag)
                answer++;
        }


        return answer;
    }

    //public static void Main()
    //{
    //    PQ14 pq14 = new PQ14();

    //    string skill = "CBD";
    //    string[] skill_trees = new string[] { "BACDE", "CBADF", "AECB", "BDA" };

    //    pq14.solution(skill, skill_trees);
    //}
}
