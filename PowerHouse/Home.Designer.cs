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
            this.system = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_gpu_stats = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_storage_info = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.apps = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.list_processes = new System.Windows.Forms.ListBox();
            this.menu_processes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.close = new System.Windows.Forms.ToolStripMenuItem();
            this.cpu = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_cpu_model = new System.Windows.Forms.Label();
            this.ram = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbl_ram_info = new System.Windows.Forms.Label();
            this.storage = new System.Windows.Forms.TabPage();
            this.lbl_space = new System.Windows.Forms.Label();
            this.chart_disk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_read = new System.Windows.Forms.Label();
            this.lbl_disk = new System.Windows.Forms.Label();
            this.progress_storage = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.lbl_storage_stat = new System.Windows.Forms.Label();
            this.progress_read = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.lbl_read_stat = new System.Windows.Forms.Label();
            this.progress_write = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.lbl_disk_stat = new System.Windows.Forms.Label();
            this.battery = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.progress_battery = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.lbl_battery_stat = new System.Windows.Forms.Label();
            this.lbl_battery_info = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.network = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.pWRITE = new System.Diagnostics.PerformanceCounter();
            this.pREAD = new System.Diagnostics.PerformanceCounter();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ram)).BeginInit();
            this.tab_main.SuspendLayout();
            this.system.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.apps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menu_processes.SuspendLayout();
            this.cpu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.ram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.storage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_disk)).BeginInit();
            this.battery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.network.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pWRITE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREAD)).BeginInit();
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
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
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
            this.progress_cpu.Location = new System.Drawing.Point(54, 16);
            this.progress_cpu.Maximum = 100;
            this.progress_cpu.MaximumValue = 100;
            this.progress_cpu.Minimum = 0;
            this.progress_cpu.MinimumValue = 0;
            this.progress_cpu.Name = "progress_cpu";
            this.progress_cpu.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progress_cpu.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_cpu.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.progress_cpu.ProgressColorRight = System.Drawing.Color.Crimson;
            this.progress_cpu.Size = new System.Drawing.Size(255, 13);
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
            this.progress_ram.Location = new System.Drawing.Point(54, 61);
            this.progress_ram.Maximum = 100;
            this.progress_ram.MaximumValue = 100;
            this.progress_ram.Minimum = 0;
            this.progress_ram.MinimumValue = 0;
            this.progress_ram.Name = "progress_ram";
            this.progress_ram.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progress_ram.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_ram.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.progress_ram.ProgressColorRight = System.Drawing.Color.Crimson;
            this.progress_ram.Size = new System.Drawing.Size(255, 13);
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
            this.chart_cpu.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart_cpu.Legends.Add(legend1);
            this.chart_cpu.Location = new System.Drawing.Point(3, 85);
            this.chart_cpu.Name = "chart_cpu";
            this.chart_cpu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            this.chart_cpu.Series.Add(series1);
            this.chart_cpu.Size = new System.Drawing.Size(352, 178);
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
            this.chart_ram.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart_ram.Legends.Add(legend2);
            this.chart_ram.Location = new System.Drawing.Point(3, 85);
            this.chart_ram.Name = "chart_ram";
            this.chart_ram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series2.BorderColor = System.Drawing.Color.Red;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.chart_ram.Series.Add(series2);
            this.chart_ram.Size = new System.Drawing.Size(352, 178);
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
            this.lbl_cpu_stat.Location = new System.Drawing.Point(315, 16);
            this.lbl_cpu_stat.Name = "lbl_cpu_stat";
            this.lbl_cpu_stat.Size = new System.Drawing.Size(21, 13);
            this.lbl_cpu_stat.TabIndex = 20;
            this.lbl_cpu_stat.Text = "0%";
            // 
            // lbl_ram_stat
            // 
            this.lbl_ram_stat.AutoSize = true;
            this.lbl_ram_stat.Location = new System.Drawing.Point(315, 61);
            this.lbl_ram_stat.Name = "lbl_ram_stat";
            this.lbl_ram_stat.Size = new System.Drawing.Size(21, 13);
            this.lbl_ram_stat.TabIndex = 20;
            this.lbl_ram_stat.Text = "0%";
            // 
            // tab_main
            // 
            this.tab_main.Controls.Add(this.system);
            this.tab_main.Controls.Add(this.apps);
            this.tab_main.Controls.Add(this.cpu);
            this.tab_main.Controls.Add(this.ram);
            this.tab_main.Controls.Add(this.storage);
            this.tab_main.Controls.Add(this.battery);
            this.tab_main.Controls.Add(this.network);
            this.tab_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tab_main.Location = new System.Drawing.Point(0, 109);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(366, 292);
            this.tab_main.TabIndex = 21;
            this.tab_main.SelectedIndexChanged += new System.EventHandler(this.Tab_main_SelectedIndexChanged);
            // 
            // system
            // 
            this.system.AutoScroll = true;
            this.system.BackColor = System.Drawing.Color.White;
            this.system.Controls.Add(this.groupBox2);
            this.system.Controls.Add(this.groupBox1);
            this.system.Location = new System.Drawing.Point(4, 22);
            this.system.Name = "system";
            this.system.Size = new System.Drawing.Size(358, 266);
            this.system.TabIndex = 5;
            this.system.Text = "System";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_gpu_stats);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Location = new System.Drawing.Point(8, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 144);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Graphics Processor";
            // 
            // lbl_gpu_stats
            // 
            this.lbl_gpu_stats.AutoSize = true;
            this.lbl_gpu_stats.Font = new System.Drawing.Font("Roboto", 9F);
            this.lbl_gpu_stats.Location = new System.Drawing.Point(6, 16);
            this.lbl_gpu_stats.Name = "lbl_gpu_stats";
            this.lbl_gpu_stats.Size = new System.Drawing.Size(55, 14);
            this.lbl_gpu_stats.TabIndex = 23;
            this.lbl_gpu_stats.Text = "GPU info";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(268, 16);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(74, 117);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_storage_info);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 110);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operating System";
            // 
            // lbl_storage_info
            // 
            this.lbl_storage_info.AutoSize = true;
            this.lbl_storage_info.Font = new System.Drawing.Font("Roboto", 9F);
            this.lbl_storage_info.Location = new System.Drawing.Point(6, 16);
            this.lbl_storage_info.Name = "lbl_storage_info";
            this.lbl_storage_info.Size = new System.Drawing.Size(71, 14);
            this.lbl_storage_info.TabIndex = 1;
            this.lbl_storage_info.Text = "System info";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(268, 16);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(68, 88);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // apps
            // 
            this.apps.Controls.Add(this.pictureBox2);
            this.apps.Controls.Add(this.list_processes);
            this.apps.Location = new System.Drawing.Point(4, 22);
            this.apps.Name = "apps";
            this.apps.Size = new System.Drawing.Size(358, 266);
            this.apps.TabIndex = 2;
            this.apps.Text = "Apps";
            this.apps.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(181, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // list_processes
            // 
            this.list_processes.BackColor = System.Drawing.Color.White;
            this.list_processes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_processes.ContextMenuStrip = this.menu_processes;
            this.list_processes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_processes.Font = new System.Drawing.Font("Roboto", 9F);
            this.list_processes.FormattingEnabled = true;
            this.list_processes.ItemHeight = 14;
            this.list_processes.Location = new System.Drawing.Point(0, 0);
            this.list_processes.Name = "list_processes";
            this.list_processes.Size = new System.Drawing.Size(358, 266);
            this.list_processes.TabIndex = 0;
            this.list_processes.SelectedIndexChanged += new System.EventHandler(this.List_processes_SelectedIndexChanged);
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
            this.cpu.BackColor = System.Drawing.Color.White;
            this.cpu.Controls.Add(this.pictureBox3);
            this.cpu.Controls.Add(this.lbl_cpu_model);
            this.cpu.Controls.Add(this.chart_cpu);
            this.cpu.Location = new System.Drawing.Point(4, 22);
            this.cpu.Name = "cpu";
            this.cpu.Padding = new System.Windows.Forms.Padding(3);
            this.cpu.Size = new System.Drawing.Size(358, 266);
            this.cpu.TabIndex = 0;
            this.cpu.Text = "CPU";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(227, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(103, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_cpu_model
            // 
            this.lbl_cpu_model.AutoSize = true;
            this.lbl_cpu_model.Font = new System.Drawing.Font("Roboto", 9F);
            this.lbl_cpu_model.Location = new System.Drawing.Point(8, 12);
            this.lbl_cpu_model.Name = "lbl_cpu_model";
            this.lbl_cpu_model.Size = new System.Drawing.Size(55, 14);
            this.lbl_cpu_model.TabIndex = 19;
            this.lbl_cpu_model.Text = "CPU info";
            // 
            // ram
            // 
            this.ram.BackColor = System.Drawing.Color.White;
            this.ram.Controls.Add(this.pictureBox4);
            this.ram.Controls.Add(this.lbl_ram_info);
            this.ram.Controls.Add(this.chart_ram);
            this.ram.Location = new System.Drawing.Point(4, 22);
            this.ram.Name = "ram";
            this.ram.Padding = new System.Windows.Forms.Padding(3);
            this.ram.Size = new System.Drawing.Size(358, 266);
            this.ram.TabIndex = 1;
            this.ram.Text = "RAM";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(213, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(117, 73);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // lbl_ram_info
            // 
            this.lbl_ram_info.AutoSize = true;
            this.lbl_ram_info.Font = new System.Drawing.Font("Roboto", 9F);
            this.lbl_ram_info.Location = new System.Drawing.Point(8, 12);
            this.lbl_ram_info.Name = "lbl_ram_info";
            this.lbl_ram_info.Size = new System.Drawing.Size(56, 14);
            this.lbl_ram_info.TabIndex = 19;
            this.lbl_ram_info.Text = "RAM info";
            // 
            // storage
            // 
            this.storage.BackColor = System.Drawing.Color.White;
            this.storage.Controls.Add(this.lbl_space);
            this.storage.Controls.Add(this.chart_disk);
            this.storage.Controls.Add(this.lbl_read);
            this.storage.Controls.Add(this.lbl_disk);
            this.storage.Controls.Add(this.progress_storage);
            this.storage.Controls.Add(this.lbl_storage_stat);
            this.storage.Controls.Add(this.progress_read);
            this.storage.Controls.Add(this.lbl_read_stat);
            this.storage.Controls.Add(this.progress_write);
            this.storage.Controls.Add(this.lbl_disk_stat);
            this.storage.Location = new System.Drawing.Point(4, 22);
            this.storage.Name = "storage";
            this.storage.Size = new System.Drawing.Size(358, 266);
            this.storage.TabIndex = 3;
            this.storage.Text = "Storage";
            // 
            // lbl_space
            // 
            this.lbl_space.AutoSize = true;
            this.lbl_space.Font = new System.Drawing.Font("Roboto", 7F);
            this.lbl_space.Location = new System.Drawing.Point(3, 14);
            this.lbl_space.Name = "lbl_space";
            this.lbl_space.Size = new System.Drawing.Size(36, 13);
            this.lbl_space.TabIndex = 20;
            this.lbl_space.Text = "Space:";
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
            this.chart_disk.Location = new System.Drawing.Point(0, 88);
            this.chart_disk.Name = "chart_disk";
            this.chart_disk.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Legend = "Legend1";
            series3.Name = "DISK";
            this.chart_disk.Series.Add(series3);
            this.chart_disk.Size = new System.Drawing.Size(358, 178);
            this.chart_disk.TabIndex = 19;
            this.chart_disk.Text = "chart1";
            // 
            // lbl_read
            // 
            this.lbl_read.AutoSize = true;
            this.lbl_read.Font = new System.Drawing.Font("Roboto", 7F);
            this.lbl_read.Location = new System.Drawing.Point(2, 41);
            this.lbl_read.Name = "lbl_read";
            this.lbl_read.Size = new System.Drawing.Size(31, 13);
            this.lbl_read.TabIndex = 20;
            this.lbl_read.Text = "Read:";
            // 
            // lbl_disk
            // 
            this.lbl_disk.AutoSize = true;
            this.lbl_disk.Font = new System.Drawing.Font("Roboto", 7F);
            this.lbl_disk.Location = new System.Drawing.Point(2, 71);
            this.lbl_disk.Name = "lbl_disk";
            this.lbl_disk.Size = new System.Drawing.Size(31, 13);
            this.lbl_disk.TabIndex = 20;
            this.lbl_disk.Text = "Write:";
            // 
            // progress_storage
            // 
            this.progress_storage.AllowAnimations = false;
            this.progress_storage.Animation = 0;
            this.progress_storage.AnimationSpeed = 220;
            this.progress_storage.AnimationStep = 10;
            this.progress_storage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_storage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progress_storage.BackgroundImage")));
            this.progress_storage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_storage.BorderRadius = 9;
            this.progress_storage.BorderThickness = 1;
            this.progress_storage.Location = new System.Drawing.Point(50, 14);
            this.progress_storage.Maximum = 100;
            this.progress_storage.MaximumValue = 100;
            this.progress_storage.Minimum = 0;
            this.progress_storage.MinimumValue = 0;
            this.progress_storage.Name = "progress_storage";
            this.progress_storage.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progress_storage.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_storage.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.progress_storage.ProgressColorRight = System.Drawing.Color.Crimson;
            this.progress_storage.Size = new System.Drawing.Size(255, 13);
            this.progress_storage.TabIndex = 17;
            this.progress_storage.Value = 10;
            this.progress_storage.ValueByTransition = 10;
            // 
            // lbl_storage_stat
            // 
            this.lbl_storage_stat.AutoSize = true;
            this.lbl_storage_stat.Font = new System.Drawing.Font("Roboto", 7F);
            this.lbl_storage_stat.Location = new System.Drawing.Point(311, 14);
            this.lbl_storage_stat.Name = "lbl_storage_stat";
            this.lbl_storage_stat.Size = new System.Drawing.Size(20, 13);
            this.lbl_storage_stat.TabIndex = 20;
            this.lbl_storage_stat.Text = "0%";
            // 
            // progress_read
            // 
            this.progress_read.AllowAnimations = false;
            this.progress_read.Animation = 0;
            this.progress_read.AnimationSpeed = 220;
            this.progress_read.AnimationStep = 10;
            this.progress_read.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_read.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progress_read.BackgroundImage")));
            this.progress_read.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_read.BorderRadius = 9;
            this.progress_read.BorderThickness = 1;
            this.progress_read.Location = new System.Drawing.Point(50, 42);
            this.progress_read.Maximum = 100;
            this.progress_read.MaximumValue = 100;
            this.progress_read.Minimum = 0;
            this.progress_read.MinimumValue = 0;
            this.progress_read.Name = "progress_read";
            this.progress_read.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progress_read.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_read.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.progress_read.ProgressColorRight = System.Drawing.Color.PaleVioletRed;
            this.progress_read.Size = new System.Drawing.Size(255, 13);
            this.progress_read.TabIndex = 17;
            this.progress_read.Value = 10;
            this.progress_read.ValueByTransition = 10;
            // 
            // lbl_read_stat
            // 
            this.lbl_read_stat.AutoSize = true;
            this.lbl_read_stat.Font = new System.Drawing.Font("Roboto", 7F);
            this.lbl_read_stat.Location = new System.Drawing.Point(311, 42);
            this.lbl_read_stat.Name = "lbl_read_stat";
            this.lbl_read_stat.Size = new System.Drawing.Size(20, 13);
            this.lbl_read_stat.TabIndex = 20;
            this.lbl_read_stat.Text = "0%";
            // 
            // progress_write
            // 
            this.progress_write.AllowAnimations = false;
            this.progress_write.Animation = 0;
            this.progress_write.AnimationSpeed = 220;
            this.progress_write.AnimationStep = 10;
            this.progress_write.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_write.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progress_write.BackgroundImage")));
            this.progress_write.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_write.BorderRadius = 9;
            this.progress_write.BorderThickness = 1;
            this.progress_write.Location = new System.Drawing.Point(50, 72);
            this.progress_write.Maximum = 100;
            this.progress_write.MaximumValue = 100;
            this.progress_write.Minimum = 0;
            this.progress_write.MinimumValue = 0;
            this.progress_write.Name = "progress_write";
            this.progress_write.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progress_write.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_write.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.progress_write.ProgressColorRight = System.Drawing.Color.PaleVioletRed;
            this.progress_write.Size = new System.Drawing.Size(255, 13);
            this.progress_write.TabIndex = 17;
            this.progress_write.Value = 10;
            this.progress_write.ValueByTransition = 10;
            // 
            // lbl_disk_stat
            // 
            this.lbl_disk_stat.AutoSize = true;
            this.lbl_disk_stat.Font = new System.Drawing.Font("Roboto", 7F);
            this.lbl_disk_stat.Location = new System.Drawing.Point(311, 72);
            this.lbl_disk_stat.Name = "lbl_disk_stat";
            this.lbl_disk_stat.Size = new System.Drawing.Size(20, 13);
            this.lbl_disk_stat.TabIndex = 20;
            this.lbl_disk_stat.Text = "0%";
            // 
            // battery
            // 
            this.battery.BackColor = System.Drawing.Color.White;
            this.battery.Controls.Add(this.label2);
            this.battery.Controls.Add(this.progress_battery);
            this.battery.Controls.Add(this.lbl_battery_stat);
            this.battery.Controls.Add(this.lbl_battery_info);
            this.battery.Controls.Add(this.pictureBox1);
            this.battery.Location = new System.Drawing.Point(4, 22);
            this.battery.Name = "battery";
            this.battery.Size = new System.Drawing.Size(358, 266);
            this.battery.TabIndex = 4;
            this.battery.Text = "Battery";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 7F);
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Charge:";
            // 
            // progress_battery
            // 
            this.progress_battery.AllowAnimations = false;
            this.progress_battery.Animation = 0;
            this.progress_battery.AnimationSpeed = 220;
            this.progress_battery.AnimationStep = 10;
            this.progress_battery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_battery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progress_battery.BackgroundImage")));
            this.progress_battery.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_battery.BorderRadius = 9;
            this.progress_battery.BorderThickness = 1;
            this.progress_battery.Location = new System.Drawing.Point(50, 14);
            this.progress_battery.Maximum = 100;
            this.progress_battery.MaximumValue = 100;
            this.progress_battery.Minimum = 0;
            this.progress_battery.MinimumValue = 0;
            this.progress_battery.Name = "progress_battery";
            this.progress_battery.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progress_battery.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progress_battery.ProgressColorLeft = System.Drawing.Color.Crimson;
            this.progress_battery.ProgressColorRight = System.Drawing.Color.DodgerBlue;
            this.progress_battery.Size = new System.Drawing.Size(255, 13);
            this.progress_battery.TabIndex = 21;
            this.progress_battery.Value = 10;
            this.progress_battery.ValueByTransition = 10;
            // 
            // lbl_battery_stat
            // 
            this.lbl_battery_stat.AutoSize = true;
            this.lbl_battery_stat.Font = new System.Drawing.Font("Roboto", 7F);
            this.lbl_battery_stat.Location = new System.Drawing.Point(311, 14);
            this.lbl_battery_stat.Name = "lbl_battery_stat";
            this.lbl_battery_stat.Size = new System.Drawing.Size(20, 13);
            this.lbl_battery_stat.TabIndex = 23;
            this.lbl_battery_stat.Text = "0%";
            // 
            // lbl_battery_info
            // 
            this.lbl_battery_info.AutoSize = true;
            this.lbl_battery_info.Font = new System.Drawing.Font("Roboto", 9F);
            this.lbl_battery_info.Location = new System.Drawing.Point(17, 43);
            this.lbl_battery_info.Name = "lbl_battery_info";
            this.lbl_battery_info.Size = new System.Drawing.Size(69, 14);
            this.lbl_battery_info.TabIndex = 20;
            this.lbl_battery_info.Text = "Battery info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(257, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // network
            // 
            this.network.BackColor = System.Drawing.Color.White;
            this.network.Controls.Add(this.label1);
            this.network.Controls.Add(this.pictureBox7);
            this.network.Location = new System.Drawing.Point(4, 22);
            this.network.Name = "network";
            this.network.Size = new System.Drawing.Size(358, 266);
            this.network.TabIndex = 7;
            this.network.Text = "Network";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F);
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 23;
            this.label1.Text = "GPU info";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(244, 152);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(106, 106);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 22;
            this.pictureBox7.TabStop = false;
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
            this.panel_main.Size = new System.Drawing.Size(366, 109);
            this.panel_main.TabIndex = 22;
            // 
            // pWRITE
            // 
            this.pWRITE.CategoryName = "PhysicalDisk";
            this.pWRITE.CounterName = "Disk Write Bytes/sec";
            this.pWRITE.InstanceName = "_Total";
            // 
            // pREAD
            // 
            this.pREAD.CategoryName = "PhysicalDisk";
            this.pREAD.CounterName = "Disk Read Bytes/sec";
            this.pREAD.InstanceName = "_Total";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Tick += new System.EventHandler(this.TimerRefresh_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(366, 401);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.tab_main);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 440);
            this.Name = "Home";
            this.Text = "PowerHouse";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ram)).EndInit();
            this.tab_main.ResumeLayout(false);
            this.system.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.apps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menu_processes.ResumeLayout(false);
            this.cpu.ResumeLayout(false);
            this.cpu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ram.ResumeLayout(false);
            this.ram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.storage.ResumeLayout(false);
            this.storage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_disk)).EndInit();
            this.battery.ResumeLayout(false);
            this.battery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.network.ResumeLayout(false);
            this.network.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pWRITE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREAD)).EndInit();
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
        private System.Windows.Forms.Label lbl_disk;
        private Bunifu.UI.WinForms.BunifuProgressBar progress_write;
        private System.Windows.Forms.Label lbl_disk_stat;
        private System.Diagnostics.PerformanceCounter pWRITE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_disk;
        private System.Windows.Forms.Label lbl_cpu_model;
        private System.Windows.Forms.Label lbl_ram_info;
        private System.Windows.Forms.Label lbl_space;
        private Bunifu.UI.WinForms.BunifuProgressBar progress_storage;
        private System.Windows.Forms.Label lbl_storage_stat;
        private System.Windows.Forms.Label lbl_read;
        private Bunifu.UI.WinForms.BunifuProgressBar progress_read;
        private System.Windows.Forms.Label lbl_read_stat;
        private System.Diagnostics.PerformanceCounter pREAD;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.TabPage system;
        private System.Windows.Forms.Label lbl_storage_info;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_battery_info;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lbl_gpu_stats;
        private System.Windows.Forms.TabPage network;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuProgressBar progress_battery;
        private System.Windows.Forms.Label lbl_battery_stat;
    }
}

