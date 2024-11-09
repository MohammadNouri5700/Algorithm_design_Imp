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

namespace Algorithm_design_Imp
{
 

    public partial class addEdge : Form
    {

        public class itemIn
        {
            public string Name { get; set; }
            public string Value { get; set; }
            public override string ToString() { return this.Name; }
        }

        Form1 main;
        Edge _edit;
        public addEdge(Form1 value, Edge selectedEdge)
        {
            InitializeComponent();
            this.main = value;
            this._edit = selectedEdge;
        }

        private void addEdge_Load(object sender, EventArgs e)
        {
            if (this._edit != null) {
                cbFrom.Enabled = false;
                cbFrom.Items.Add(new itemIn { Name = _edit.From.Name, Value = _edit.From.Name });
                cbFrom.SelectedIndex = 0;
                cbDestination.Enabled = false;  
                cbDestination.Items.Add(new itemIn { Name = _edit.To.Name, Value = _edit.To.Name });
                cbDestination.SelectedIndex = 0;

                cbFeature.SelectedIndex = _edit.isDirected ? 1 : 0;
                txtWeight.Text = _edit.Weight.ToString();
                return;
            }
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
            cbFrom.SelectedIndex = cbDestination.Items.Count-2;
            cbDestination.SelectedIndex = cbDestination.Items.Count-1;
            cbFeature.SelectedIndex = 0;
        }

        private void btnAddEdge_Click(object sender, EventArgs e)
        {
            string fromNodeName = cbFrom.SelectedItem.ToString();
            string toNodeName = cbDestination.SelectedItem.ToString();
            int weight = 0;
            

            try
            {
                weight = int.Parse(txtWeight.Text);
            }
            catch(Exception ex)
            {
                weight = 0;
            }

            if (int.TryParse(txtWeight.Text, out weight))
            {
                var fromNode = Form1.graph.GetNodeByName(fromNodeName);
                var toNode = Form1.graph.GetNodeByName(toNodeName);
                if (this._edit != null)
                {
                    Form1.graph.GetEdgeByFromTo(fromNode, toNode).Weight= weight;
                    Form1.graph.GetEdgeByFromTo(fromNode, toNode).isDirected = cbFeature.SelectedIndex ==1;
                    main.Invalidate();
                    Close();
                    return;
                }
                    if (fromNode != null && toNode != null)
                {
                    var edge = new Edge(fromNode, toNode, weight,cbFeature.SelectedIndex==1);
                    Form1.graph.AddEdge(edge);
                }
               
                else
                {
                    MessageBox.Show("One or both nodes not found.");
                }
                main.Invalidate();
            }
            else
            {
                MessageBox.Show("Invalid edge weight.");
            }
        }
    }
}
