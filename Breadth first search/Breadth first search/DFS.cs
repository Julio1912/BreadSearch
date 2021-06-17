using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breadth_first_search
{
    class DFS
    {
        private int[,] Graph;
        private int[] Visited;
        public DFS(int[,] Graph) {
            this.Graph = Graph;
            this.Visited=new int[Graph.Length];
            for (int i = 0; i < Visited.Length; i++)
                Visited[i] = 0;
        }
        public void Algorithm(int root) {
            Console.WriteLine(root);
            Visited[root] = 1;
            for (int i = 0; i < Graph.GetLength(0);i++ ) {
                if (Graph[root, i] == 1) {
                    if (Visited[i] == 0) {
                        Algorithm(i);
                    }
                }
            }
        }
    }
}
