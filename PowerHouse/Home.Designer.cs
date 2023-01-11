﻿namespace PowerHouse
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.apps = new System.Windows.Forms.TabPage();
            this.list_processes = new System.Windows.Forms.ListBox();
            this.menu_processes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.close = new System.Windows.Forms.ToolStripMenuItem();
            this.cpu = new System.Windows.Forms.TabPage();
            this.ram = new System.Windows.Forms.TabPage();
            this.storage = new System.Windows.Forms.TabPage();
            this.lbl_drive_letter = new System.Windows.Forms.Label();
            this.lbl_drive_format = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.battery = new System.Windows.Forms.TabPage();
            this.panel_main = new System.Windows.Forms.Panel();
            this.lbl_disk = new System.Windows.Forms.Label();
            this.progress_disk = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.lbl_disk_stat = new System.Windows.Forms.Label();
            this.pDISK = new System.Diagnostics.PerformanceCounter();
            this.chart_disk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ram)).BeginInit();
            this.tab_main.SuspendLayout();
            this.apps.SuspendLayout();
            this.menu_processes.SuspendLayout();
            this.cpu.SuspendLayout();
            this.ram.SuspendLayout();
            this.storage.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDISK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_disk)).BeginInit();
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
            this.progress_cpu.ProgressColorRight = System.Drawing.Color.PaleVioletRed;
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
            this.progress_ram.ProgressColorRight = System.Drawing.Color.PaleVioletRed;
            this.progress_ram.Size = new System.Drawing.Size(245, 13);
            this.progress_ram.TabIndex = 17;
            this.progress_ram.Value = 10;
            this.progress_ram.ValueByTransition = 10;
            // 
            // chart_cpu
            // 
            this.chart_cpu.BackColor = System.Drawing.Color.Transparent;
            this.chart_cpu.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.LogarithmBase = 5D;
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowOffset = 6;
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
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            this.chart_cpu.Series.Add(series1);
            this.chart_cpu.Size = new System.Drawing.Size(346, 276);
            this.chart_cpu.TabIndex = 18;
            this.chart_cpu.Text = "chart1";
            // 
            // chart_ram
            // 
            this.chart_ram.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart_ram.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Empty;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.Empty;
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowOffset = 6;
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
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.chart_ram.Series.Add(series2);
            this.chart_ram.Size = new System.Drawing.Size(346, 276);
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
            this.tab_main.Controls.Add(this.storage);
            this.tab_main.Controls.Add(this.battery);
            this.tab_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tab_main.Location = new System.Drawing.Point(0, 138);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(360, 308);
            this.tab_main.TabIndex = 21;
            // 
            // apps
            // 
            this.apps.Controls.Add(this.list_processes);
            this.apps.Location = new System.Drawing.Point(4, 22);
            this.apps.Name = "apps";
            this.apps.Size = new System.Drawing.Size(352, 282);
            this.apps.TabIndex = 2;
            this.apps.Text = "Apps";
            this.apps.UseVisualStyleBackColor = true;
            // 
            // list_processes
            // 
            this.list_processes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_processes.ContextMenuStrip = this.menu_processes;
            this.list_processes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_processes.FormattingEnabled = true;
            this.list_processes.Location = new System.Drawing.Point(0, 0);
            this.list_processes.Name = "list_processes";
            this.list_processes.Size = new System.Drawing.Size(352, 282);
            this.list_processes.TabIndex = 0;
            // 
            // menu_processes
            // 
            this.menu_processes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.close});
            this.menu_processes.Name = "menu_processes";
            this.menu_processes.Size = new System.Drawing.Size(129, 26);
            // 
            // close
            // 
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(128, 22);
            this.close.Text = "Close App";
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // cpu
            // 
            this.cpu.Controls.Add(this.chart_cpu);
            this.cpu.Location = new System.Drawing.Point(4, 22);
            this.cpu.Name = "cpu";
            this.cpu.Padding = new System.Windows.Forms.Padding(3);
            this.cpu.Size = new System.Drawing.Size(352, 282);
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
            this.ram.Size = new System.Drawing.Size(352, 282);
            this.ram.TabIndex = 1;
            this.ram.Text = "RAM";
            this.ram.UseVisualStyleBackColor = true;
            // 
            // storage
            // 
            this.storage.Controls.Add(this.chart_disk);
            this.storage.Controls.Add(this.lbl_drive_letter);
            this.storage.Controls.Add(this.lbl_drive_format);
            this.storage.Controls.Add(this.label1);
            this.storage.Controls.Add(this.lbl_size);
            this.storage.Location = new System.Drawing.Point(4, 22);
            this.storage.Name = "storage";
            this.storage.Size = new System.Drawing.Size(352, 282);
            this.storage.TabIndex = 3;
            this.storage.Text = "Storage";
            this.storage.UseVisualStyleBackColor = true;
            // 
            // lbl_drive_letter
            // 
            this.lbl_drive_letter.AutoSize = true;
            this.lbl_drive_letter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_drive_letter.Location = new System.Drawing.Point(61, 10);
            this.lbl_drive_letter.Name = "lbl_drive_letter";
            this.lbl_drive_letter.Size = new System.Drawing.Size(41, 16);
            this.lbl_drive_letter.TabIndex = 0;
            this.lbl_drive_letter.Text = "Letter";
            // 
            // lbl_drive_format
            // 
            this.lbl_drive_format.AutoSize = true;
            this.lbl_drive_format.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_drive_format.Location = new System.Drawing.Point(278, 9);
            this.lbl_drive_format.Name = "lbl_drive_format";
            this.lbl_drive_format.Size = new System.Drawing.Size(54, 17);
            this.lbl_drive_format.TabIndex = 0;
            this.lbl_drive_format.Text = "Format";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Storage: ";
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Bold);
            this.lbl_size.Location = new System.Drawing.Point(8, 37);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(104, 52);
            this.lbl_size.TabIndex = 0;
            this.lbl_size.Text = "0GB";
            // 
            // battery
            // 
            this.battery.Location = new System.Drawing.Point(4, 22);
            this.battery.Name = "battery";
            this.battery.Size = new System.Drawing.Size(336, 282);
            this.battery.TabIndex = 4;
            this.battery.Text = "Battery";
            this.battery.UseVisualStyleBackColor = true;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.lbl_disk);
            this.panel_main.Controls.Add(this.lbl_ram);
            this.panel_main.Controls.Add(this.progress_cpu);
            this.panel_main.Controls.Add(this.progress_disk);
            this.panel_main.Controls.Add(this.lbl_disk_stat);
            this.panel_main.Controls.Add(this.progress_ram);
            this.panel_main.Controls.Add(this.lbl_ram_stat);
            this.panel_main.Controls.Add(this.lbl_cpu);
            this.panel_main.Controls.Add(this.lbl_cpu_stat);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(360, 138);
            this.panel_main.TabIndex = 22;
            // 
            // lbl_disk
            // 
            this.lbl_disk.AutoSize = true;
            this.lbl_disk.Location = new System.Drawing.Point(3, 105);
            this.lbl_disk.Name = "lbl_disk";
            this.lbl_disk.Size = new System.Drawing.Size(35, 13);
            this.lbl_disk.TabIndex = 20;
            this.lbl_disk.Text = "DISK:";
            // 
            // progress_disk
            // 
            this.progress_disk.AllowAnimations = false;
            this.progress_disk.Animation = 0;
            this.progress_disk.AnimationSpeed = 220;
            this.progress_disk.AnimationStep = 10;
            this.progress_disk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_disk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progress_disk.BackgroundImage")));
            this.progress_disk.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_disk.BorderRadius = 9;
            this.progress_disk.BorderThickness = 1;
            this.progress_disk.Location = new System.Drawing.Point(41, 105);
            this.progress_disk.Maximum = 100;
            this.progress_disk.MaximumValue = 100;
            this.progress_disk.Minimum = 0;
            this.progress_disk.MinimumValue = 0;
            this.progress_disk.Name = "progress_disk";
            this.progress_disk.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progress_disk.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_disk.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.progress_disk.ProgressColorRight = System.Drawing.Color.PaleVioletRed;
            this.progress_disk.Size = new System.Drawing.Size(245, 13);
            this.progress_disk.TabIndex = 17;
            this.progress_disk.Value = 10;
            this.progress_disk.ValueByTransition = 10;
            // 
            // lbl_disk_stat
            // 
            this.lbl_disk_stat.AutoSize = true;
            this.lbl_disk_stat.Location = new System.Drawing.Point(292, 105);
            this.lbl_disk_stat.Name = "lbl_disk_stat";
            this.lbl_disk_stat.Size = new System.Drawing.Size(21, 13);
            this.lbl_disk_stat.TabIndex = 20;
            this.lbl_disk_stat.Text = "0%";
            // 
            // pDISK
            // 
            this.pDISK.CategoryName = "PhysicalDisk";
            this.pDISK.CounterName = "Disk Write Bytes/sec";
            this.pDISK.InstanceName = "_Total";
            // 
            // chart_disk
            // 
            this.chart_disk.BackColor = System.Drawing.Color.Transparent;
            this.chart_disk.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.LabelStyle.Enabled = false;
            chartArea3.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisX.LogarithmBase = 5D;
            chartArea3.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea3.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisY.Maximum = 100D;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowOffset = 6;
            this.chart_disk.ChartAreas.Add(chartArea3);
            this.chart_disk.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart_disk.Legends.Add(legend3);
            this.chart_disk.Location = new System.Drawing.Point(0, 92);
            this.chart_disk.Name = "chart_disk";
            this.chart_disk.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Legend = "Legend1";
            series3.Name = "DISK";
            this.chart_disk.Series.Add(series3);
            this.chart_disk.Size = new System.Drawing.Size(352, 190);
            this.chart_disk.TabIndex = 19;
            this.chart_disk.Text = "chart1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 446);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.tab_main);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 440);
            this.Name = "Home";
            this.Text = "PowerHouse";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ram)).EndInit();
            this.tab_main.ResumeLayout(false);
            this.apps.ResumeLayout(false);
            this.menu_processes.ResumeLayout(false);
            this.cpu.ResumeLayout(false);
            this.ram.ResumeLayout(false);
            this.storage.ResumeLayout(false);
            this.storage.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDISK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_disk)).EndInit();
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
        private System.Windows.Forms.ListBox list_processes;
        private System.Windows.Forms.ContextMenuStrip menu_processes;
        private System.Windows.Forms.ToolStripMenuItem close;
        private System.Windows.Forms.TabPage storage;
        private System.Windows.Forms.TabPage battery;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label lbl_drive_letter;
        private System.Windows.Forms.Label lbl_drive_format;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_disk;
        private Bunifu.UI.WinForms.BunifuProgressBar progress_disk;
        private System.Windows.Forms.Label lbl_disk_stat;
        private System.Diagnostics.PerformanceCounter pDISK;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_disk;
    }
}

