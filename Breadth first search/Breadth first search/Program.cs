using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breadth_first_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] Graph = {
                              {0,1,1,0,0,0,0,0},
                              {1,0,0,1,1,0,0,0},
                              {1,0,0,0,0,1,1,0},
                              {0,1,0,0,0,0,0,1},
                              {0,1,0,0,0,0,0,1},
                              {0,0,1,0,0,0,0,1},
                              {0,0,1,0,0,0,0,1},
                              {0,0,0,1,1,1,1,0}
                              };
            BFS bfs = new BFS(Graph,1);
            bfs.Algorithm();
            Console.ReadLine();
            DFS dfs = new DFS(Graph);
            dfs.Algorithm(1);
            Console.ReadLine();
        }
    }
}
