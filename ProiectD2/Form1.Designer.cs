namespace ProiectD2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxMAX = new System.Windows.Forms.TextBox();
            this.HillClimbingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIteratedHillClimbing = new System.Windows.Forms.Button();
            this.listBoxBestConfiguration = new System.Windows.Forms.ListBox();
            this.numericUpDownRename = new System.Windows.Forms.NumericUpDown();
            this.textBoxSuperscalar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownReorder = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRsb_architecture = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSeparate_dispatch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownInteger = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownFloating = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownBranch = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownMemory = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.labelHCi = new System.Windows.Forms.Label();
            this.HillClimbingSohasticChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SimulatedAnnealingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label13 = new System.Windows.Forms.Label();
            this.btnStochasticHillClimbing = new System.Windows.Forms.Button();
            this.btnSimulatedAnnealing = new System.Windows.Forms.Button();
            this.labelHCs = new System.Windows.Forms.Label();
            this.labelSA = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxTmax = new System.Windows.Forms.TextBox();
            this.textBoxTmin = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HillClimbingChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInteger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFloating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HillClimbingSohasticChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulatedAnnealingChart)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMAX
            // 
            this.textBoxMAX.Location = new System.Drawing.Point(498, 269);
            this.textBoxMAX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMAX.Multiline = true;
            this.textBoxMAX.Name = "textBoxMAX";
            this.textBoxMAX.Size = new System.Drawing.Size(62, 41);
            this.textBoxMAX.TabIndex = 1;
            // 
            // HillClimbingChart
            // 
            chartArea1.Name = "ChartArea1";
            this.HillClimbingChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.HillClimbingChart.Legends.Add(legend1);
            this.HillClimbingChart.Location = new System.Drawing.Point(766, 269);
            this.HillClimbingChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HillClimbingChart.Name = "HillClimbingChart";
            this.HillClimbingChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series1.Legend = "Legend1";
            series1.Name = "ipc";
            series1.YValuesPerPoint = 2;
            this.HillClimbingChart.Series.Add(series1);
            this.HillClimbingChart.Size = new System.Drawing.Size(834, 215);
            this.HillClimbingChart.TabIndex = 2;
            this.HillClimbingChart.Text = "ipcHill";
            this.HillClimbingChart.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose the maximum number of iteration:\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIteratedHillClimbing
            // 
            this.btnIteratedHillClimbing.Location = new System.Drawing.Point(104, 375);
            this.btnIteratedHillClimbing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIteratedHillClimbing.Name = "btnIteratedHillClimbing";
            this.btnIteratedHillClimbing.Size = new System.Drawing.Size(158, 55);
            this.btnIteratedHillClimbing.TabIndex = 4;
            this.btnIteratedHillClimbing.Text = "Iterated HillClimbing";
            this.btnIteratedHillClimbing.UseVisualStyleBackColor = true;
            this.btnIteratedHillClimbing.Click += new System.EventHandler(this.btnIteratedHillClimbing_Click);
            // 
            // listBoxBestConfiguration
            // 
            this.listBoxBestConfiguration.FormattingEnabled = true;
            this.listBoxBestConfiguration.HorizontalScrollbar = true;
            this.listBoxBestConfiguration.ItemHeight = 20;
            this.listBoxBestConfiguration.Location = new System.Drawing.Point(340, 792);
            this.listBoxBestConfiguration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxBestConfiguration.MultiColumn = true;
            this.listBoxBestConfiguration.Name = "listBoxBestConfiguration";
            this.listBoxBestConfiguration.Size = new System.Drawing.Size(220, 264);
            this.listBoxBestConfiguration.TabIndex = 5;
            // 
            // numericUpDownRename
            // 
            this.numericUpDownRename.Location = new System.Drawing.Point(39, 122);
            this.numericUpDownRename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownRename.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericUpDownRename.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRename.Name = "numericUpDownRename";
            this.numericUpDownRename.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownRename.TabIndex = 6;
            this.numericUpDownRename.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxSuperscalar
            // 
            this.textBoxSuperscalar.Location = new System.Drawing.Point(39, 65);
            this.textBoxSuperscalar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSuperscalar.Name = "textBoxSuperscalar";
            this.textBoxSuperscalar.Size = new System.Drawing.Size(62, 26);
            this.textBoxSuperscalar.TabIndex = 7;
            this.textBoxSuperscalar.Text = "1";
            this.textBoxSuperscalar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Choose the initial configuration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "supersclar [1-16] (pow of 2)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "rename [1 - 512]";
            // 
            // numericUpDownReorder
            // 
            this.numericUpDownReorder.Location = new System.Drawing.Point(39, 177);
            this.numericUpDownReorder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownReorder.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericUpDownReorder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownReorder.Name = "numericUpDownReorder";
            this.numericUpDownReorder.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownReorder.TabIndex = 11;
            this.numericUpDownReorder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "reorder [1 - 512]";
            // 
            // textBoxRsb_architecture
            // 
            this.textBoxRsb_architecture.Location = new System.Drawing.Point(399, 85);
            this.textBoxRsb_architecture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRsb_architecture.Name = "textBoxRsb_architecture";
            this.textBoxRsb_architecture.Size = new System.Drawing.Size(106, 26);
            this.textBoxRsb_architecture.TabIndex = 13;
            this.textBoxRsb_architecture.Text = "distributed";
            this.textBoxRsb_architecture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(516, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(429, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "rsb_architecture [distributed,  centralized, hybrid]";
            // 
            // textBoxSeparate_dispatch
            // 
            this.textBoxSeparate_dispatch.Location = new System.Drawing.Point(399, 142);
            this.textBoxSeparate_dispatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSeparate_dispatch.Name = "textBoxSeparate_dispatch";
            this.textBoxSeparate_dispatch.Size = new System.Drawing.Size(62, 26);
            this.textBoxSeparate_dispatch.TabIndex = 15;
            this.textBoxSeparate_dispatch.Text = "false";
            this.textBoxSeparate_dispatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(472, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "separate_dispatch [ true, false]";
            // 
            // numericUpDownInteger
            // 
            this.numericUpDownInteger.Location = new System.Drawing.Point(1078, 28);
            this.numericUpDownInteger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownInteger.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownInteger.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownInteger.Name = "numericUpDownInteger";
            this.numericUpDownInteger.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownInteger.TabIndex = 17;
            this.numericUpDownInteger.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1154, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "integer [1 - 8]";
            // 
            // numericUpDownFloating
            // 
            this.numericUpDownFloating.Location = new System.Drawing.Point(1078, 86);
            this.numericUpDownFloating.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownFloating.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownFloating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFloating.Name = "numericUpDownFloating";
            this.numericUpDownFloating.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownFloating.TabIndex = 19;
            this.numericUpDownFloating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1155, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "floating [1 - 8]";
            // 
            // numericUpDownBranch
            // 
            this.numericUpDownBranch.Location = new System.Drawing.Point(1078, 143);
            this.numericUpDownBranch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownBranch.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownBranch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBranch.Name = "numericUpDownBranch";
            this.numericUpDownBranch.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownBranch.TabIndex = 21;
            this.numericUpDownBranch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1155, 146);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "branch [1 - 8]";
            // 
            // numericUpDownMemory
            // 
            this.numericUpDownMemory.Location = new System.Drawing.Point(1078, 200);
            this.numericUpDownMemory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownMemory.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownMemory.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMemory.Name = "numericUpDownMemory";
            this.numericUpDownMemory.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownMemory.TabIndex = 23;
            this.numericUpDownMemory.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1152, 203);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "memory [1 - 8]";
            // 
            // labelHCi
            // 
            this.labelHCi.AutoSize = true;
            this.labelHCi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHCi.Location = new System.Drawing.Point(824, 235);
            this.labelHCi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHCi.Name = "labelHCi";
            this.labelHCi.Size = new System.Drawing.Size(287, 25);
            this.labelHCi.TabIndex = 26;
            this.labelHCi.Text = "Hill Climbing iterated graphic";
            this.labelHCi.Visible = false;
            // 
            // HillClimbingSohasticChart
            // 
            chartArea2.Name = "ChartArea1";
            this.HillClimbingSohasticChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.HillClimbingSohasticChart.Legends.Add(legend2);
            this.HillClimbingSohasticChart.Location = new System.Drawing.Point(766, 528);
            this.HillClimbingSohasticChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HillClimbingSohasticChart.Name = "HillClimbingSohasticChart";
            this.HillClimbingSohasticChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series2.Legend = "Legend1";
            series2.Name = "ipc";
            series2.YValuesPerPoint = 2;
            this.HillClimbingSohasticChart.Series.Add(series2);
            this.HillClimbingSohasticChart.Size = new System.Drawing.Size(834, 243);
            this.HillClimbingSohasticChart.TabIndex = 27;
            this.HillClimbingSohasticChart.Text = "ipcHill";
            this.HillClimbingSohasticChart.Visible = false;
            // 
            // SimulatedAnnealingChart
            // 
            chartArea3.Name = "ChartArea1";
            this.SimulatedAnnealingChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.SimulatedAnnealingChart.Legends.Add(legend3);
            this.SimulatedAnnealingChart.Location = new System.Drawing.Point(766, 823);
            this.SimulatedAnnealingChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SimulatedAnnealingChart.Name = "SimulatedAnnealingChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series3.Legend = "Legend1";
            series3.Name = "ipc";
            series3.YValuesPerPoint = 2;
            this.SimulatedAnnealingChart.Series.Add(series3);
            this.SimulatedAnnealingChart.Size = new System.Drawing.Size(834, 285);
            this.SimulatedAnnealingChart.TabIndex = 28;
            this.SimulatedAnnealingChart.Text = "ipcHill";
            this.SimulatedAnnealingChart.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(34, 328);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(279, 25);
            this.label13.TabIndex = 29;
            this.label13.Text = "Run the algorithm you want:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStochasticHillClimbing
            // 
            this.btnStochasticHillClimbing.Location = new System.Drawing.Point(104, 468);
            this.btnStochasticHillClimbing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStochasticHillClimbing.Name = "btnStochasticHillClimbing";
            this.btnStochasticHillClimbing.Size = new System.Drawing.Size(158, 55);
            this.btnStochasticHillClimbing.TabIndex = 30;
            this.btnStochasticHillClimbing.Text = "Stochastic HillClimbing";
            this.btnStochasticHillClimbing.UseVisualStyleBackColor = true;
            this.btnStochasticHillClimbing.Click += new System.EventHandler(this.btnStochasticHillClimbing_Click);
            // 
            // btnSimulatedAnnealing
            // 
            this.btnSimulatedAnnealing.Location = new System.Drawing.Point(104, 563);
            this.btnSimulatedAnnealing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSimulatedAnnealing.Name = "btnSimulatedAnnealing";
            this.btnSimulatedAnnealing.Size = new System.Drawing.Size(158, 55);
            this.btnSimulatedAnnealing.TabIndex = 31;
            this.btnSimulatedAnnealing.Text = "Simulated Annealing";
            this.btnSimulatedAnnealing.UseVisualStyleBackColor = true;
            this.btnSimulatedAnnealing.Click += new System.EventHandler(this.btnSimulatedAnnealing_Click);
            // 
            // labelHCs
            // 
            this.labelHCs.AutoSize = true;
            this.labelHCs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHCs.Location = new System.Drawing.Point(843, 497);
            this.labelHCs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHCs.Name = "labelHCs";
            this.labelHCs.Size = new System.Drawing.Size(301, 25);
            this.labelHCs.TabIndex = 32;
            this.labelHCs.Text = "Hill Climbing stohastic graphic";
            this.labelHCs.Visible = false;
            // 
            // labelSA
            // 
            this.labelSA.AutoSize = true;
            this.labelSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSA.Location = new System.Drawing.Point(843, 792);
            this.labelSA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSA.Name = "labelSA";
            this.labelSA.Size = new System.Drawing.Size(288, 25);
            this.labelSA.TabIndex = 33;
            this.labelSA.Text = "Simulated Annealing graphic";
            this.labelSA.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(34, 895);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(245, 25);
            this.label12.TabIndex = 34;
            this.label12.Text = "Best configuration found";
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(630, 471);
            this.textBoxT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxT.Multiline = true;
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(62, 39);
            this.textBoxT.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(286, 471);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(293, 50);
            this.label14.TabIndex = 36;
            this.label14.Text = "Choose the value of T \r\n(not too high and not too low)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTmax
            // 
            this.textBoxTmax.Location = new System.Drawing.Point(549, 577);
            this.textBoxTmax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTmax.Multiline = true;
            this.textBoxTmax.Name = "textBoxTmax";
            this.textBoxTmax.Size = new System.Drawing.Size(62, 39);
            this.textBoxTmax.TabIndex = 37;
            // 
            // textBoxTmin
            // 
            this.textBoxTmin.Location = new System.Drawing.Point(630, 577);
            this.textBoxTmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTmin.Multiline = true;
            this.textBoxTmin.Name = "textBoxTmin";
            this.textBoxTmin.Size = new System.Drawing.Size(62, 39);
            this.textBoxTmin.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(286, 578);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(211, 50);
            this.label15.TabIndex = 39;
            this.label15.Text = "Choose the value of \r\nTmax and Tmin ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(626, 640);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 25);
            this.label16.TabIndex = 40;
            this.label16.Text = "Tmin ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(542, 640);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 25);
            this.label17.TabIndex = 41;
            this.label17.Text = "Tmax";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 1126);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxTmin);
            this.Controls.Add(this.textBoxTmax);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelSA);
            this.Controls.Add(this.labelHCs);
            this.Controls.Add(this.btnSimulatedAnnealing);
            this.Controls.Add(this.btnStochasticHillClimbing);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SimulatedAnnealingChart);
            this.Controls.Add(this.HillClimbingSohasticChart);
            this.Controls.Add(this.labelHCi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDownMemory);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDownBranch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDownFloating);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDownInteger);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSeparate_dispatch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxRsb_architecture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownReorder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSuperscalar);
            this.Controls.Add(this.numericUpDownRename);
            this.Controls.Add(this.listBoxBestConfiguration);
            this.Controls.Add(this.btnIteratedHillClimbing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HillClimbingChart);
            this.Controls.Add(this.textBoxMAX);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "ProiectD2";
            ((System.ComponentModel.ISupportInitialize)(this.HillClimbingChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInteger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFloating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HillClimbingSohasticChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulatedAnnealingChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxMAX;
        private System.Windows.Forms.DataVisualization.Charting.Chart HillClimbingChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIteratedHillClimbing;
        private System.Windows.Forms.ListBox listBoxBestConfiguration;
        private System.Windows.Forms.NumericUpDown numericUpDownRename;
        private System.Windows.Forms.TextBox textBoxSuperscalar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownReorder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRsb_architecture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSeparate_dispatch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownInteger;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownFloating;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownBranch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownMemory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelHCi;
        private System.Windows.Forms.DataVisualization.Charting.Chart HillClimbingSohasticChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart SimulatedAnnealingChart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnStochasticHillClimbing;
        private System.Windows.Forms.Button btnSimulatedAnnealing;
        private System.Windows.Forms.Label labelHCs;
        private System.Windows.Forms.Label labelSA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxTmax;
        private System.Windows.Forms.TextBox textBoxTmin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

