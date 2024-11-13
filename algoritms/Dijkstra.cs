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

        public Dictionary<Node, int> FindShortestPathDijkstra(Node startNode)
        {
            var distances = Form1.graph.Nodes.ToDictionary(n => n, n => int.MaxValue);
            distances[startNode] = 0;
            var priorityQueue = new SortedSet<(int, Node)>(Comparer<(int, Node)>.Create((a, b) => a.Item1 == b.Item1 ? a.Item2.Name.CompareTo(b.Item2.Name) : a.Item1.CompareTo(b.Item1)));
            priorityQueue.Add((0, startNode));

            while (priorityQueue.Any())
            {
                var (currentDistance, currentNode) = priorityQueue.Min;
                priorityQueue.Remove(priorityQueue.Min);

                foreach (var edge in Form1.graph.Edges.Where(e => e.From == currentNode))
                {
                    var neighbor = edge.To;
                    var newDistance = currentDistance + edge.Weight;

                    if (newDistance < distances[neighbor])
                    {
                        priorityQueue.Remove((distances[neighbor], neighbor));
                        distances[neighbor] = newDistance;
                        priorityQueue.Add((newDistance, neighbor));
                    }
                }
            }

            return distances;
        }
    }
}
