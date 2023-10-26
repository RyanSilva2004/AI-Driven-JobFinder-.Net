namespace JOB_FINDER.Employee_Forms.Interviews
{
    partial class Employee_Interviews
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
            this.pnl_appliedjobs = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_appliedjobs
            // 
            this.pnl_appliedjobs.AutoScroll = true;
            this.pnl_appliedjobs.BackColor = System.Drawing.Color.LightGray;
            this.pnl_appliedjobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_appliedjobs.Location = new System.Drawing.Point(0, 50);
            this.pnl_appliedjobs.Name = "pnl_appliedjobs";
            this.pnl_appliedjobs.Size = new System.Drawing.Size(1022, 693);
            this.pnl_appliedjobs.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 50);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Check your interview status and feedback here";
            // 
            // Employee_Interviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 743);
            this.Controls.Add(this.pnl_appliedjobs);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee_Interviews";
            this.Text = "Interviews";
            this.Load += new System.EventHandler(this.Employee_Interviews_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnl_appliedjobs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}