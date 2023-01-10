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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progress_cpu = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.progress_ram = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.chart_cpu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_ram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_cpu = new System.Windows.Forms.Label();
            this.lbl_ram = new System.Windows.Forms.Label();
            this.lbl_cpu_stat = new System.Windows.Forms.Label();
            this.lbl_ram_stat = new System.Windows.Forms.Label();
            this.tab_main = new System.Windows.Forms.TabControl();
            this.cpu = new System.Windows.Forms.TabPage();
            this.ram = new System.Windows.Forms.TabPage();
            this.panel_main = new System.Windows.Forms.Panel();
            this.apps = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ram)).BeginInit();
            this.tab_main.SuspendLayout();
            this.cpu.SuspendLayout();
            this.ram.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.apps.SuspendLayout();
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
            // progress_cpu
            // 
            this.progress_cpu.AllowAnimations = false;
            this.progress_cpu.Animation = 0;
            this.progress_cpu.AnimationSpeed = 220;
            this.progress_cpu.AnimationStep = 10;
            this.progress_cpu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_cpu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progress_cpu.BackgroundImage")));
            this.progress_cpu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_cpu.BorderRadius = 9;
            this.progress_cpu.BorderThickness = 1;
            this.progress_cpu.Location = new System.Drawing.Point(41, 16);
            this.progress_cpu.Maximum = 100;
            this.progress_cpu.MaximumValue = 100;
            this.progress_cpu.Minimum = 0;
            this.progress_cpu.MinimumValue = 0;
            this.progress_cpu.Name = "progress_cpu";
            this.progress_cpu.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progress_cpu.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_cpu.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.progress_cpu.ProgressColorRight = System.Drawing.Color.CadetBlue;
            this.progress_cpu.Size = new System.Drawing.Size(245, 13);
            this.progress_cpu.TabIndex = 17;
            this.progress_cpu.Value = 10;
            this.progress_cpu.ValueByTransition = 10;
            // 
            // progress_ram
            // 
            this.progress_ram.AllowAnimations = false;
            this.progress_ram.Animation = 0;
            this.progress_ram.AnimationSpeed = 220;
            this.progress_ram.AnimationStep = 10;
            this.progress_ram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_ram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progress_ram.BackgroundImage")));
            this.progress_ram.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_ram.BorderRadius = 9;
            this.progress_ram.BorderThickness = 1;
            this.progress_ram.Location = new System.Drawing.Point(41, 61);
            this.progress_ram.Maximum = 100;
            this.progress_ram.MaximumValue = 100;
            this.progress_ram.Minimum = 0;
            this.progress_ram.MinimumValue = 0;
            this.progress_ram.Name = "progress_ram";
            this.progress_ram.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progress_ram.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_ram.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.progress_ram.ProgressColorRight = System.Drawing.Color.DodgerBlue;
            this.progress_ram.Size = new System.Drawing.Size(245, 13);
            this.progress_ram.TabIndex = 17;
            this.progress_ram.Value = 10;
            this.progress_ram.ValueByTransition = 10;
            // 
            // chart_cpu
            // 
            this.chart_cpu.BackColor = System.Drawing.Color.Transparent;
            this.chart_cpu.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.LabelStyle.Enabled = false;
            chartArea3.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisX.LogarithmBase = 5D;
            chartArea3.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea3.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea3.Name = "ChartArea1";
            this.chart_cpu.ChartAreas.Add(chartArea3);
            this.chart_cpu.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart_cpu.Legends.Add(legend3);
            this.chart_cpu.Location = new System.Drawing.Point(3, 3);
            this.chart_cpu.Name = "chart_cpu";
            this.chart_cpu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Legend = "Legend1";
            series3.Name = "CPU";
            this.chart_cpu.Series.Add(series3);
            this.chart_cpu.Size = new System.Drawing.Size(330, 276);
            this.chart_cpu.TabIndex = 18;
            this.chart_cpu.Text = "chart1";
            // 
            // chart_ram
            // 
            this.chart_ram.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart_ram.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea4.AxisX.IsMarginVisible = false;
            chartArea4.AxisX.LabelStyle.Enabled = false;
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea4.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Empty;
            chartArea4.AxisX.TitleForeColor = System.Drawing.Color.Empty;
            chartArea4.AxisY.IsMarginVisible = false;
            chartArea4.Name = "ChartArea1";
            this.chart_ram.ChartAreas.Add(chartArea4);
            this.chart_ram.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chart_ram.Legends.Add(legend4);
            this.chart_ram.Location = new System.Drawing.Point(3, 3);
            this.chart_ram.Name = "chart_ram";
            this.chart_ram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series4.BorderColor = System.Drawing.Color.Red;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series4.Legend = "Legend1";
            series4.Name = "RAM";
            this.chart_ram.Series.Add(series4);
            this.chart_ram.Size = new System.Drawing.Size(330, 276);
            this.chart_ram.TabIndex = 18;
            this.chart_ram.Text = "chart1";
            // 
            // lbl_cpu
            // 
            this.lbl_cpu.AutoSize = true;
            this.lbl_cpu.Location = new System.Drawing.Point(3, 16);
            this.lbl_cpu.Name = "lbl_cpu";
            this.lbl_cpu.Size = new System.Drawing.Size(32, 13);
            this.lbl_cpu.TabIndex = 20;
            this.lbl_cpu.Text = "CPU:";
            // 
            // lbl_ram
            // 
            this.lbl_ram.AutoSize = true;
            this.lbl_ram.Location = new System.Drawing.Point(3, 61);
            this.lbl_ram.Name = "lbl_ram";
            this.lbl_ram.Size = new System.Drawing.Size(34, 13);
            this.lbl_ram.TabIndex = 20;
            this.lbl_ram.Text = "RAM:";
            // 
            // lbl_cpu_stat
            // 
            this.lbl_cpu_stat.AutoSize = true;
            this.lbl_cpu_stat.Location = new System.Drawing.Point(292, 16);
            this.lbl_cpu_stat.Name = "lbl_cpu_stat";
            this.lbl_cpu_stat.Size = new System.Drawing.Size(21, 13);
            this.lbl_cpu_stat.TabIndex = 20;
            this.lbl_cpu_stat.Text = "0%";
            // 
            // lbl_ram_stat
            // 
            this.lbl_ram_stat.AutoSize = true;
            this.lbl_ram_stat.Location = new System.Drawing.Point(292, 61);
            this.lbl_ram_stat.Name = "lbl_ram_stat";
            this.lbl_ram_stat.Size = new System.Drawing.Size(21, 13);
            this.lbl_ram_stat.TabIndex = 20;
            this.lbl_ram_stat.Text = "0%";
            // 
            // tab_main
            // 
            this.tab_main.Controls.Add(this.apps);
            this.tab_main.Controls.Add(this.cpu);
            this.tab_main.Controls.Add(this.ram);
            this.tab_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tab_main.Location = new System.Drawing.Point(0, 93);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(344, 308);
            this.tab_main.TabIndex = 21;
            // 
            // cpu
            // 
            this.cpu.Controls.Add(this.chart_cpu);
            this.cpu.Location = new System.Drawing.Point(4, 22);
            this.cpu.Name = "cpu";
            this.cpu.Padding = new System.Windows.Forms.Padding(3);
            this.cpu.Size = new System.Drawing.Size(336, 282);
            this.cpu.TabIndex = 0;
            this.cpu.Text = "CPU";
            this.cpu.UseVisualStyleBackColor = true;
            // 
            // ram
            // 
            this.ram.Controls.Add(this.chart_ram);
            this.ram.Location = new System.Drawing.Point(4, 22);
            this.ram.Name = "ram";
            this.ram.Padding = new System.Windows.Forms.Padding(3);
            this.ram.Size = new System.Drawing.Size(336, 282);
            this.ram.TabIndex = 1;
            this.ram.Text = "RAM";
            this.ram.UseVisualStyleBackColor = true;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.lbl_ram);
            this.panel_main.Controls.Add(this.progress_cpu);
            this.panel_main.Controls.Add(this.progress_ram);
            this.panel_main.Controls.Add(this.lbl_ram_stat);
            this.panel_main.Controls.Add(this.lbl_cpu);
            this.panel_main.Controls.Add(this.lbl_cpu_stat);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(344, 93);
            this.panel_main.TabIndex = 22;
            // 
            // apps
            // 
            this.apps.Controls.Add(this.listBox1);
            this.apps.Location = new System.Drawing.Point(4, 22);
            this.apps.Name = "apps";
            this.apps.Size = new System.Drawing.Size(336, 282);
            this.apps.TabIndex = 2;
            this.apps.Text = "Apps";
            this.apps.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(336, 282);
            this.listBox1.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(344, 401);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.tab_main);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 440);
            this.Name = "Home";
            this.Text = "PowerHouse";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ram)).EndInit();
            this.tab_main.ResumeLayout(false);
            this.cpu.ResumeLayout(false);
            this.ram.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.apps.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer;
        private Bunifu.UI.WinForms.BunifuProgressBar progress_cpu;
        private Bunifu.UI.WinForms.BunifuProgressBar progress_ram;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_cpu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ram;
        private System.Windows.Forms.Label lbl_cpu;
        private System.Windows.Forms.Label lbl_ram;
        private System.Windows.Forms.Label lbl_cpu_stat;
        private System.Windows.Forms.Label lbl_ram_stat;
        private System.Windows.Forms.TabControl tab_main;
        private System.Windows.Forms.TabPage cpu;
        private System.Windows.Forms.TabPage ram;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.TabPage apps;
        private System.Windows.Forms.ListBox listBox1;
    }
}

