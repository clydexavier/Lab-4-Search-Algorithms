using System;
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

    }
   
}
