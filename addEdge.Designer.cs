namespace Algorithm_design_Imp
{
    partial class addEdge
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
            label1 = new Label();
            cbFrom = new ComboBox();
            cbDestination = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cbFeature = new ComboBox();
            label4 = new Label();
            txtWeight = new TextBox();
            btnAddEdge = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 3;
            label1.Text = "From : ";
            // 
            // cbFrom
            // 
            cbFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFrom.FormattingEnabled = true;
            cbFrom.Location = new Point(97, 12);
            cbFrom.Name = "cbFrom";
            cbFrom.Size = new Size(208, 23);
            cbFrom.TabIndex = 4;
            // 
            // cbDestination
            // 
            cbDestination.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDestination.FormattingEnabled = true;
            cbDestination.Location = new Point(97, 41);
            cbDestination.Name = "cbDestination";
            cbDestination.Size = new Size(208, 23);
            cbDestination.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 5;
            label2.Text = "Destination  : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 7;
            label3.Text = "Weight : ";
            // 
            // cbFeature
            // 
            cbFeature.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFeature.FormattingEnabled = true;
            cbFeature.Items.AddRange(new object[] { "Undirected", "Directed" });
            cbFeature.Location = new Point(97, 99);
            cbFeature.Name = "cbFeature";
            cbFeature.Size = new Size(208, 23);
            cbFeature.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 102);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 9;
            label4.Text = "Edge Features :";
            // 
            // txtWeight
            // 
            txtWeight.ImeMode = ImeMode.Alpha;
            txtWeight.Location = new Point(97, 70);
            txtWeight.MaxLength = 2;
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(208, 23);
            txtWeight.TabIndex = 11;
            txtWeight.Text = "1";
            // 
            // btnAddEdge
            // 
            btnAddEdge.Dock = DockStyle.Bottom;
            btnAddEdge.Location = new Point(0, 146);
            btnAddEdge.Name = "btnAddEdge";
            btnAddEdge.Size = new Size(317, 41);
            btnAddEdge.TabIndex = 12;
            btnAddEdge.Text = "Add edge";
            btnAddEdge.UseVisualStyleBackColor = true;
            btnAddEdge.Click += btnAddEdge_Click;
            // 
            // addEdge
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 187);
            Controls.Add(btnAddEdge);
            Controls.Add(txtWeight);
            Controls.Add(cbFeature);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbDestination);
            Controls.Add(label2);
            Controls.Add(cbFrom);
            Controls.Add(label1);
            Name = "addEdge";
            Text = "addEdge";
            Load += addEdge_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbFrom;
        private ComboBox cbDestination;
        private Label label2;
        private Label label3;
        private ComboBox cbFeature;
        private Label label4;
        private TextBox txtWeight;
        private Button btnAddEdge;
    }
}