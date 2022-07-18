using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Question.PQ_28
{
    class Solution
    {
        public int solution(int N, int[,] road, int K)
        {
            var dict = new Dictionary<int, int>();
            dfs(road, 1, dict, K);
            return dict.Count;
        }

        private void dfs(int[,] road, int start, Dictionary<int, int> dict, int capa)
        {
            if (dict.TryGetValue(start, out var result))
            {
                if (result < capa)
                    dict[start] = capa;
                else
                    return;
            }
            else
                dict.Add(start, capa);

            for(int i = 0; i < road.GetLength(0); i++)
            {
                int next = 0;
                if (road[i, 0].Equals(start))
                    next = road[i, 1];
                else if (road[i, 1].Equals(start))
                    next = road[i, 0];
                else continue;

                capa -= road[i, 2];

                if(capa >= 0) dfs(road, next, dict, capa);

                capa += road[i, 2];
            }
        }

        public static void Main()
        {
            Solution solution = new Solution();
            int N = 5;
            int[,] road = { { 1, 2, 1 }, { 2, 3, 3 }, { 5, 2, 2 }, { 1, 4, 2 }, { 5, 3, 1 }, { 5, 4, 2 } };
            int K = 3;
            solution.solution(N, road, K);
    }
    }
}
