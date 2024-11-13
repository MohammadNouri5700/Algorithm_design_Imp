using Algorithm_design_Imp.algoritms;
using Algorithm_design_Imp.baseImp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            }
            if (cbFrom.Items.Count == 0)
            {
                MessageBox.Show("There is not any node to specify edge");
                this.Close();
                return;
            }
        }
        private async void RunDijkstraAndShowResults(Node startNode)
        {
            Dijkstra dijkstra = new Dijkstra();
            var distances = await Task.Run(() => dijkstra.FindShortestPathDijkstra(startNode));

            StringBuilder results = new StringBuilder();
            foreach (var entry in distances)
            {
                results.AppendLine($"Distance from {startNode.Name} to {entry.Key.Name} is {entry.Value}");
            }
            this.Invoke(new Action(() => {
                MessageBox.Show(results.ToString(), "Dijkstra Results");
            }));
            //MessageBox.Show(results.ToString(), "Dijkstra Results");
        }
        private void btnStart_Click(object sender, EventArgs e)
        {

            RunDijkstraAndShowResults(Form1.graph.GetNodeByName(cbFrom.SelectedItem.ToString()));
        }
    }
}
