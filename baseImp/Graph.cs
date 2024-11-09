using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Algorithm_design_Imp.baseImp
{
    public class Graph
    {
        public List<Node> Nodes { get; set; }
        public List<Edge> Edges { get; set; }

        public Graph()
        {
            Nodes = new List<Node>();
            Edges = new List<Edge>();
        }

        public void AddNode(Node node)
        {
            Nodes.Add(node);
        }

        public void AddEdge(Edge edge)
        {
            Edges.Add(edge);
        }
        public Edge GetEdgeByFromTo(Node from, Node to)
        {
            return Edges.FirstOrDefault(edge => edge.From == from && edge.To == to);
        }
        public Node GetNodeByName(string name)
        {
            return Nodes.FirstOrDefault(n => n.Name == name);
        }
    }
}
