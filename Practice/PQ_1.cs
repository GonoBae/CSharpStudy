using System;
using System.Collections.Generic;

public class PQ_1
{
    public int[] solution(string[] id_list, string[] report, int k)
    {
        int[] answer = new int[id_list.Length];

        // 신고한 사람 Key
        Dictionary<string, HashSet<string>> reportDic = new Dictionary<string, HashSet<string>>();
        // 신고당한 사람 Key
        Dictionary<string, HashSet<string>> resultDic = new Dictionary<string, HashSet<string>>();
        
        foreach(string s in report)
        {
            int pos = s.IndexOf(' ');
            string user = s.Substring(0, pos);
            string bad = s.Substring(pos + 1);
            if (reportDic.ContainsKey(user) == false)
                reportDic.Add(user, new HashSet<string>());

            if (resultDic.ContainsKey(bad) == false)
                resultDic.Add(bad, new HashSet<string>());
            reportDic[user].Add(bad);
            resultDic[bad].Add(user);
        }
        
        for (int i = 0; i < id_list.Length; ++i)
        {
            string user = id_list[i];
            if (!reportDic.ContainsKey(user)) continue;
            else
            {
                foreach (var bad in reportDic[user])
                {
                    if (resultDic[bad].Count >= k)
                        ++answer[i];
                }
            }
        }

        return answer;
    }
    public static void Main()
    {
        PQ_1 sol = new PQ_1();
        Dictionary<string, HashSet<string>> reportDic = new Dictionary<string, HashSet<string>>();
        Dictionary<string, HashSet<string>> resultDic = new Dictionary<string, HashSet<string>>();
        string[] id_list = { "muzi", "frodo", "apeach", "neo" };
        string[] report = { "muzi frodo", "apeach frodo", "frodo neo", "muzi neo", "apeach muzi" };
        sol.solution(id_list, report, 2);
    }
}