using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BFS
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
    public void bfs(int start)
    {
        bool[] found = new bool[6];
        Queue<int> Q = new Queue<int> ();
        Q.Enqueue(start);
        found[start] = true;

        while(Q.Count > 0)
        {
            int now = Q.Dequeue();
            Console.WriteLine(now);
            for(int next = 0; next < 6; next++)
            {
                if (adj[now, next] == 0 || found[next]) continue;

                Q.Enqueue(next);
                found[next] = true;
            }
        }
    }

    //public static void Main()
    //{
    //    BFS bfs = new BFS();
    //    bfs.bfs(0);
    //}
}