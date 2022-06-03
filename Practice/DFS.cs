using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DFS
{
    int[,] adj = new int[6, 6]
    {
        {0, 1, 0, 1, 0, 0 }, // 0 : 1 , 3
        {1, 0, 1, 1, 0, 0 }, // 1 : 0 , 2 , 3
        {0, 1, 0, 0, 0, 0 }, // 2 : 1
        {1, 1, 0, 0, 1, 0 }, // 3 : 0 , 1 , 4
        {0, 0, 0, 1, 0, 1 }, // 4 : 3 , 5
        {0, 0, 0, 0, 1, 0 }, // 5 : 4
    };

    bool[] visited = new bool[6];
    public void dfs(int start)
    {
        Console.WriteLine(start);
        visited[start] = true;
        for(int next = 0; next < adj.GetLength(0); next++)
        {
            if (adj[start, next] == 0 || visited[next]) continue;
            dfs(next);
        }
    }

    //public static void Main()
    //{
    //    DFS dfs = new DFS();
    //    dfs.dfs(0);
    //}
}
