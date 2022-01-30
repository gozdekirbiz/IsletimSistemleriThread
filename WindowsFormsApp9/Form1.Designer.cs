namespace WindowsFormsApp9
{
    partial class Form1
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
            this.lb_threadinfo = new System.Windows.Forms.ListBox();
            this.btnThreadBaslat = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGrafikCiz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_threadinfo
            // 
            this.lb_threadinfo.BackColor = System.Drawing.SystemColors.Menu;
            this.lb_threadinfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_threadinfo.FormattingEnabled = true;
            this.lb_threadinfo.ItemHeight = 17;
            this.lb_threadinfo.Location = new System.Drawing.Point(10, 42);
            this.lb_threadinfo.Margin = new System.Windows.Forms.Padding(1);
            this.lb_threadinfo.Name = "lb_threadinfo";
            this.lb_threadinfo.Size = new System.Drawing.Size(332, 990);
            this.lb_threadinfo.TabIndex = 1;
            // 
            // btnThreadBaslat
            // 
            this.btnThreadBaslat.BackColor = System.Drawing.Color.Honeydew;
            this.btnThreadBaslat.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnThreadBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThreadBaslat.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThreadBaslat.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnThreadBaslat.Location = new System.Drawing.Point(10, 1);
            this.btnThreadBaslat.Margin = new System.Windows.Forms.Padding(1);
            this.btnThreadBaslat.Name = "btnThreadBaslat";
            this.btnThreadBaslat.Size = new System.Drawing.Size(332, 39);
            this.btnThreadBaslat.TabIndex = 2;
            this.btnThreadBaslat.Text = "Threadleri başlat";
            this.btnThreadBaslat.UseVisualStyleBackColor = false;
            this.btnThreadBaslat.Click += new System.EventHandler(this.btnThreadBaslat_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Menu;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(344, 43);
            this.chart1.Margin = new System.Windows.Forms.Padding(1);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.Black;
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.SeaGreen;
            series1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "time";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1559, 989);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // btnGrafikCiz
            // 
            this.btnGrafikCiz.BackColor = System.Drawing.Color.Honeydew;
            this.btnGrafikCiz.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnGrafikCiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafikCiz.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnGrafikCiz.Location = new System.Drawing.Point(344, 1);
            this.btnGrafikCiz.Margin = new System.Windows.Forms.Padding(1);
            this.btnGrafikCiz.Name = "btnGrafikCiz";
            this.btnGrafikCiz.Size = new System.Drawing.Size(354, 39);
            this.btnGrafikCiz.TabIndex = 4;
            this.btnGrafikCiz.Text = "Grafiği çiz";
            this.btnGrafikCiz.UseVisualStyleBackColor = false;
            this.btnGrafikCiz.Visible = false;
            this.btnGrafikCiz.Click += new System.EventHandler(this.btnGrafikCiz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnGrafikCiz);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnThreadBaslat);
            this.Controls.Add(this.lb_threadinfo);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lb_threadinfo;
        private System.Windows.Forms.Button btnThreadBaslat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnGrafikCiz;
    }
}

