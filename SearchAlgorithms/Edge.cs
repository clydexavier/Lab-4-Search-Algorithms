using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    
    public class Edge
    {
        public Vertex From;
        public Vertex To;
        public int Cost;
        public Edge(Vertex from, Vertex to, int cost)
        {
            this.From = from;
            this.To = to;
            this.Cost = cost;
        }

        public override string ToString()
        {
            return $"{From} -> {To} = {Cost}";
        }
    }
}
