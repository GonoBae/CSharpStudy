using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Question.PQ_22
{
    public class Node
    {
        public int _x { get; set; }
        public int _y { get; set; }
        public int _dis { get; set; }
        public Node(int x, int y, int dis)
        {
            _x = x;
            _y = y;
            _dis = dis;
        }
    }
    public class Solution
    {
        int[] dx = { -1, 1, 0, 0 };
        int[] dy = { 0, 0, -1, 1 };
        public bool bfs(int x, int y, string[] str)
        {
            bool[,] visited = new bool[5, 5];
            Queue<Node> q = new Queue<Node>();
            visited[x, y] = true;
            bool flag = true;

            q.Enqueue(new Node(x, y, 0));

            while(q.Count > 0)
            {
                Node now = q.Dequeue();
                if (now._dis >= 2) continue;

                for(int i = 0; i < 4; i++)
                {
                    int nx = now._x + dx[i];
                    int ny = now._y + dy[i];
                    int nDis = now._dis;

                    if(nx < 0 || ny < 0 || nx >= 5 || ny >= 5) continue;
                    if (visited[nx, ny]) continue;

                    if(str[nx][ny] == 'O')
                    {
                        q.Enqueue(new Node(nx, ny, nDis + 1));
                    }
                    else if(str[nx][ny] == 'P')
                    {
                        if(now._dis <= 2)
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                if (!flag) return false;
            }
            return true;
        }

        public int isArround(string[] str)
        {
            for (int j = 0; j < 5; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    if (str[j][k] == 'P')
                    {
                        if (!bfs(j, k, str)) return 0;
                    }
                }
            }
            return 1;
        }

        public int[] solution(string[,] places)
        {
            int[] answer = new int[5];
            
            for(int i = 0; i < 5; i++)
            {
                string[] place = new string[5];
                for(int j = 0; j < 5; j++)
                {
                    place[j] = places[i, j];
                }
            }
            return answer;
        }

        public static void Main()
        {
            Solution solution = new Solution();
            string[,] arr = { 
                { "POOOP", "OXXOX", "OPXPX", "OOXOX", "POXXP" },
                { "POOPX", "OXPXP", "PXXXO", "OXXXO", "OOOPP" },
                { "PXOPX", "OXOXP", "OXPOX", "OXXOP", "PXPOX" },
                { "OOOXX", "XOOOX", "OOOXX", "OXOOX", "OOOOO" },
                { "PXPXP", "XPXPX", "PXPXP", "XPXPX", "PXPXP" } 
            };
            int[] answer = solution.solution(arr);
            foreach(int i in answer)
            {
                Console.WriteLine(i);
            }
        }
    }
}