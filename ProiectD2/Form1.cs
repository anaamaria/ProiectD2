using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProiectD2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIteratedHillClimbing_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> BestConfiguration = new Dictionary<string, string>();
            Dictionary<string, string> InitialConfiguration = new Dictionary<string, string>();
            int MAX;
            HillClimbing hill = new HillClimbing();
            HelpingMethods help = new HelpingMethods();

            InitialConfiguration = ReadConfiguration_UI();
            help.WriteInitialXML(InitialConfiguration);

            MAX = GetValueTextBox(textBoxMAX);
            
            BestConfiguration = hill.HillClimbingAlgo(MAX);

            labelHCi.Visible = true;

            help.DrawChart(hill.GetIPC(), HillClimbingChart);

            help.ShowBestConfiguration(listBoxBestConfiguration, BestConfiguration);
        }

        private int GetValueTextBox(TextBox textBox)
        {
            int value;
            try
            {
                value = Convert.ToInt32(textBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: Type a value in the textBox");
                throw;
            }

            return value;
        } 

       
        private Dictionary<string, string> ReadConfiguration_UI()
        {
            Dictionary<string, string> Configuration = new Dictionary<string, string>();
            UInt16 x = Convert.ToUInt16(textBoxSuperscalar.Text);

            Configuration.Add("superscalar", textBoxSuperscalar.Text);
            Configuration.Add("rename", Convert.ToString(numericUpDownRename.Value));
            Configuration.Add("reorder", Convert.ToString(numericUpDownReorder.Value));
            Configuration.Add("rsb_architecture", textBoxRsb_architecture.Text);
            Configuration.Add("separate_dispatch", textBoxSeparate_dispatch.Text);

            Configuration.Add("integer", Convert.ToString(numericUpDownInteger.Value));
            Configuration.Add("floating", Convert.ToString(numericUpDownFloating.Value));
            Configuration.Add("branch", Convert.ToString(numericUpDownBranch.Value));
            Configuration.Add("memory", Convert.ToString(numericUpDownMemory.Value));

            return Configuration;
        }

        private void btnStochasticHillClimbing_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> BestConfiguration = new Dictionary<string, string>();
            Dictionary<string, string> InitialConfiguration = new Dictionary<string, string>();

            int T = GetValueTextBox(textBoxT);
            int MAX = GetValueTextBox(textBoxMAX);

            HillClimbingStochastic hillStohastic = new HillClimbingStochastic();
            HelpingMethods help = new HelpingMethods();

            InitialConfiguration = ReadConfiguration_UI();
            help.WriteInitialXML(InitialConfiguration);

            BestConfiguration = hillStohastic.HillClimbingStochasticAlgo(MAX,T);

            labelHCs.Visible = true;

            help.DrawChart(hillStohastic.GetIPC(), HillClimbingSohasticChart);

            help.ShowBestConfiguration(listBoxBestConfiguration, BestConfiguration);
        }

        private void btnSimulatedAnnealing_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> BestConfiguration = new Dictionary<string, string>();
            Dictionary<string, string> InitialConfiguration = new Dictionary<string, string>();

            double Tmax = Convert.ToDouble(textBoxTmax.Text);
            double Tmin = Convert.ToDouble(textBoxTmin.Text);
            int MAX = GetValueTextBox(textBoxMAX);

            SimulatedAnnealing simulatedAnnealing = new SimulatedAnnealing();
            HelpingMethods help = new HelpingMethods();

            InitialConfiguration = ReadConfiguration_UI();
            help.WriteInitialXML(InitialConfiguration);

            BestConfiguration = simulatedAnnealing.SimulatedAnnealingAlgo(MAX, Tmax, Tmin);

            labelSA.Visible = true;

            help.DrawChart(simulatedAnnealing.GetIPC(), SimulatedAnnealingChart);

            help.ShowBestConfiguration(listBoxBestConfiguration, BestConfiguration);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
