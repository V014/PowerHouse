namespace PowerHouse
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.chart_cpu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_ram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ram)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(36, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(23, 63);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(36, 23);
            this.htmlLabel1.TabIndex = 0;
            this.htmlLabel1.Text = "CPU:";
            // 
            // bunifuProgressBarCPU
            // 
            this.bunifuProgressBarCPU.AllowAnimations = false;
            this.bunifuProgressBarCPU.Animation = 0;
            this.bunifuProgressBarCPU.AnimationSpeed = 220;
            this.bunifuProgressBarCPU.AnimationStep = 10;
            this.bunifuProgressBarCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.bunifuProgressBarCPU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuProgressBarCPU.BackgroundImage")));
            this.bunifuProgressBarCPU.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.bunifuProgressBarCPU.BorderRadius = 9;
            this.bunifuProgressBarCPU.BorderThickness = 1;
            this.bunifuProgressBarCPU.Location = new System.Drawing.Point(65, 67);
            this.bunifuProgressBarCPU.Maximum = 100;
            this.bunifuProgressBarCPU.MaximumValue = 100;
            this.bunifuProgressBarCPU.Minimum = 0;
            this.bunifuProgressBarCPU.MinimumValue = 0;
            this.bunifuProgressBarCPU.Name = "bunifuProgressBarCPU";
            this.bunifuProgressBarCPU.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.bunifuProgressBarCPU.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.bunifuProgressBarCPU.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuProgressBarCPU.ProgressColorRight = System.Drawing.Color.CadetBlue;
            this.bunifuProgressBarCPU.Size = new System.Drawing.Size(305, 13);
            this.bunifuProgressBarCPU.TabIndex = 17;
            this.bunifuProgressBarCPU.Value = 10;
            this.bunifuProgressBarCPU.ValueByTransition = 10;
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(37, 23);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(23, 108);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(42, 23);
            this.htmlLabel2.TabIndex = 0;
            this.htmlLabel2.Text = "RAM:";
            // 
            // bunifuProgressBarRAM
            // 
            this.bunifuProgressBarRAM.AllowAnimations = false;
            this.bunifuProgressBarRAM.Animation = 0;
            this.bunifuProgressBarRAM.AnimationSpeed = 220;
            this.bunifuProgressBarRAM.AnimationStep = 10;
            this.bunifuProgressBarRAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.bunifuProgressBarRAM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuProgressBarRAM.BackgroundImage")));
            this.bunifuProgressBarRAM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.bunifuProgressBarRAM.BorderRadius = 9;
            this.bunifuProgressBarRAM.BorderThickness = 1;
            this.bunifuProgressBarRAM.Location = new System.Drawing.Point(65, 112);
            this.bunifuProgressBarRAM.Maximum = 100;
            this.bunifuProgressBarRAM.MaximumValue = 100;
            this.bunifuProgressBarRAM.Minimum = 0;
            this.bunifuProgressBarRAM.MinimumValue = 0;
            this.bunifuProgressBarRAM.Name = "bunifuProgressBarRAM";
            this.bunifuProgressBarRAM.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.bunifuProgressBarRAM.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.bunifuProgressBarRAM.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuProgressBarRAM.ProgressColorRight = System.Drawing.Color.DodgerBlue;
            this.bunifuProgressBarRAM.Size = new System.Drawing.Size(305, 13);
            this.bunifuProgressBarRAM.TabIndex = 17;
            this.bunifuProgressBarRAM.Value = 10;
            this.bunifuProgressBarRAM.ValueByTransition = 10;
            // 
            // lblRAM
            // 
            this.lblRAM.AutoScroll = true;
            this.lblRAM.AutoScrollMinSize = new System.Drawing.Size(26, 23);
            this.lblRAM.AutoSize = false;
            this.lblRAM.BackColor = System.Drawing.SystemColors.Window;
            this.lblRAM.Location = new System.Drawing.Point(376, 108);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(60, 23);
            this.lblRAM.TabIndex = 1;
            this.lblRAM.Text = "0%";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoScroll = true;
            this.lblCPU.AutoScrollMinSize = new System.Drawing.Size(26, 23);
            this.lblCPU.AutoSize = false;
            this.lblCPU.BackColor = System.Drawing.SystemColors.Window;
            this.lblCPU.Location = new System.Drawing.Point(376, 63);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(60, 23);
            this.lblCPU.TabIndex = 2;
            this.lblCPU.Text = "0%";
            // 
            // chart_cpu
            // 
            this.chart_cpu.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            chartArea5.AxisX.LabelStyle.Enabled = false;
            chartArea5.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea5.AxisY.LabelStyle.Enabled = false;
            chartArea5.BorderColor = System.Drawing.Color.Empty;
            chartArea5.Name = "ChartArea1";
            this.chart_cpu.ChartAreas.Add(chartArea5);
            this.chart_cpu.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.chart_cpu.Legends.Add(legend5);
            this.chart_cpu.Location = new System.Drawing.Point(3, 3);
            this.chart_cpu.Name = "chart_cpu";
            this.chart_cpu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series9.Legend = "Legend1";
            series9.Name = "CPU";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "RAM";
            this.chart_cpu.Series.Add(series9);
            this.chart_cpu.Series.Add(series10);
            this.chart_cpu.Size = new System.Drawing.Size(384, 189);
            this.chart_cpu.TabIndex = 18;
            this.chart_cpu.Text = "chart1";
            // 
            // chart_ram
            // 
            this.chart_ram.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            chartArea6.AxisX.LabelStyle.Enabled = false;
            chartArea6.AxisY.LabelStyle.Enabled = false;
            chartArea6.Name = "ChartArea1";
            this.chart_ram.ChartAreas.Add(chartArea6);
            this.chart_ram.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.chart_ram.Legends.Add(legend6);
            this.chart_ram.Location = new System.Drawing.Point(3, 3);
            this.chart_ram.Name = "chart_ram";
            this.chart_ram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.Name = "CPU";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.Name = "RAM";
            this.chart_ram.Series.Add(series11);
            this.chart_ram.Series.Add(series12);
            this.chart_ram.Size = new System.Drawing.Size(186, 158);
            this.chart_ram.TabIndex = 18;
            this.chart_ram.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(20, 200);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(398, 221);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart_cpu);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(390, 195);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CPU";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart_ram);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 164);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RAM";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 441);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.bunifuProgressBarRAM);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.bunifuProgressBarCPU);
            this.Controls.Add(this.htmlLabel1);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "PowerHouse";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ram)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer;
        private Bunifu.UI.WinForms.BunifuProgressBar bunifuProgressBarCPU;
        private Bunifu.UI.WinForms.BunifuProgressBar bunifuProgressBarRAM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_cpu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ram;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

