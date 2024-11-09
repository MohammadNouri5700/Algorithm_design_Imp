using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_design_Imp.baseImp
{
    public class Node
    {
        private Graph graph;

        public string Name { get; set; }
        public Point Position { get; set; }
        public int State { get; set; }
        public Node(string name, Point position, int state)
        {
            Name = name;
            Position = position;
            State = state;
        }
    }

}
