namespace JOB_FINDER.Company_Forms.Company_ViewApplications
{
    partial class JobListings
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_postjobs = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnl_listedjobs = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_childform = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_postjobs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hire smarter with effective job listings";
            // 
            // btn_postjobs
            // 
            this.btn_postjobs.Animated = true;
            this.btn_postjobs.BorderRadius = 5;
            this.btn_postjobs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_postjobs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_postjobs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_postjobs.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_postjobs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_postjobs.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_postjobs.FillColor2 = System.Drawing.Color.Navy;
            this.btn_postjobs.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_postjobs.ForeColor = System.Drawing.Color.White;
            this.btn_postjobs.Image = global::JOB_FINDER.Properties.Resources.icons8_add_25;
            this.btn_postjobs.Location = new System.Drawing.Point(870, 5);
            this.btn_postjobs.Name = "btn_postjobs";
            this.btn_postjobs.Size = new System.Drawing.Size(147, 42);
            this.btn_postjobs.TabIndex = 19;
            this.btn_postjobs.Text = "Post Job";
            this.btn_postjobs.Click += new System.EventHandler(this.btn_postjobs_Click);
            // 
            // pnl_listedjobs
            // 
            this.pnl_listedjobs.AutoScroll = true;
            this.pnl_listedjobs.BackColor = System.Drawing.Color.LightGray;
            this.pnl_listedjobs.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_listedjobs.Location = new System.Drawing.Point(0, 50);
            this.pnl_listedjobs.Name = "pnl_listedjobs";
            this.pnl_listedjobs.Size = new System.Drawing.Size(645, 693);
            this.pnl_listedjobs.TabIndex = 1;
            // 
            // pnl_childform
            // 
            this.pnl_childform.BackColor = System.Drawing.Color.LightGray;
            this.pnl_childform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_childform.Location = new System.Drawing.Point(645, 50);
            this.pnl_childform.Name = "pnl_childform";
            this.pnl_childform.Size = new System.Drawing.Size(376, 693);
            this.pnl_childform.TabIndex = 2;
            // 
            // JobListings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 743);
            this.Controls.Add(this.pnl_childform);
            this.Controls.Add(this.pnl_listedjobs);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JobListings";
            this.Text = "ViewApplications";
            this.Load += new System.EventHandler(this.ViewApplications_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pnl_listedjobs;
        private System.Windows.Forms.Panel pnl_childform;
        private Guna.UI2.WinForms.Guna2GradientButton btn_postjobs;
        private System.Windows.Forms.Label label1;
    }
}