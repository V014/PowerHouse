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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.bunifuProgressBarCPU = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.bunifuProgressBarRAM = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.lblRAM = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lblCPU = new MetroFramework.Drawing.Html.HtmlLabel();
            this.chart_cpu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGraph = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_less = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.chart_ram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ram)).BeginInit();
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
            this.bunifuProgressBarCPU.Size = new System.Drawing.Size(444, 13);
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
            this.bunifuProgressBarRAM.Size = new System.Drawing.Size(444, 13);
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
            this.lblRAM.Location = new System.Drawing.Point(515, 108);
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
            this.lblCPU.Location = new System.Drawing.Point(515, 63);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(60, 23);
            this.lblCPU.TabIndex = 2;
            this.lblCPU.Text = "0%";
            // 
            // chart_cpu
            // 
            this.chart_cpu.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart_cpu.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart_cpu.Legends.Add(legend1);
            this.chart_cpu.Location = new System.Drawing.Point(65, 209);
            this.chart_cpu.Name = "chart_cpu";
            this.chart_cpu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.chart_cpu.Series.Add(series1);
            this.chart_cpu.Series.Add(series2);
            this.chart_cpu.Size = new System.Drawing.Size(227, 181);
            this.chart_cpu.TabIndex = 18;
            this.chart_cpu.Text = "chart1";
            // 
            // btnGraph
            // 
            this.btnGraph.AllowAnimations = true;
            this.btnGraph.AllowMouseEffects = true;
            this.btnGraph.AllowToggling = false;
            this.btnGraph.AnimationSpeed = 200;
            this.btnGraph.AutoGenerateColors = false;
            this.btnGraph.AutoRoundBorders = false;
            this.btnGraph.AutoSizeLeftIcon = true;
            this.btnGraph.AutoSizeRightIcon = true;
            this.btnGraph.BackColor = System.Drawing.Color.Transparent;
            this.btnGraph.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnGraph.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGraph.BackgroundImage")));
            this.btnGraph.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGraph.ButtonText = "More";
            this.btnGraph.ButtonTextMarginLeft = 0;
            this.btnGraph.ColorContrastOnClick = 45;
            this.btnGraph.ColorContrastOnHover = 45;
            this.btnGraph.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnGraph.CustomizableEdges = borderEdges1;
            this.btnGraph.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGraph.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGraph.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGraph.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGraph.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnGraph.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGraph.ForeColor = System.Drawing.Color.White;
            this.btnGraph.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraph.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnGraph.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnGraph.IconMarginLeft = 11;
            this.btnGraph.IconPadding = 10;
            this.btnGraph.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGraph.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnGraph.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnGraph.IconSize = 25;
            this.btnGraph.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGraph.IdleBorderRadius = 1;
            this.btnGraph.IdleBorderThickness = 1;
            this.btnGraph.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnGraph.IdleIconLeftImage = null;
            this.btnGraph.IdleIconRightImage = null;
            this.btnGraph.IndicateFocus = false;
            this.btnGraph.Location = new System.Drawing.Point(65, 141);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGraph.OnDisabledState.BorderRadius = 1;
            this.btnGraph.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGraph.OnDisabledState.BorderThickness = 1;
            this.btnGraph.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGraph.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGraph.OnDisabledState.IconLeftImage = null;
            this.btnGraph.OnDisabledState.IconRightImage = null;
            this.btnGraph.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnGraph.onHoverState.BorderRadius = 1;
            this.btnGraph.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGraph.onHoverState.BorderThickness = 1;
            this.btnGraph.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnGraph.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnGraph.onHoverState.IconLeftImage = null;
            this.btnGraph.onHoverState.IconRightImage = null;
            this.btnGraph.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGraph.OnIdleState.BorderRadius = 1;
            this.btnGraph.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGraph.OnIdleState.BorderThickness = 1;
            this.btnGraph.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnGraph.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnGraph.OnIdleState.IconLeftImage = null;
            this.btnGraph.OnIdleState.IconRightImage = null;
            this.btnGraph.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnGraph.OnPressedState.BorderRadius = 1;
            this.btnGraph.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGraph.OnPressedState.BorderThickness = 1;
            this.btnGraph.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnGraph.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnGraph.OnPressedState.IconLeftImage = null;
            this.btnGraph.OnPressedState.IconRightImage = null;
            this.btnGraph.Size = new System.Drawing.Size(67, 39);
            this.btnGraph.TabIndex = 19;
            this.btnGraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGraph.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGraph.TextMarginLeft = 0;
            this.btnGraph.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnGraph.UseDefaultRadiusAndThickness = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btn_less
            // 
            this.btn_less.AllowAnimations = true;
            this.btn_less.AllowMouseEffects = true;
            this.btn_less.AllowToggling = false;
            this.btn_less.AnimationSpeed = 200;
            this.btn_less.AutoGenerateColors = false;
            this.btn_less.AutoRoundBorders = false;
            this.btn_less.AutoSizeLeftIcon = true;
            this.btn_less.AutoSizeRightIcon = true;
            this.btn_less.BackColor = System.Drawing.Color.Transparent;
            this.btn_less.BackColor1 = System.Drawing.Color.Empty;
            this.btn_less.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_less.BackgroundImage")));
            this.btn_less.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_less.ButtonText = "Less";
            this.btn_less.ButtonTextMarginLeft = 0;
            this.btn_less.ColorContrastOnClick = 45;
            this.btn_less.ColorContrastOnHover = 45;
            this.btn_less.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_less.CustomizableEdges = borderEdges2;
            this.btn_less.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_less.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_less.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_less.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_less.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_less.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_less.ForeColor = System.Drawing.Color.Black;
            this.btn_less.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_less.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_less.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_less.IconMarginLeft = 11;
            this.btn_less.IconPadding = 10;
            this.btn_less.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_less.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_less.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_less.IconSize = 25;
            this.btn_less.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_less.IdleBorderRadius = 1;
            this.btn_less.IdleBorderThickness = 1;
            this.btn_less.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_less.IdleIconLeftImage = null;
            this.btn_less.IdleIconRightImage = null;
            this.btn_less.IndicateFocus = false;
            this.btn_less.Location = new System.Drawing.Point(138, 141);
            this.btn_less.Name = "btn_less";
            this.btn_less.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_less.OnDisabledState.BorderRadius = 1;
            this.btn_less.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_less.OnDisabledState.BorderThickness = 1;
            this.btn_less.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_less.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_less.OnDisabledState.IconLeftImage = null;
            this.btn_less.OnDisabledState.IconRightImage = null;
            this.btn_less.onHoverState.BorderColor = System.Drawing.Color.Empty;
            this.btn_less.onHoverState.BorderRadius = 1;
            this.btn_less.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_less.onHoverState.BorderThickness = 1;
            this.btn_less.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_less.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_less.onHoverState.IconLeftImage = null;
            this.btn_less.onHoverState.IconRightImage = null;
            this.btn_less.OnIdleState.BorderColor = System.Drawing.Color.Empty;
            this.btn_less.OnIdleState.BorderRadius = 1;
            this.btn_less.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_less.OnIdleState.BorderThickness = 1;
            this.btn_less.OnIdleState.FillColor = System.Drawing.Color.Empty;
            this.btn_less.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn_less.OnIdleState.IconLeftImage = null;
            this.btn_less.OnIdleState.IconRightImage = null;
            this.btn_less.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_less.OnPressedState.BorderRadius = 1;
            this.btn_less.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_less.OnPressedState.BorderThickness = 1;
            this.btn_less.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_less.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_less.OnPressedState.IconLeftImage = null;
            this.btn_less.OnPressedState.IconRightImage = null;
            this.btn_less.Size = new System.Drawing.Size(67, 39);
            this.btn_less.TabIndex = 19;
            this.btn_less.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_less.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_less.TextMarginLeft = 0;
            this.btn_less.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_less.UseDefaultRadiusAndThickness = true;
            this.btn_less.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // chart_ram
            // 
            this.chart_ram.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart_ram.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart_ram.Legends.Add(legend2);
            this.chart_ram.Location = new System.Drawing.Point(298, 209);
            this.chart_ram.Name = "chart_ram";
            this.chart_ram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "CPU";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "RAM";
            this.chart_ram.Series.Add(series3);
            this.chart_ram.Series.Add(series4);
            this.chart_ram.Size = new System.Drawing.Size(227, 181);
            this.chart_ram.TabIndex = 18;
            this.chart_ram.Text = "chart1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 206);
            this.Controls.Add(this.btn_less);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.chart_ram);
            this.Controls.Add(this.chart_cpu);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.bunifuProgressBarRAM);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.bunifuProgressBarCPU);
            this.Controls.Add(this.htmlLabel1);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Resizable = false;
            this.Text = "PowerHouse";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private Bunifu.UI.WinForms.BunifuProgressBar bunifuProgressBarCPU;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private Bunifu.UI.WinForms.BunifuProgressBar bunifuProgressBarRAM;
        private MetroFramework.Drawing.Html.HtmlLabel lblRAM;
        private MetroFramework.Drawing.Html.HtmlLabel lblCPU;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_cpu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnGraph;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_less;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ram;
    }
}

