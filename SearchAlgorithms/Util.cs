using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public  class Util
    {
        public static double distance(Vertex A, Vertex B)
        {
            int x1  = A.Location.X;
            int y1 = A.Location.Y;
            int x2 = B.Location.X;
            int y2 = B.Location.Y;

            // calculates the distance between two points
            // used when finding heuristic of Vertex A to Vertex Goal
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            
            // Normalize heuristic since distance is measured by pixels
            // It is too big compared to the weights
            return distance;
        }
        
        public static string LogDFS(Vertex a, List<Edge> neighbors, List<Vertex> pathElements, Stack<Vertex> stack)
        {

            /*  Current Queue: 
                 * Paths with cost
                 * Queue Size 
                 * Elements Inside Queue
                 * Path Elements
                 */
            string res = "";
            res += ($"Current Vertex:\t{a.ID}\n");
            res += ($"Neighbors:\n");
            foreach(Edge e in neighbors) 
            {
                res +=  "\t"+ e.ToString() + "\n";
            }
            res += ($"Stack Size:\t{stack.Count}\n");
            Stack<Vertex> temp = new Stack<Vertex>(stack);
            res += ($"Stack elements:\t");

            foreach (Vertex v in temp)
            {
                res += (v.ID) + " ";
            }
            res += "\n";
            res += $"Path Elemnets:\t";
            
            pathElements.Reverse();
            foreach (Vertex v in pathElements)
            {
                res += (v.ID) + " -> " ;
            }
            res += $"{a.ID}";

            res += "\n\n";
            return res;
        }

        public static string LogBFS(Vertex a, List<Edge> neighbors, List<Vertex> pathElements, Queue<Vertex> queue)
        {

            /*  Current Queue: 
                 * Paths with cost
                 * Queue Size 
                 * Elements Inside Queue
                 * Path Elements
                 */
            string res = "";
            res += ($"Current Vertex:\t{a.ID}\n");
            res += ($"Neighbors:\n");
            foreach (Edge e in neighbors)
            {
                res += "\t" + e.ToString() + "\n";
            }
            res += ($"Queue Size:\t{queue.Count}\n");
            Queue<Vertex> temp = new Queue<Vertex>(queue);
            res += ($"Queue elements:\t");

            foreach (Vertex v in temp)
            {
                res += (v.ID) + " ";
            }
            res += "\n";
            res += $"Path Elemnets:\t";

            pathElements.Reverse();
            foreach (Vertex v in pathElements)
            {
                res += (v.ID) + " -> ";
            }
            res += $"{a.ID}";

            res += "\n\n";
            return res;
        }

        public static string LogBNB(Vertex a, List<Edge> neighbors, List<Vertex> pathElements, List<Vertex> queue)
        {
            string res = "";
            res += ($"Current Vertex: {a.ID}\n");
            res += ($"Accumulated Weight: {a.AccumulatedWeight}\n");
            res += ($"Neighbor's Accumulated Weight\n");
            foreach (Edge e in neighbors)
            {
                res +=  "\t" + e.From.ID +" -> "+ e.To.ID +" = " + e.To.AccumulatedWeight.ToString() +"\n";
            }
            res += ($"Priority Queue Size: {queue.Count}.\n");
            List<Vertex> temp = new List<Vertex>(queue);
            res += ($"Priority Queue elements:\t");
            foreach (Vertex v in temp)
            {
                res += ($"{v.ID} -> {v.AccumulatedWeight}, ");
            }
            res += "\n";
            
            res += $"Path Elemnets:\t";
            pathElements.Reverse();
            foreach (Vertex v in pathElements)
            {
                res += (v.ID) + " -> ";
            }
            res += $"{a.ID}";

            res += "\n\n";
            return res;
        }

        public static string LogBeam(Vertex a, List<Edge> neighbors, List<Vertex> pathElements, List<Vertex> queue, int w)
        {
            string res = "";
            res += $"W =\t{w}\n";
            res += ($"Current Vertex:\t{a.ID}\n");
            res += ($"Neighbor Heuristic\n");
            foreach (Edge e in neighbors)
            {
                res += "\t"+e.To.ToString() + " -> " +e.To.Heuristic.ToString("0.00") + "\n";
            }
           
            res += ($"Priority Queue Size:\t{queue.Count}\n");
            List<Vertex> temp = new List<Vertex>(queue);
            res += ($"Priority Queue elements:\t");
            foreach (Vertex v in temp)
            {
                res += ($"{v.ID} -> {v.Heuristic.ToString("0.00")}, ");
            }
            res += "\n"; 
            res += $"Path Elemnets:\t";
            pathElements.Reverse();
            foreach (Vertex v in pathElements)
            {
                res += (v.ID) + " -> ";
            }
            res += $"{a.ID}";

            res += "\n\n";
            return res;
        }

        public static string LogAStar(Vertex a, List<Edge> neighbors, List<Vertex> pathElements, List<Vertex> queue)
        {


        }
    }
   
}
