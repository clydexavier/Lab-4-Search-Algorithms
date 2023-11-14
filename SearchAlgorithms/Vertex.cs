using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public class Vertex
    {
        public char ID ;
        public int IDX;
        public Point Location;
        public int AccumulatedWeight;
        public double Heuristic;
        public List<Vertex> Ancestors = new List<Vertex>();
        
        /* Current Queue: 
         * Paths with cost
         * Queue Size 
         * Elements Inside Queue
         */
        public string Logs;
        public Vertex(char id,int idx, Point location)
        {
            this.Location = location;
            this.ID = id;
            this.IDX = idx;
            this.AccumulatedWeight= 0;
            this.Heuristic = 0;
            this.Logs = "";
        }

        public Vertex(Vertex v)
        {
            this.Location=v.Location;
            this.ID = v.ID;
            this.IDX = v.IDX;
        }
        public override string ToString()
        {
            return this.ID.ToString();
        }

        public bool Has(Vertex v)
        {
            if(Ancestors.Count== 0) return false;
            foreach (Vertex a in Ancestors) 
            {
                if(a.ID == v.ID) return true;
            }
            return false;
        }
        public override bool Equals(object? obj)
        {
            return (obj is Vertex a && a.ID == this.ID);
        }
        
       
    }
}
