﻿namespace Algorithm_design_Imp
{
    partial class DijkstraForm
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
            cbFrom = new ComboBox();
            label1 = new Label();
            btnStart = new Button();
            SuspendLayout();
            // 
            // cbFrom
            // 
            cbFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFrom.FormattingEnabled = true;
            cbFrom.Location = new Point(97, 12);
            cbFrom.Name = "cbFrom";
            cbFrom.Size = new Size(131, 23);
            cbFrom.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "From :";
            // 
            // btnStart
            // 
            btnStart.Dock = DockStyle.Bottom;
            btnStart.Location = new Point(0, 54);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(271, 27);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // DijkstraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 81);
            Controls.Add(btnStart);
            Controls.Add(label1);
            Controls.Add(cbFrom);
            Name = "DijkstraForm";
            Text = "Dijkstra";
            Load += Dijkstra_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbFrom;
        private Label label1;
        private Button btnStart;
    }
}