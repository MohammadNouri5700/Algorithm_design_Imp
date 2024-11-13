namespace Algorithm_design_Imp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnDijkstra = new Button();
            button1 = new Button();
            btnAddNode = new Button();
            panel2 = new Panel();
            btnAddTmp = new Button();
            btnAddEdge = new Button();
            panel3 = new Panel();
            btnStart = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnDijkstra);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 681);
            panel1.TabIndex = 0;
            // 
            // btnDijkstra
            // 
            btnDijkstra.Dock = DockStyle.Top;
            btnDijkstra.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDijkstra.Location = new Point(0, 50);
            btnDijkstra.Name = "btnDijkstra";
            btnDijkstra.Size = new Size(250, 50);
            btnDijkstra.TabIndex = 1;
            btnDijkstra.Text = "Dijkstra's";
            btnDijkstra.UseVisualStyleBackColor = true;
            btnDijkstra.Click += btnDijkstra_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(250, 50);
            button1.TabIndex = 0;
            button1.Text = "Algorithms menu";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAddNode
            // 
            btnAddNode.Dock = DockStyle.Right;
            btnAddNode.Location = new Point(644, 0);
            btnAddNode.Margin = new Padding(13, 3, 13, 3);
            btnAddNode.Name = "btnAddNode";
            btnAddNode.Size = new Size(170, 50);
            btnAddNode.TabIndex = 1;
            btnAddNode.Text = "ADD NODE";
            btnAddNode.UseVisualStyleBackColor = true;
            btnAddNode.Click += btnAddNode_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAddTmp);
            panel2.Controls.Add(btnAddEdge);
            panel2.Controls.Add(btnAddNode);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(814, 50);
            panel2.TabIndex = 2;
            // 
            // btnAddTmp
            // 
            btnAddTmp.Dock = DockStyle.Left;
            btnAddTmp.Location = new Point(0, 0);
            btnAddTmp.Margin = new Padding(13, 3, 13, 3);
            btnAddTmp.Name = "btnAddTmp";
            btnAddTmp.Size = new Size(170, 50);
            btnAddTmp.TabIndex = 3;
            btnAddTmp.Text = "ADD DATA";
            btnAddTmp.UseVisualStyleBackColor = true;
            btnAddTmp.Click += btnAddTmp_Click;
            // 
            // btnAddEdge
            // 
            btnAddEdge.Dock = DockStyle.Right;
            btnAddEdge.Location = new Point(474, 0);
            btnAddEdge.Margin = new Padding(13, 3, 13, 3);
            btnAddEdge.Name = "btnAddEdge";
            btnAddEdge.Size = new Size(170, 50);
            btnAddEdge.TabIndex = 2;
            btnAddEdge.Text = "ADD EDGE";
            btnAddEdge.UseVisualStyleBackColor = true;
            btnAddEdge.Click += btnAddEdge_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnStart);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(250, 644);
            panel3.Name = "panel3";
            panel3.Size = new Size(814, 37);
            panel3.TabIndex = 3;
            // 
            // btnStart
            // 
            btnStart.Dock = DockStyle.Right;
            btnStart.Location = new Point(739, 0);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 37);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1064, 681);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Algorithms";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button btnAddNode;
        private Panel panel2;
        private Button btnAddEdge;
        private Button btnAddTmp;
        private Panel panel3;
        private Button btnStart;
        private Button btnDijkstra;
    }
}
