using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace ProiectD2
{
    public class HelpingMethods
    {
        int j;
        public Dictionary<string, string> ReadDefaultConfig()
        {
            Dictionary<string, string> Configuration = new Dictionary<string, string>();
            XmlDocument doc = new XmlDocument();
            string Path = Directory.GetCurrentDirectory() + @"\PSATSim\default_cfg.xml";
            doc.Load(Path);
            XmlNode firstNode, secondNode;
            XmlNode root = doc.DocumentElement;

            firstNode = root.SelectSingleNode("//psatsim/config/general");
            var AtributeGeneral = firstNode.Attributes;



            Configuration.Add("superscalar", Convert.ToString(AtributeGeneral[0].Value));
            Configuration.Add("rename", Convert.ToString(AtributeGeneral[1].Value));
            Configuration.Add("reorder", Convert.ToString(AtributeGeneral[2].Value));
            Configuration.Add("rsb_architecture", Convert.ToString(AtributeGeneral[3].Value));
            Configuration.Add("separate_dispatch", Convert.ToString(AtributeGeneral[7].Value));

            secondNode = root.SelectSingleNode("//psatsim/config/execution");
            var AtributeExecution = secondNode.Attributes;

            Configuration.Add("integer", Convert.ToString(AtributeExecution[1].Value));
            Configuration.Add("floating", Convert.ToString(AtributeExecution[2].Value));
            Configuration.Add("branch", Convert.ToString(AtributeExecution[3].Value));
            Configuration.Add("memory", Convert.ToString(AtributeExecution[4].Value));

            return Configuration;
        }

        public double ReadOutput()
        {
            double ipc;
            XmlDocument doc = new XmlDocument();
            string Path = Directory.GetCurrentDirectory() + @"\PSATSim\output.xml";
            doc.Load(Path);
            XmlNode firstNode;
            XmlNode root = doc.DocumentElement;
            firstNode = root.SelectSingleNode("//psatsim_results/variation/general");

            var AtributeGeneral = firstNode.Attributes;

            ipc = Convert.ToDouble(AtributeGeneral[3].Value);
            return ipc;
        }

        public void WriteInitialXML(Dictionary<string,string> Configuration)
        {
            XmlDocument doc = new XmlDocument();
            string Path = Directory.GetCurrentDirectory() + @"\PSATSim\default_cfg.xml";
            doc.Load(Path);

            XmlNode firstNode, secondNode;
            XmlNode root = doc.DocumentElement;

            firstNode = root.SelectSingleNode("//psatsim/config/general");
            var AtributeGeneral = firstNode.Attributes;

            secondNode = root.SelectSingleNode("//psatsim/config/execution");
            var AtributeExecution = secondNode.Attributes;

            AtributeGeneral[0].Value = Configuration["superscalar"];
            AtributeGeneral[1].Value = Configuration["rename"];
            AtributeGeneral[2].Value = Configuration["reorder"];
            AtributeGeneral[3].Value = Configuration["rsb_architecture"];
            AtributeGeneral[7].Value = Configuration["separate_dispatch"];

            AtributeExecution[1].Value = Configuration["integer"];
            AtributeExecution[2].Value = Configuration["floating"];
            AtributeExecution[3].Value = Configuration["branch"];
            AtributeExecution[4].Value = Configuration["memory"];

            doc.Save(Path);
        }
        public void UpdateXML(string currentKEY, Dictionary<string, string> Configuration)
        {
            XmlDocument doc = new XmlDocument();
            string Path = Directory.GetCurrentDirectory() + @"\PSATSim\default_cfg.xml";
            doc.Load(Path);

            XmlNode firstNode, secondNode;
            XmlNode root = doc.DocumentElement;

            firstNode = root.SelectSingleNode("//psatsim/config/general");
            var AtributeGeneral = firstNode.Attributes;

            secondNode = root.SelectSingleNode("//psatsim/config/execution");
            var AtributeExecution = secondNode.Attributes;

            switch (currentKEY)
            {
                case "superscalar":
                    AtributeGeneral[0].Value = Configuration["superscalar"];
                    break;
                case "rename":
                    AtributeGeneral[1].Value = Configuration["rename"];
                    break;
                case "reorder":
                    AtributeGeneral[2].Value = Configuration["reorder"];
                    break;
                case "rsb_architecture":
                    AtributeGeneral[3].Value = Configuration["rsb_architecture"];
                    break;
                case "separate_dispatch":
                    AtributeGeneral[7].Value = Configuration["separate_dispatch"];
                    break;
                case "integer":
                    AtributeExecution[1].Value = Configuration["integer"];
                    break;
                case "floating":
                    AtributeExecution[2].Value = Configuration["floating"];
                    break;
                case "branch":
                    AtributeExecution[3].Value = Configuration["branch"];
                    break;
                case "memory":
                    AtributeExecution[4].Value = Configuration["memory"];
                    break;

                default:
                    break;
            }

            doc.Save(Path);
        }

        public void RunPSATSim()
        {
            Process process = new Process();
            string Path = Directory.GetCurrentDirectory() + @"\PSATSim";
            var StartInfo = new System.Diagnostics.ProcessStartInfo
            {
                WorkingDirectory = Path,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                FileName = Directory.GetCurrentDirectory() + @"\PSATSim\psatsim_con.exe",
                Arguments = "default_cfg.xml output.xml -g",
                RedirectStandardInput = true,
                CreateNoWindow = true,
                UseShellExecute = false
            };
            process.StartInfo = StartInfo;
            process.Start();

            process.WaitForExit();
        }


        public int[] General_Interval(int maxInterval)
        {
            int[] output = new int[maxInterval];

            for (int i = 0; i < maxInterval; i++)
            {
                output[i] = Convert.ToInt32(Math.Pow(2, i));
            }

            return output;

        }



        public int[] Generate_Interval(int maxInterval)
        {
            int[] output = new int[maxInterval];

            for (int i = 1; i <= maxInterval; i++)
            {
                output[i - 1] = i;
            }

            return output;
        }

        public List<int> Neighbors(int[] interval, int valoareCautata)
        {
            List<int> vecini = new List<int>();

            for (int i = 0; i < interval.Length; i++)
            {
                if (interval[i] == valoareCautata)
                {
                    if (i == 0)
                    {
                        vecini.Add(interval[i + 1]);
                    }
                    else if (i == interval.Length - 1)
                    {
                        vecini.Add(interval[i - 1]);
                    }
                    else
                    {
                        vecini.Add(interval[i - 1]);
                        vecini.Add(interval[i + 1]);
                    }
                }
            }

            return vecini;

        }

        public List<string> NeighborsString(string[] interval, string stringCautat)
        {
            List<string> output = new List<string>();
            for (int i = 0; i < interval.Length; i++)
            {
                if (interval[i] == stringCautat)
                {
                    if (i == 0)
                    {
                        output.Add(interval[i + 1]);
                    }
                    else if (i == interval.Length - 1)
                    {
                        output.Add(interval[i - 1]);
                    }
                    else
                    {
                        output.Add(interval[i - 1]);
                        output.Add(interval[i + 1]);
                    }
                }
            }
            return output;
        }

        public double eval(string currentKey, Dictionary<string, string> Configuratie)
        {
            
            UpdateXML(currentKey, Configuratie);

            RunPSATSim();

            return ReadOutput();
        }

      

        public void ShowBestConfiguration (ListBox listBox, Dictionary<string,string> Configuration)
        {
            listBox.Items.Clear();
            foreach (string keys in Configuration.Keys)
            {
                listBox.Items.Add(keys + ": " + Configuration[keys]);
            }

        }

        public void DrawChart(List<double> data, System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {
            chart.Visible = true;

            foreach (var series in chart.Series)
            {
                series.Points.Clear();
            }

            for (int i = 0; i < data.Count; i++)
            {
                chart.Series["ipc"].Points.AddXY("cfg" + i, data[i]);
            }
        }

        public double CalculateProbability(double ipc1, double ipc2, int T)
        {
            double probability;
            double calc = (ipc1-ipc2)/T;

            probability = 1 / (1 + Math.Pow(Math.E, calc));

            return probability;
        }


        public double AnnealingProbability(double evalVc, double evalVn, double T)
        {
            
            double probability;
            double calc = (evalVn - evalVc) / T;
            probability = Math.Pow(Math.E, calc);
            
            return probability;
        }

        public double CoolingRatio(double Tmax)
        {
            double r = 0.1;

            double coolingratio = Tmax * 1/Math.Pow(Math.E,j*r);
            j++;
            return coolingratio;
        }
    }
}
