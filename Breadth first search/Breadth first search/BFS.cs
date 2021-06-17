using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breadth_first_search
{
    class BFS
    {
        private int[] Visited;
        private int [,] Graph;
        private int node;
        public BFS(int [,] Graph,int node) {
            this.Graph = Graph;
            Visited = new int [Graph.GetLength(0)];
            for (int i = 0; i < Visited.Length; i++)
                Visited[i] = 0 ;
            this.node = node;
            Visited[node] = 1 ;
            Console.WriteLine(node);
        }
        public void Algorithm() {
            List<int> List = new List<int>();
            List = GetAdjacent(this.node);
            for (int i = 0; i < List.Count;i++ ) 
            {
                List<int> Adjacent = new List<int>();
                Adjacent = GetAdjacent(List.ElementAt(i));
                List.AddRange(Adjacent);
                List.Remove(i);
            }
        }
        public List<int> GetAdjacent(int Adjnode) {
            List<int> Adjacent = new List<int>();
            for (int i = 0; i < Graph.GetLength(0); i++) {
                if (Graph[Adjnode, i] == 1) {
                    if (Visited[i] == 0) 
                    {
                        Adjacent.Add(i);
                        Visited[i] = 1;
                        Console.WriteLine(i);
                    }
                }
            }
            return Adjacent;
        }
    }
}
