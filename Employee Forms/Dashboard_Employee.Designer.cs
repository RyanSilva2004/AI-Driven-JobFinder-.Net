namespace JOB_FINDER.Employee_Forms
{
    partial class Dashboard_Employee
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Employee));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuGradientPanel3 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lbl_noofusers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel2 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lbl_noofcompanies = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lbl_nojobslisted = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.bunifuGradientPanel3.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 142);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(680, 489);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.BorderRadius = 20;
            this.bunifuGradientPanel3.Controls.Add(this.lbl_noofusers);
            this.bunifuGradientPanel3.Controls.Add(this.label5);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.Gold;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.Goldenrod;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.Orange;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.DarkOrange;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(501, 12);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(200, 100);
            this.bunifuGradientPanel3.TabIndex = 7;
            // 
            // lbl_noofusers
            // 
            this.lbl_noofusers.AutoSize = true;
            this.lbl_noofusers.Font = new System.Drawing.Font("Pusia-Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noofusers.ForeColor = System.Drawing.Color.White;
            this.lbl_noofusers.Location = new System.Drawing.Point(69, 14);
            this.lbl_noofusers.Name = "lbl_noofusers";
            this.lbl_noofusers.Size = new System.Drawing.Size(63, 50);
            this.lbl_noofusers.TabIndex = 1;
            this.lbl_noofusers.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Pusia-Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "User Count";
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.BorderRadius = 20;
            this.bunifuGradientPanel2.Controls.Add(this.lbl_noofcompanies);
            this.bunifuGradientPanel2.Controls.Add(this.label3);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(258, 12);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(200, 100);
            this.bunifuGradientPanel2.TabIndex = 6;
            // 
            // lbl_noofcompanies
            // 
            this.lbl_noofcompanies.AutoSize = true;
            this.lbl_noofcompanies.Font = new System.Drawing.Font("Pusia-Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noofcompanies.ForeColor = System.Drawing.Color.White;
            this.lbl_noofcompanies.Location = new System.Drawing.Point(69, 14);
            this.lbl_noofcompanies.Name = "lbl_noofcompanies";
            this.lbl_noofcompanies.Size = new System.Drawing.Size(63, 50);
            this.lbl_noofcompanies.TabIndex = 1;
            this.lbl_noofcompanies.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pusia-Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Companies";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 20;
            this.bunifuGradientPanel1.Controls.Add(this.lbl_nojobslisted);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(6, 12);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(200, 100);
            this.bunifuGradientPanel1.TabIndex = 5;
            // 
            // lbl_nojobslisted
            // 
            this.lbl_nojobslisted.AutoSize = true;
            this.lbl_nojobslisted.Font = new System.Drawing.Font("Pusia-Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nojobslisted.ForeColor = System.Drawing.Color.White;
            this.lbl_nojobslisted.Location = new System.Drawing.Point(65, 14);
            this.lbl_nojobslisted.Name = "lbl_nojobslisted";
            this.lbl_nojobslisted.Size = new System.Drawing.Size(63, 50);
            this.lbl_nojobslisted.TabIndex = 1;
            this.lbl_nojobslisted.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pusia-Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job Listings";
            // 
            // Dashboard_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 743);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard_Employee";
            this.Text = "Dashboard_Employee";
            this.Load += new System.EventHandler(this.Dashboard_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel3;
        private System.Windows.Forms.Label lbl_noofusers;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label lbl_noofcompanies;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lbl_nojobslisted;
        private System.Windows.Forms.Label label1;
    }
}