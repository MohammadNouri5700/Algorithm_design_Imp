using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_design_Imp.baseImp
{
    public class Edge
    {
        public Node From { get; set; }
        public Node To { get; set; }
        public int Weight { get; set; }
        public Boolean isDirected {  get; set; }

        public Edge(Node from, Node to, int weight, bool isDirected)
        {
            From = from;
            To = to;
            Weight = weight;
            this.isDirected = isDirected;
        }
    }
}
