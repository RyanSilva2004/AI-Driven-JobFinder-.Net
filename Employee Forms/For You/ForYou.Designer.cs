namespace JOB_FINDER.Employee_Forms.For_You
{
    partial class ForYou
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_joblistings_foryou = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Explore our handpicked jobs and find your perfect fit.";
            // 
            // pnl_joblistings_foryou
            // 
            this.pnl_joblistings_foryou.AutoScroll = true;
            this.pnl_joblistings_foryou.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_joblistings_foryou.Location = new System.Drawing.Point(0, 63);
            this.pnl_joblistings_foryou.Name = "pnl_joblistings_foryou";
            this.pnl_joblistings_foryou.Size = new System.Drawing.Size(921, 550);
            this.pnl_joblistings_foryou.TabIndex = 2;
            // 
            // ForYou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(921, 613);
            this.Controls.Add(this.pnl_joblistings_foryou);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForYou";
            this.Text = "ForYou";
            this.Load += new System.EventHandler(this.ForYou_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnl_joblistings_foryou;
    }
}