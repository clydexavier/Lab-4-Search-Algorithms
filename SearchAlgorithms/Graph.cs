using Microsoft.VisualBasic.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace SearchAlgorithms
{
    public class Graph
    {
        //Adjacency Matrix of the graph
        public int[,]? Matrix;
        
        public Graph() 
        { 
        }

        
        public void initMtx(int dimensions)
        {
            /*
             * Initialized the adjacency matrix 
             * Dimensions = number of vertices
             * Weight = 0 if self 
             * Weight = -1 if not connected
             */
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
            // Update the matrix for each edge in edges
            foreach(Edge e in edges) 
            {
                // Undirected graph
                Matrix[e.From.IDX, e.To.IDX] = e.Cost;
                Matrix[e.To.IDX, e.From.IDX] = e.Cost;
            }
        }
        public List<Vertex> DFS_order(List<Vertex> vertices, Vertex start, Vertex search, int dimension)
        {
            /*
             * THIS FUNCTION RETURNS A List<Vertex> WHICH CORRESPONDS TO THE PATH
             * FROM STARTING VERTEX UP TO THE SEARCHED INDEX USING DFS
             */
            List<Vertex> order = new List<Vertex>();
            Stack<Vertex> stack = new Stack<Vertex>();

            stack.Push(start);
            order.Add(start);
            while (stack.Count > 0)
            {
                Vertex curr = stack.Pop();
                List<Edge> Neighbors = new List<Edge>();
                List<Vertex> PathElements = new List<Vertex>();
                order.Add(curr);


                // If vertex being popped is the vertex being searched
                if (curr.Equals(search))
                {
                    curr.Logs = Util.LogDFS(curr, Neighbors, curr.Ancestors, stack);
                    curr.Logs += "\nFOUND SEARCHED VERTEX!!!";
                    return order;
                }
                for (int i = 0; i < dimension; i++)
                {
                    // Check all the neighbor vertex
                    // Also check each neighbor if it is an ancestor the the
                    // current vertex
                    if (Matrix[curr.IDX, i] > 0 && !curr.Has(vertices[i]))
                    {
                        // Creates a copy vertex since there is a chance
                        // that a vertex with the same label can have different ancestor
                        /*
                         *          			A
		                                      .	. .
                                            B   C   D
                                           .     .    .
                                                       B        
                          */
                        // Vertex B on the left  side ancestor { A }
                        // Vertex B on the right side acestor { A, D }

                        Vertex copy = new Vertex(vertices[i]);
                        copy.Ancestors.Add(curr);

                        //copy inherits curr's ancestor
                        copy.Ancestors.AddRange(curr.Ancestors);
                        stack.Push(copy);

                        Neighbors.Add(new Edge(curr, copy, Matrix[curr.IDX, copy.IDX]));          

                    }
                    
                }
                PathElements.AddRange(curr.Ancestors);
                curr.Logs = Util.LogDFS(curr, Neighbors, PathElements, stack);

                /* Current Queue: 
                 * Paths with cost
                 * Queue Size 
                 * Elements Inside Queue
                 * Path Elements
                 */

            }
            return order;
        }
        public List<Vertex> BFS_order(List<Vertex> vertices, Vertex start, Vertex search, int dimension)
        {
            /*
             * THIS FUNCTION RETURNS A List<Vertex> WHICH CORRESPONDS TO THE PATH
             * FROM STARTING VERTEX UP TO THE SEARCHED INDEX USING BFS
             */
            List<Vertex> order = new List<Vertex>();
            Queue<Vertex> queue = new Queue<Vertex>();

            queue.Enqueue(start);


            while (queue.Count > 0)
            {
                Vertex curr = queue.Dequeue();
                order.Add(curr);

                List<Edge> neighbors = new List<Edge>();

                // If vertex being dequeued == searched, 
                if (curr.Equals(search))
                {

                    curr.Logs = Util.LogBFS(curr, neighbors, curr.Ancestors, queue);
                    curr.Logs += "\nFOUND SEARCHED VERTEX!!!";
                    return order;
                }
                for (int i = 0; i < dimension; i++)
                {
                    // Check all the neighbor vertex
                    // Also check each neighbor if it is an ancestor the the
                    // current vertex
                    if (Matrix[curr.IDX, i] > 0 && !curr.Has(vertices[i]))
                    {
                        // Creates a copy vertex since there is a chance
                        // that a vertex with the same label can have different ancestor
                        /*
                         *          			A
		                                      .	. .
                                            B   C   D
                                           .     .    .
                                                       B        
                          */
                        // Vertex B on the left  side ancestor { A }
                        // Vertex B on the right side acestor { A, D }

                        Vertex copy = new Vertex(vertices[i]);
                        copy.Ancestors.Add(curr);

                        //copy inherits curr's ancestor
                        copy.Ancestors.AddRange(curr.Ancestors);
                        queue.Enqueue(copy);
                        neighbors.Add(new Edge(curr, copy, Matrix[curr.IDX, copy.IDX]));
                    }
                }
                curr.Logs = Util.LogBFS(curr, neighbors, curr.Ancestors, queue);
            }
            return order;
        }

        public List<Vertex> BranchAndBound_order(List<Vertex> vertices, Vertex start, Vertex search, int dimension)
        {
            /*
             * THIS FUNCTION RETURNS A List<Vertex> WHICH CORRESPONDS TO THE PATH
             * FROM STARTING VERTEX UP TO THE SEARCHED VERTEX USING BFS
             */
            List<Vertex> order = new List<Vertex>();

            // Stores all the neighbors of current vertex since not all edge are travered
            // Only enque best w neighbors
            List<Vertex> queue = new List<Vertex>();

            queue.Add(start);


            while (queue.Count > 0)
            {
                Vertex curr = queue[0];
                queue.RemoveAt(0);
                order.Add(curr);


                List<Edge> neighbors = new List<Edge>();

                // If vertex being dequeued == searched, 
                if (curr.Equals(search))
                {
                    curr.Logs = Util.LogBNB(curr, neighbors, curr.Ancestors, queue);
                    curr.Logs += "\nFOUND SEARCHED VERTEX!!!";
                    return order;
                }
                for (int i = 0; i < dimension; i++)
                {
                    // Check all the neighbor vertex
                    // Also check each neighbor if it is an ancestor the the
                    // current vertex
                    if (Matrix[curr.IDX, i] > 0 && !curr.Has(vertices[i]))
                    {
                        // Creates a copy vertex since there is a chance
                        // that a vertex with the same label can have different ancestor

                        Vertex copy = new Vertex(vertices[i]);
                        copy.Ancestors.Add(curr);

                        //copy inherits curr's ancestor
                        copy.Ancestors.AddRange(curr.Ancestors);
                        copy.AccumulatedWeight += (curr.AccumulatedWeight + Matrix[curr.IDX, i]);
                        queue.Add(copy);
                        neighbors.Add(new Edge(curr, copy, Matrix[curr.IDX, copy.IDX]));
                    }
                }
                // sort list based on accumulated weight
                queue.Sort((x, y) =>
                {
                    int sumComparison = (x.AccumulatedWeight).CompareTo(y.AccumulatedWeight);

                    if (sumComparison == 0)
                    {
                        // If the sums are equal, compare based on Property3
                        return x.ID.CompareTo(y.ID);
                    }

                    return sumComparison;
                });
                curr.Logs = Util.LogBNB(curr, neighbors, curr.Ancestors, queue);
            }
            return order;
        }

        public List<Vertex> Beam_order(List<Vertex> vertices, Vertex start, Vertex search, int dimension, int width = 2)
        {
            /*
             * THIS FUNCTION RETURNS A List<Vertex> WHICH CORRESPONDS TO THE PATH
             * FROM STARTING VERTEX UP TO THE SEARCHED VERTEX  USING BEAM SEARCH
             * 
             * BFS THAT PRIORITIZES VERTEX WITH THE LEAST HEURISTIC RELATIVE TO THE
             * SEARCHED VERTEX
             */
            List<Vertex> order = new List<Vertex>();

            // Stores all the neighbors of current vertex since not all edge are travered
            // Only enque best w neighbors
            List<Vertex> queue = new List<Vertex>();

            queue.Add(start);


            while (queue.Count > 0)
            {
                List<Edge> neighbors = new List<Edge>();

                Vertex curr = queue[0];
                queue.RemoveAt(0);
                order.Add(curr);

                // If vertex being dequeued == searched, 
                if (curr.Equals(search))
                {

                    curr.Logs = Util.LogBeam(curr, neighbors, curr.Ancestors, queue, width);
                    curr.Logs += "\nFOUND SEARCHED VERTEX!!!";
                    return order;
                }
                for (int i = 0; i < dimension; i++)
                {
                    // Check all the neighbor vertex
                    // Also check each neighbor if it is an ancestor the the
                    // current vertex
                    if (Matrix[curr.IDX, i] > 0 && !curr.Has(vertices[i]))
                    {
                        // Creates a copy vertex since there is a chance
                        // that a vertex with the same label can have different ancestor

                        Vertex copy = new Vertex(vertices[i]);
                        copy.Ancestors.Add(curr);
                        copy.Heuristic = Util.distance(copy, search);

                        //copy inherits curr's ancestor
                        copy.Ancestors.AddRange(curr.Ancestors);
                        queue.Add(copy);
                        neighbors.Add(new Edge(curr, copy, Matrix[curr.IDX, copy.IDX]));
                    }
                }
                // sort list based on heuristic
                queue.Sort((x, y) =>
                {
                    int sumComparison = (x.Heuristic).CompareTo(y.Heuristic);

                    if (sumComparison == 0)
                    {
                        // If the sums are equal, compare based on Property3
                        return x.ID.CompareTo(y.ID);
                    }

                    return sumComparison;
                });
                // How many vertex to remove
                int NumToRemove = 0;
                if(queue.Count > width)
                {
                    NumToRemove = queue.Count - width;
                    queue.RemoveRange(width, NumToRemove);
                }
                curr.Logs = Util.LogBeam(curr, neighbors, curr.Ancestors, queue, width);

            }
            return order;

        }

        public List<Vertex> HillClimbing_order(List<Vertex> vertices, Vertex start, Vertex search, int dimension, int width = 1)
        {
            return Beam_order(vertices, start, search, dimension, 1);
        }

        public List<Vertex> AStar_order(List<Vertex> vertices, Vertex start, Vertex search, int dimension)
        {
            /*
             * THIS FUNCTION RETURNS A List<Vertex> WHICH CORRESPONDS TO THE PATH
             * FROM STARTING VERTEX UP TO THE SEARCHED VERTEX  USING BEAM SEARCH
             * 
             * BFS THAT PRIORITIZES VERTEX WITH THE LEAST HEURISTIC RELATIVE TO THE
             * SEARCHED VERTEX
             */
            List<Vertex> order = new List<Vertex>();

            // Stores all the neighbors of current vertex since not all edge are travered
            // Only enque best w neighbors
            List<Vertex> queue = new List<Vertex>();


            start.Heuristic = Util.distance(start, search);
            queue.Add(start);



            while (queue.Count > 0)
            {
                List<Edge> neighbors = new List<Edge>();
                Vertex curr = queue[0];
                queue.RemoveAt(0);
                order.Add(curr);

                // If vertex being dequeued == searched, 
                if (curr.Equals(search))
                {

                    curr.Logs = Util.LogAStar(curr, neighbors, curr.Ancestors, queue);
                    curr.Logs += "\nFOUND SEARCHED VERTEX!!!";
                    return order;
                }
                for (int i = 0; i < dimension; i++)
                {
                    // Check all the neighbor vertex
                    // Also check each neighbor if it is an ancestor the the
                    // current vertex
                    if (Matrix[curr.IDX, i] > 0 && !curr.Has(vertices[i]))
                    {
                        // Creates a copy vertex since there is a chance
                        // that a vertex with the same label can have different ancestor

                        Vertex copy = new Vertex(vertices[i]);
                        copy.Ancestors.Add(curr);
                        copy.Heuristic = Util.distance(copy, search);
                        copy.AccumulatedWeight += (curr.AccumulatedWeight + Matrix[curr.IDX, i]);
                       
                        //copy inherits curr's ancestor
                        copy.Ancestors.AddRange(curr.Ancestors);
                        neighbors.Add(new Edge(curr, copy, Matrix[curr.IDX, copy.IDX]));
                        queue.Add(copy);
                    }
                }
                // sort list based on accumulated weight
                queue.Sort((x, y) =>
                {

                    // Sorts based on heuristic + acuumulated weight
                    int sumComparison = (x.Heuristic + x.AccumulatedWeight).CompareTo(y.Heuristic + x.AccumulatedWeight);


                    // VertexA  == VertexB in terms of accumulated weight + heuristic
                    // VertexA will be first since char A < char B

                    if (sumComparison == 0)
                    {
                        //compare based on char label
                        return x.ID.CompareTo(y.ID);
                    }

                    return sumComparison;
                });
                curr.Logs = Util.LogAStar(curr, neighbors, curr.Ancestors, queue);
            }
            return order;
        }
    }
}
