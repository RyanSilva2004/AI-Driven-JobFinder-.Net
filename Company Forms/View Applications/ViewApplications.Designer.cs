namespace JOB_FINDER.Company_Forms.View_Applications
{
    partial class ViewApplications
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_listedjobs = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_applications = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 39);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(631, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Applications";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listed Jobs";
            // 
            // pnl_listedjobs
            // 
            this.pnl_listedjobs.AutoScroll = true;
            this.pnl_listedjobs.BackColor = System.Drawing.Color.Transparent;
            this.pnl_listedjobs.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_listedjobs.Location = new System.Drawing.Point(0, 39);
            this.pnl_listedjobs.Name = "pnl_listedjobs";
            this.pnl_listedjobs.Size = new System.Drawing.Size(629, 704);
            this.pnl_listedjobs.TabIndex = 1;
            // 
            // pnl_applications
            // 
            this.pnl_applications.AutoScroll = true;
            this.pnl_applications.BackColor = System.Drawing.Color.Transparent;
            this.pnl_applications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_applications.Location = new System.Drawing.Point(629, 39);
            this.pnl_applications.Name = "pnl_applications";
            this.pnl_applications.Size = new System.Drawing.Size(392, 704);
            this.pnl_applications.TabIndex = 2;
            // 
            // ViewApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1021, 743);
            this.Controls.Add(this.pnl_applications);
            this.Controls.Add(this.pnl_listedjobs);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewApplications";
            this.Text = "ViewApplications";
            this.Load += new System.EventHandler(this.ViewApplications_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pnl_listedjobs;
        private System.Windows.Forms.FlowLayoutPanel pnl_applications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}