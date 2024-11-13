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

        public Dictionary<Node, int> FindShortestPathDijkstra(Graph graph, Node startNode)
        {
            // Initialize the distances and previous nodes
            var distances = new Dictionary<Node, int>();
            var previousNodes = new Dictionary<Node, Node>();
            var unvisitedNodes = new HashSet<Node>();

            // Set the initial distance to infinity, except for the start node
            foreach (var node in graph.Nodes)
            {
                distances[node] = int.MaxValue;
                previousNodes[node] = null;
                unvisitedNodes.Add(node);
            }
            distances[startNode] = 0;

            while (unvisitedNodes.Count > 0)
            {
                // Get the node with the smallest distance
                var currentNode = unvisitedNodes.OrderBy(n => distances[n]).First();
                unvisitedNodes.Remove(currentNode);

                // Process each neighboring node
                foreach (var edge in graph.Edges.Where(e => e.From == currentNode || e.To == currentNode))
                {
                    // Check if the edge is directed or undirected
                    Node neighbor = null;
                    if (edge.From == currentNode)
                    {
                        neighbor = edge.To;
                    }
                    else if (edge.To == currentNode)
                    {
                        neighbor = edge.From;
                    }

                    if (neighbor != null)
                    {
                        int newDist = distances[currentNode] + edge.Weight;

                        if (newDist < distances[neighbor])
                        {
                            distances[neighbor] = newDist;
                            previousNodes[neighbor] = currentNode;
                        }
                    }
                }
            }

            // Return the distances as a Dictionary<Node, int>
            return distances;
        }
    }
}
