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
        public addNode(Form1 value)
        {
            InitializeComponent();
            this.main = value;
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            string nodeName = txtName.Text.Trim();
            if (null == Form1.graph.GetNodeByName(nodeName))
            {            
                if (!string.IsNullOrEmpty(nodeName))
                {
          
                    int x = 300 ; 
                    int y = 300 ;

                    var node = new Node(nodeName, new Point(x, y));
                    Form1.graph.AddNode(node);
                    main.Invalidate();
                }
            }
            else
            {
                MessageBox.Show("Duplicate node name is not valid");
            }
        }
    }
}
