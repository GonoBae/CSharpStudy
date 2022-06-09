using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PQ_17
{
    // 행과 열을 잘 구분하자.


    static string[,] places = new string[,] {
            { "POOOP", "OXXOX", "OPXPX", "OOXOX", "POXXP" },
            { "POOPX", "OXPXP", "PXXXO", "OXXXO", "OOOPP" },
            { "PXOPX", "OXOXP", "OXPOX", "OXXOP", "PXPOX" },
            { "OOOXX", "XOOOX", "OOOXX", "OXOOX", "OOOOO" },
            { "PXPXP", "XPXPX", "PXPXP", "XPXPX", "PXPXP" }
        };

    int[] dx = new int[4] { -1, 1, 0, 0 };
    int[] dy = new int[4] { 0, 0, -1, 1 };
    int[,] position = new int[,] { { } };

    //void Bfs(string[] place)
    //{
    //    bool[,] visited = new bool[5, 5];
    //    Queue<(int, int)> Q = new Queue<(int, int)> ();
    //    Q.Enqueue()

    //}

    public int[] solution(string[,] places)
    {
        int[] answer = new int[] { };
        
        foreach (var place in places)
        {
            char[] c = place.ToCharArray();
            for(int i = 0; i < c.Length; i++)
            {
                if(c[i] == 'P')
                {
                    
                }
            }
        }

        return answer;
    }

    //public static void Main()
    //{
    //    PQ_17 solution = new PQ_17();

    //    solution.solution(places);
    //}
}
