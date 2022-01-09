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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.HillClimbingChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInteger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFloating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HillClimbingSohasticChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulatedAnnealingChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMAX
            // 
            this.textBoxMAX.Location = new System.Drawing.Point(263, 23);
            this.textBoxMAX.Multiline = true;
            this.textBoxMAX.Name = "textBoxMAX";
            this.textBoxMAX.Size = new System.Drawing.Size(43, 20);
            this.textBoxMAX.TabIndex = 1;
            // 
            // HillClimbingChart
            // 
            chartArea1.Name = "ChartArea1";
            this.HillClimbingChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.HillClimbingChart.Legends.Add(legend1);
            this.HillClimbingChart.Location = new System.Drawing.Point(719, 71);
            this.HillClimbingChart.Name = "HillClimbingChart";
            this.HillClimbingChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series1.Legend = "Legend1";
            series1.Name = "ipc";
            series1.YValuesPerPoint = 2;
            this.HillClimbingChart.Series.Add(series1);
            this.HillClimbingChart.Size = new System.Drawing.Size(556, 140);
            this.HillClimbingChart.TabIndex = 2;
            this.HillClimbingChart.Text = "ipcHill";
            this.HillClimbingChart.Visible = false;
            this.HillClimbingChart.Click += new System.EventHandler(this.HillClimbingChart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose the maximum number of iteration:\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIteratedHillClimbing
            // 
            this.btnIteratedHillClimbing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIteratedHillClimbing.Location = new System.Drawing.Point(10, 102);
            this.btnIteratedHillClimbing.Name = "btnIteratedHillClimbing";
            this.btnIteratedHillClimbing.Size = new System.Drawing.Size(213, 36);
            this.btnIteratedHillClimbing.TabIndex = 4;
            this.btnIteratedHillClimbing.Text = "Iterated HillClimbing";
            this.btnIteratedHillClimbing.UseVisualStyleBackColor = true;
            this.btnIteratedHillClimbing.Click += new System.EventHandler(this.btnIteratedHillClimbing_Click);
            // 
            // listBoxBestConfiguration
            // 
            this.listBoxBestConfiguration.FormattingEnabled = true;
            this.listBoxBestConfiguration.HorizontalScrollbar = true;
            this.listBoxBestConfiguration.Location = new System.Drawing.Point(25, 584);
            this.listBoxBestConfiguration.MultiColumn = true;
            this.listBoxBestConfiguration.Name = "listBoxBestConfiguration";
            this.listBoxBestConfiguration.Size = new System.Drawing.Size(636, 173);
            this.listBoxBestConfiguration.TabIndex = 5;
            // 
            // numericUpDownRename
            // 
            this.numericUpDownRename.Location = new System.Drawing.Point(207, 72);
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
            this.numericUpDownRename.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownRename.TabIndex = 6;
            this.numericUpDownRename.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxSuperscalar
            // 
            this.textBoxSuperscalar.Location = new System.Drawing.Point(207, 36);
            this.textBoxSuperscalar.Name = "textBoxSuperscalar";
            this.textBoxSuperscalar.Size = new System.Drawing.Size(43, 20);
            this.textBoxSuperscalar.TabIndex = 7;
            this.textBoxSuperscalar.Text = "1";
            this.textBoxSuperscalar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "supersclar [1-16] (pow of 2)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "rename [1 - 512]";
            // 
            // numericUpDownReorder
            // 
            this.numericUpDownReorder.Location = new System.Drawing.Point(207, 108);
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
            this.numericUpDownReorder.Size = new System.Drawing.Size(43, 20);
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
            this.label5.Location = new System.Drawing.Point(19, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "reorder [1 - 512]";
            // 
            // textBoxRsb_architecture
            // 
            this.textBoxRsb_architecture.Location = new System.Drawing.Point(342, 150);
            this.textBoxRsb_architecture.Name = "textBoxRsb_architecture";
            this.textBoxRsb_architecture.Size = new System.Drawing.Size(72, 20);
            this.textBoxRsb_architecture.TabIndex = 13;
            this.textBoxRsb_architecture.Text = "distributed";
            this.textBoxRsb_architecture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "rsb_architecture [distributed,  centralized, hybrid]";
            // 
            // textBoxSeparate_dispatch
            // 
            this.textBoxSeparate_dispatch.Location = new System.Drawing.Point(236, 184);
            this.textBoxSeparate_dispatch.Name = "textBoxSeparate_dispatch";
            this.textBoxSeparate_dispatch.Size = new System.Drawing.Size(43, 20);
            this.textBoxSeparate_dispatch.TabIndex = 15;
            this.textBoxSeparate_dispatch.Text = "false";
            this.textBoxSeparate_dispatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "separate_dispatch [ true, false]";
            // 
            // numericUpDownInteger
            // 
            this.numericUpDownInteger.Location = new System.Drawing.Point(578, 39);
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
            this.numericUpDownInteger.Size = new System.Drawing.Size(43, 20);
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
            this.label8.Location = new System.Drawing.Point(462, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "integer [1 - 8]";
            // 
            // numericUpDownFloating
            // 
            this.numericUpDownFloating.Location = new System.Drawing.Point(578, 77);
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
            this.numericUpDownFloating.Size = new System.Drawing.Size(43, 20);
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
            this.label9.Location = new System.Drawing.Point(462, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "floating [1 - 8]";
            // 
            // numericUpDownBranch
            // 
            this.numericUpDownBranch.Location = new System.Drawing.Point(578, 113);
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
            this.numericUpDownBranch.Size = new System.Drawing.Size(43, 20);
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
            this.label10.Location = new System.Drawing.Point(462, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "branch [1 - 8]";
            // 
            // numericUpDownMemory
            // 
            this.numericUpDownMemory.Location = new System.Drawing.Point(578, 152);
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
            this.numericUpDownMemory.Size = new System.Drawing.Size(43, 20);
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
            this.label11.Location = new System.Drawing.Point(462, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "memory [1 - 8]";
            // 
            // labelHCi
            // 
            this.labelHCi.AutoSize = true;
            this.labelHCi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHCi.Location = new System.Drawing.Point(716, 32);
            this.labelHCi.Name = "labelHCi";
            this.labelHCi.Size = new System.Drawing.Size(178, 16);
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
            this.HillClimbingSohasticChart.Location = new System.Drawing.Point(719, 320);
            this.HillClimbingSohasticChart.Name = "HillClimbingSohasticChart";
            this.HillClimbingSohasticChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series2.Legend = "Legend1";
            series2.Name = "ipc";
            series2.YValuesPerPoint = 2;
            this.HillClimbingSohasticChart.Series.Add(series2);
            this.HillClimbingSohasticChart.Size = new System.Drawing.Size(556, 158);
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
            this.SimulatedAnnealingChart.Location = new System.Drawing.Point(719, 572);
            this.SimulatedAnnealingChart.Name = "SimulatedAnnealingChart";
            this.SimulatedAnnealingChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series3.Legend = "Legend1";
            series3.Name = "ipc";
            series3.YValuesPerPoint = 2;
            this.SimulatedAnnealingChart.Series.Add(series3);
            this.SimulatedAnnealingChart.Size = new System.Drawing.Size(556, 185);
            this.SimulatedAnnealingChart.TabIndex = 28;
            this.SimulatedAnnealingChart.Text = "ipcHill";
            this.SimulatedAnnealingChart.Visible = false;
            this.SimulatedAnnealingChart.Click += new System.EventHandler(this.SimulatedAnnealingChart_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "Run the algorithm you want:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStochasticHillClimbing
            // 
            this.btnStochasticHillClimbing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStochasticHillClimbing.Location = new System.Drawing.Point(10, 153);
            this.btnStochasticHillClimbing.Name = "btnStochasticHillClimbing";
            this.btnStochasticHillClimbing.Size = new System.Drawing.Size(213, 36);
            this.btnStochasticHillClimbing.TabIndex = 30;
            this.btnStochasticHillClimbing.Text = "Stochastic HillClimbing";
            this.btnStochasticHillClimbing.UseVisualStyleBackColor = true;
            this.btnStochasticHillClimbing.Click += new System.EventHandler(this.btnStochasticHillClimbing_Click);
            // 
            // btnSimulatedAnnealing
            // 
            this.btnSimulatedAnnealing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulatedAnnealing.Location = new System.Drawing.Point(10, 208);
            this.btnSimulatedAnnealing.Name = "btnSimulatedAnnealing";
            this.btnSimulatedAnnealing.Size = new System.Drawing.Size(213, 36);
            this.btnSimulatedAnnealing.TabIndex = 31;
            this.btnSimulatedAnnealing.Text = "Simulated Annealing";
            this.btnSimulatedAnnealing.UseVisualStyleBackColor = true;
            this.btnSimulatedAnnealing.Click += new System.EventHandler(this.btnSimulatedAnnealing_Click);
            // 
            // labelHCs
            // 
            this.labelHCs.AutoSize = true;
            this.labelHCs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHCs.Location = new System.Drawing.Point(716, 287);
            this.labelHCs.Name = "labelHCs";
            this.labelHCs.Size = new System.Drawing.Size(186, 16);
            this.labelHCs.TabIndex = 32;
            this.labelHCs.Text = "Hill Climbing stohastic graphic";
            this.labelHCs.Visible = false;
            // 
            // labelSA
            // 
            this.labelSA.AutoSize = true;
            this.labelSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSA.Location = new System.Drawing.Point(716, 539);
            this.labelSA.Name = "labelSA";
            this.labelSA.Size = new System.Drawing.Size(179, 16);
            this.labelSA.TabIndex = 33;
            this.labelSA.Text = "Simulated Annealing graphic";
            this.labelSA.Visible = false;
            this.labelSA.Click += new System.EventHandler(this.labelSA_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 550);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 16);
            this.label12.TabIndex = 34;
            this.label12.Text = "Result: (best configuration found)";
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(433, 162);
            this.textBoxT.Multiline = true;
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(43, 18);
            this.textBoxT.TabIndex = 35;
            this.textBoxT.TextChanged += new System.EventHandler(this.textBoxT_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(233, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 32);
            this.label14.TabIndex = 36;
            this.label14.Text = "Choose the value of T \r\n(not too high and not too low)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxTmax
            // 
            this.textBoxTmax.Location = new System.Drawing.Point(433, 218);
            this.textBoxTmax.Multiline = true;
            this.textBoxTmax.Name = "textBoxTmax";
            this.textBoxTmax.Size = new System.Drawing.Size(43, 19);
            this.textBoxTmax.TabIndex = 37;
            this.textBoxTmax.TextChanged += new System.EventHandler(this.textBoxTmax_TextChanged);
            // 
            // textBoxTmin
            // 
            this.textBoxTmin.Location = new System.Drawing.Point(542, 218);
            this.textBoxTmin.Multiline = true;
            this.textBoxTmin.Name = "textBoxTmin";
            this.textBoxTmin.Size = new System.Drawing.Size(43, 19);
            this.textBoxTmin.TabIndex = 38;
            this.textBoxTmin.TextChanged += new System.EventHandler(this.textBoxTmin_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(233, 210);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 32);
            this.label15.TabIndex = 39;
            this.label15.Text = "Choose the value of \r\nTmax and Tmin ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(495, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 16);
            this.label16.TabIndex = 40;
            this.label16.Text = "Tmin ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(381, 218);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 16);
            this.label17.TabIndex = 41;
            this.label17.Text = "Tmax";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numericUpDownMemory);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numericUpDownBranch);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numericUpDownFloating);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericUpDownInteger);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxSeparate_dispatch);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxRsb_architecture);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDownReorder);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSuperscalar);
            this.groupBox1.Controls.Add(this.numericUpDownRename);
            this.groupBox1.Location = new System.Drawing.Point(25, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 215);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initial Configuration";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textBoxTmin);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.textBoxTmax);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBoxT);
            this.groupBox2.Controls.Add(this.btnSimulatedAnnealing);
            this.groupBox2.Controls.Add(this.btnStochasticHillClimbing);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnIteratedHillClimbing);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxMAX);
            this.groupBox2.Location = new System.Drawing.Point(25, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 265);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Algorithm selection";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 771);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelSA);
            this.Controls.Add(this.labelHCs);
            this.Controls.Add(this.SimulatedAnnealingChart);
            this.Controls.Add(this.HillClimbingSohasticChart);
            this.Controls.Add(this.labelHCi);
            this.Controls.Add(this.listBoxBestConfiguration);
            this.Controls.Add(this.HillClimbingChart);
            this.Name = "Form1";
            this.Text = "ProiectD2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HillClimbingChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInteger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFloating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HillClimbingSohasticChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulatedAnnealingChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

