using Algorithm_design_Imp.baseImp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Algorithm_design_Imp.algoritms
{
    internal class Dijkstra
    {

        private Dictionary<Node, int> distances;
        private Dictionary<Node, Node> previousNodes; 



        public void FDijkstra(Node startNode)
        {
            foreach (var node in Form1.graph.Nodes)
            {
                distances[node] = int.MaxValue; 
                previousNodes[node] = null; 
            }
            distances[startNode] = 0;

            var priorityQueue = new SortedSet<Node>(Comparer<Node>.Create((n1, n2) => distances[n1].CompareTo(distances[n2])));

            foreach (var node in Form1.graph.Nodes)
            {
                priorityQueue.Add(node);
            }

            while (priorityQueue.Count > 0)
            {
                var currentNode = priorityQueue.Min;
                priorityQueue.Remove(currentNode);

                foreach (var edge in GetEdgesFromNode(currentNode))
                {
                    var neighbor = edge.To;
                    int newDist = distances[currentNode] + edge.Weight;

                    if (newDist < distances[neighbor])
                    {
                      
                        distances[neighbor] = newDist;
                        previousNodes[neighbor] = currentNode;

                    
                        priorityQueue.Remove(neighbor);  
                        priorityQueue.Add(neighbor);  
                    }
                }
            }
        }

        private List<Edge> GetEdgesFromNode(Node node)
        {
            return Form1.graph.Edges.Where(e => e.From == node).ToList();
        }

        public List<Node> GetShortestPath(Node startNode, Node endNode)
        {
            distances = new Dictionary<Node, int>();
            previousNodes = new Dictionary<Node, Node>();
            FDijkstra(startNode);

            List<Node> path = new List<Node>();
            Node currentNode = endNode;

            while (currentNode != null)
            {
                path.Insert(0, currentNode);
                currentNode = previousNodes[currentNode]; 
            }

            return path;
        }
    }
}
