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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bunifuProgressBarCPU = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.bunifuProgressBarRAM = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.chart_cpu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_ram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_cpu = new System.Windows.Forms.Label();
            this.lbl_ram = new System.Windows.Forms.Label();
            this.ram = new System.Windows.Forms.TabControl();
            this.cpu = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ram)).BeginInit();
            this.ram.SuspendLayout();
            this.cpu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.bunifuProgressBarCPU.Location = new System.Drawing.Point(41, 16);
            this.bunifuProgressBarCPU.Maximum = 100;
            this.bunifuProgressBarCPU.MaximumValue = 100;
            this.bunifuProgressBarCPU.Minimum = 0;
            this.bunifuProgressBarCPU.MinimumValue = 0;
            this.bunifuProgressBarCPU.Name = "bunifuProgressBarCPU";
            this.bunifuProgressBarCPU.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.bunifuProgressBarCPU.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.bunifuProgressBarCPU.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuProgressBarCPU.ProgressColorRight = System.Drawing.Color.CadetBlue;
            this.bunifuProgressBarCPU.Size = new System.Drawing.Size(262, 13);
            this.bunifuProgressBarCPU.TabIndex = 17;
            this.bunifuProgressBarCPU.Value = 10;
            this.bunifuProgressBarCPU.ValueByTransition = 10;
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
            this.bunifuProgressBarRAM.Location = new System.Drawing.Point(41, 61);
            this.bunifuProgressBarRAM.Maximum = 100;
            this.bunifuProgressBarRAM.MaximumValue = 100;
            this.bunifuProgressBarRAM.Minimum = 0;
            this.bunifuProgressBarRAM.MinimumValue = 0;
            this.bunifuProgressBarRAM.Name = "bunifuProgressBarRAM";
            this.bunifuProgressBarRAM.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.bunifuProgressBarRAM.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.bunifuProgressBarRAM.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuProgressBarRAM.ProgressColorRight = System.Drawing.Color.DodgerBlue;
            this.bunifuProgressBarRAM.Size = new System.Drawing.Size(262, 13);
            this.bunifuProgressBarRAM.TabIndex = 17;
            this.bunifuProgressBarRAM.Value = 10;
            this.bunifuProgressBarRAM.ValueByTransition = 10;
            // 
            // chart_cpu
            // 
            this.chart_cpu.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.LogarithmBase = 5D;
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea1";
            this.chart_cpu.ChartAreas.Add(chartArea1);
            this.chart_cpu.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart_cpu.Legends.Add(legend1);
            this.chart_cpu.Location = new System.Drawing.Point(3, 3);
            this.chart_cpu.Name = "chart_cpu";
            this.chart_cpu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            this.chart_cpu.Series.Add(series1);
            this.chart_cpu.Size = new System.Drawing.Size(337, 276);
            this.chart_cpu.TabIndex = 18;
            this.chart_cpu.Text = "chart1";
            // 
            // chart_ram
            // 
            this.chart_ram.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisY.IsMarginVisible = false;
            chartArea2.Name = "ChartArea1";
            this.chart_ram.ChartAreas.Add(chartArea2);
            this.chart_ram.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart_ram.Legends.Add(legend2);
            this.chart_ram.Location = new System.Drawing.Point(3, 3);
            this.chart_ram.Name = "chart_ram";
            this.chart_ram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series2.BorderColor = System.Drawing.Color.Red;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.chart_ram.Series.Add(series2);
            this.chart_ram.Size = new System.Drawing.Size(337, 276);
            this.chart_ram.TabIndex = 18;
            this.chart_ram.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "CPU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "RAM:";
            // 
            // lbl_cpu
            // 
            this.lbl_cpu.AutoSize = true;
            this.lbl_cpu.Location = new System.Drawing.Point(309, 16);
            this.lbl_cpu.Name = "lbl_cpu";
            this.lbl_cpu.Size = new System.Drawing.Size(21, 13);
            this.lbl_cpu.TabIndex = 20;
            this.lbl_cpu.Text = "0%";
            // 
            // lbl_ram
            // 
            this.lbl_ram.AutoSize = true;
            this.lbl_ram.Location = new System.Drawing.Point(309, 61);
            this.lbl_ram.Name = "lbl_ram";
            this.lbl_ram.Size = new System.Drawing.Size(21, 13);
            this.lbl_ram.TabIndex = 20;
            this.lbl_ram.Text = "0%";
            // 
            // ram
            // 
            this.ram.Controls.Add(this.cpu);
            this.ram.Controls.Add(this.tabPage2);
            this.ram.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ram.Location = new System.Drawing.Point(0, 94);
            this.ram.Name = "ram";
            this.ram.SelectedIndex = 0;
            this.ram.Size = new System.Drawing.Size(351, 308);
            this.ram.TabIndex = 21;
            // 
            // cpu
            // 
            this.cpu.Controls.Add(this.chart_cpu);
            this.cpu.Location = new System.Drawing.Point(4, 22);
            this.cpu.Name = "cpu";
            this.cpu.Padding = new System.Windows.Forms.Padding(3);
            this.cpu.Size = new System.Drawing.Size(343, 282);
            this.cpu.TabIndex = 0;
            this.cpu.Text = "CPU";
            this.cpu.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart_ram);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(343, 282);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RAM";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bunifuProgressBarCPU);
            this.panel1.Controls.Add(this.bunifuProgressBarRAM);
            this.panel1.Controls.Add(this.lbl_ram);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_cpu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 94);
            this.panel1.TabIndex = 22;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(351, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ram);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "PowerHouse";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ram)).EndInit();
            this.ram.ResumeLayout(false);
            this.cpu.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_cpu;
        private System.Windows.Forms.Label lbl_ram;
        private System.Windows.Forms.TabControl ram;
        private System.Windows.Forms.TabPage cpu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
    }
}

