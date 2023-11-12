using Microsoft.VisualBasic.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace SearchAlgorithms
{
    public class Graph
    {
        public IDictionary<Vertex, ICollection<Edge>> adjacencyList;
        public int[,]? Matrix;

        public string BFS_description = "";
        public string DFS_description = "";
        public Graph() 
        { 
            this.adjacencyList = new Dictionary<Vertex, ICollection<Edge>>();
        }

        public void initMtx(int dimensions)
        {
            Matrix = new int[dimensions,dimensions];
            for(int i = 0; i < dimensions; i++)
            {
                for(int j = 0; j < dimensions; j++)
                {
                    if (i == j) Matrix[i, j] = 0;
                    else Matrix[i, j] = -1; 
                }
            }
        }
        public void updateMtx (List<Edge> edges) 
        {
            foreach(Edge e in edges) 
            {
                Matrix[e.From.IDX, e.To.IDX] = e.Cost;
                Matrix[e.To.IDX, e.From.IDX] = e.Cost;
            }
        }

        



        public void AddVertex(Vertex vertex)
        {
            Validate(() => !adjacencyList.ContainsKey(vertex));

            adjacencyList.Add(vertex, new List<Edge>());
        }

        public void AddEdge(Vertex from, Vertex to, int cost)
        {
            Validate(() => adjacencyList.ContainsKey(from));
            Validate(() => adjacencyList.ContainsKey(to));

            var srcEdge = new Edge(from, to, cost);
            var destEdge = new Edge(to, from, cost);

            adjacencyList[from].Add(srcEdge);
            adjacencyList[to].Add(destEdge);
        }

        private void Validate(Func<bool> condition)
        {
            if (!condition())
                throw new InvalidOperationException();
        }
    }
}
