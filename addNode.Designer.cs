namespace Algorithm_design_Imp
{
    partial class addNode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtState = new TextBox();
            btnAddNode = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(66, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 23);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 1;
            label1.Text = "Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "State : ";
            // 
            // txtState
            // 
            txtState.Location = new Point(66, 46);
            txtState.Name = "txtState";
            txtState.Size = new Size(239, 23);
            txtState.TabIndex = 2;
            txtState.Text = "0";
            // 
            // btnAddNode
            // 
            btnAddNode.Dock = DockStyle.Bottom;
            btnAddNode.Location = new Point(0, 101);
            btnAddNode.Name = "btnAddNode";
            btnAddNode.Size = new Size(317, 37);
            btnAddNode.TabIndex = 4;
            btnAddNode.Text = "Add node";
            btnAddNode.UseVisualStyleBackColor = true;
            btnAddNode.Click += btnAddNode_Click;
            // 
            // addNode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 138);
            Controls.Add(btnAddNode);
            Controls.Add(label2);
            Controls.Add(txtState);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "addNode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addNode";
            Load += addNode_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtState;
        private Button btnAddNode;
    }
}