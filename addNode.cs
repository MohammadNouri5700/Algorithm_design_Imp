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
    public partial class addNode : Form
    {
        Form1 main;
        Node _edit;
        Boolean isEditMode = false;
        public addNode(Form1 value, Node edit)
        {
            InitializeComponent();
            this.main = value;
            _edit = edit;
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtState.Text, out _))
            {

           
            string nodeName = txtName.Text.Trim();

                if (isEditMode)
                {
                    Form1.graph.GetNodeByName(nodeName).State = int.Parse(txtState.Text);
                    Close();
                    return;
                }
                if (null == Form1.graph.GetNodeByName(nodeName))
            {
              
                if (!string.IsNullOrEmpty(nodeName))
                {

                    int x = 300;
                    int y = 300;

                    var node = new Node(nodeName, new Point(x, y), int.Parse(txtState.Text));
                    Form1.graph.AddNode(node);
                    main.Invalidate();
                }
            }
            else
            {
                MessageBox.Show("Duplicate node name is not valid");
            }
            }
            else {   MessageBox.Show("State is not valid");}
        }

        private void addNode_Load(object sender, EventArgs e)
        {
            if (_edit != null)
            {
                isEditMode = true;
                txtName.Text = _edit.Name;
                txtName.Enabled = false;
                btnAddNode.Text = "EDIT";
                txtState.Text = _edit.State.ToString();
            }
            else
            {
                isEditMode = false;
            }
        }
    }
}
