namespace JOB_FINDER.Company_Forms.View_Interviews
{
    partial class ViewInterviews
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
            this.pnl_applicationinterviews = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_listedjobs = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_applicationinterviews
            // 
            this.pnl_applicationinterviews.AutoScroll = true;
            this.pnl_applicationinterviews.BackColor = System.Drawing.Color.Transparent;
            this.pnl_applicationinterviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_applicationinterviews.Location = new System.Drawing.Point(453, 39);
            this.pnl_applicationinterviews.Name = "pnl_applicationinterviews";
            this.pnl_applicationinterviews.Size = new System.Drawing.Size(568, 704);
            this.pnl_applicationinterviews.TabIndex = 5;
            // 
            // pnl_listedjobs
            // 
            this.pnl_listedjobs.AutoScroll = true;
            this.pnl_listedjobs.BackColor = System.Drawing.Color.Transparent;
            this.pnl_listedjobs.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_listedjobs.Location = new System.Drawing.Point(0, 39);
            this.pnl_listedjobs.Name = "pnl_listedjobs";
            this.pnl_listedjobs.Size = new System.Drawing.Size(453, 704);
            this.pnl_listedjobs.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 39);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Interviews";
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
            // ViewInterviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1021, 743);
            this.Controls.Add(this.pnl_applicationinterviews);
            this.Controls.Add(this.pnl_listedjobs);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewInterviews";
            this.Text = "ViewInterviews";
            this.Load += new System.EventHandler(this.ViewInterviews_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnl_applicationinterviews;
        private System.Windows.Forms.FlowLayoutPanel pnl_listedjobs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}