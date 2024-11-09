using Algorithm_design_Imp.algoritms;
using Algorithm_design_Imp.baseImp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Algorithm_design_Imp.addEdge;

namespace Algorithm_design_Imp
{
    public partial class DijkstraForm : Form
    {
        public DijkstraForm()
        {
            InitializeComponent();
        }

        private void Dijkstra_Load(object sender, EventArgs e)
        {
            var dataSource = new List<itemIn>();
            for (int i = 0; i < Form1.graph.Nodes.Count; i++)
            {
                cbFrom.Items.Add(new itemIn { Name = Form1.graph.Nodes[i].Name, Value = Form1.graph.Nodes[i].Name });
                cbDestination.Items.Add(new itemIn { Name = Form1.graph.Nodes[i].Name, Value = Form1.graph.Nodes[i].Name });
            }
            if (cbDestination.Items.Count == 0)
            {
                MessageBox.Show("There is not any node to specify edge");
                this.Close();
                return;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Dijkstra dijkstra = new Dijkstra();
            List<Node> paths = dijkstra.GetShortestPath(Form1.graph.GetNodeByName(cbFrom.SelectedItem.ToString()), Form1.graph.GetNodeByName(cbDestination.SelectedItem.ToString()));
            string path = "";
            for (int i = 0; i < paths.Count; i++) {
                path += "[ "+i.ToString()+" ] == " + paths[i].Name + "\n";
            }
        
            MessageBox.Show(path);
        }
    }
}
