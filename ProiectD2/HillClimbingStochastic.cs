using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectD2
{
    public class HillClimbingStochastic
    {

        List<double> ipc = new List<double>();
        public Dictionary<string, string> HillClimbingStochasticAlgo(int MAX, int T)
        {
            ipc.Clear();
            Dictionary<string, string> Vc = new Dictionary<string, string>();
            Dictionary<string, string> Vn = new Dictionary<string, string>();

            HelpingMethods help = new HelpingMethods();


            List<string> keyList = new List<string>(Vc.Keys);
            Dictionary<string, string> best = new Dictionary<string, string>();
            Random rand = new Random();
            string currentPoint;

            List<int> vecini = new List<int>();
            List<string> veciniString = new List<string>();
            bool vecinBool;

            double ipcBase;
            double ipcPointDreapta;
            double ipcPointStanga;

            int[] intervalSuperscalar = new int[5];
            intervalSuperscalar = help.General_Interval(5);

            int[] intervalRename = new int[10];
            intervalRename = help.Generate_Interval(512);

            int[] intervalReorder = new int[10];
            intervalReorder = help.Generate_Interval(512);

            string[] intervalRsb_architecture = { "distributed", "centralized", "hybrid" };

            bool[] intervalSeparate_dispatch = { true, false };

            int[] intervalExecution = new int[8];
            intervalExecution = help.Generate_Interval(8);

            int iteratii = 0;

            Vc = help.ReadDefaultConfig();

            foreach (string key in Vc.Keys)
            {
                best.Add(key, Vc[key]);
            }

            foreach (string key in Vc.Keys)
            {
                Vn.Add(key, Vc[key]);
            }

            foreach (string keys in Vc.Keys)
            {
                keyList.Add(keys);
            }




            do
            {
                currentPoint = keyList[rand.Next(keyList.Count)];
                if (ipc.Count == 0)
                {
                    double ipcFirst = help.eval(currentPoint, Vc);
                    ipc.Add(ipcFirst);
                }

                switch (currentPoint)
                {
                    case "superscalar":
                        int ValueVc_superscalar = Convert.ToInt32(Vc[currentPoint]);
                        vecini = help.Neighbors(intervalSuperscalar, ValueVc_superscalar);

                        ipcBase = help.eval(currentPoint, Vc);

                        if (vecini.Count == 1)
                        {
                            Vn[currentPoint] = Convert.ToString(vecini[0]);
                            ipcPointDreapta = help.eval(currentPoint, Vn);
                            if (ipc[ipc.Count - 1] < ipcPointDreapta)
                            {
                                Vc[currentPoint] = Convert.ToString(vecini[0]);
                                ipc.Add(ipcPointDreapta);
                            }
                        }
                        else
                        {
                            Vn[currentPoint] = Convert.ToString(vecini[0]);
                            ipcPointStanga = help.eval(currentPoint, Vn);

                            double probabilityStanga = help.CalculateProbability(ipcBase, ipcPointStanga, T);

                            Vn[currentPoint] = Convert.ToString(vecini[1]);

                            ipcPointDreapta = help.eval(currentPoint, Vn);

                            double probabilityDreapta = help.CalculateProbability(ipcBase, ipcPointDreapta, T);

                            if (probabilityStanga > probabilityDreapta)
                            {
                                Vc[currentPoint] = Convert.ToString(vecini[0]);
                                if (ipc[ipc.Count - 1] < ipcPointStanga)
                                {
                                    ipc.Add(ipcPointStanga);
                                }

                            }
                            else
                            {
                                Vc[currentPoint] = Convert.ToString(vecini[1]);
                                if (ipc[ipc.Count - 1] < ipcPointDreapta)
                                {
                                    ipc.Add(ipcPointDreapta);
                                }

                            }
                        }
                        break;
                    case "rename":

                        int ValueVc_rename = Convert.ToInt32(Vc[currentPoint]);

                        vecini = help.Neighbors(intervalRename, ValueVc_rename);

                        ipcBase = help.eval(currentPoint, Vc);

                        if (vecini.Count == 1)
                        {
                            Vn[currentPoint] = Convert.ToString(vecini[0]);
                            ipcPointDreapta = help.eval(currentPoint, Vn);
                            if (ipc[ipc.Count - 1] < ipcPointDreapta)
                            {
                                Vc[currentPoint] = Convert.ToString(vecini[0]);
                                ipc.Add(ipcPointDreapta);
                            }
                        }
                        else
                        {
                            Vn[currentPoint] = Convert.ToString(vecini[0]);

                            ipcPointStanga = help.eval(currentPoint, Vn);

                            double probabilityStanga = help.CalculateProbability(ipcBase, ipcPointStanga, T);

                            Vn[currentPoint] = Convert.ToString(vecini[1]);

                            ipcPointDreapta = help.eval(currentPoint, Vn);

                            double probabilityDreapta = help.CalculateProbability(ipcBase, ipcPointDreapta, T);

                            if (probabilityStanga > probabilityDreapta)
                            {
                                Vc[currentPoint] = Convert.ToString(vecini[0]);

                                if (ipc[ipc.Count - 1] < ipcPointStanga)
                                {
                                    ipc.Add(ipcPointStanga);
                                }
                            }
                            else
                            {
                                Vc[currentPoint] = Convert.ToString(vecini[1]);

                                if (ipc[ipc.Count - 1] < ipcPointDreapta)
                                {
                                    ipc.Add(ipcPointDreapta);
                                }
                            }
                        }
                        break;
                    case "reorder":

                        int ValueVc_reorder = Convert.ToInt32(Vc[currentPoint]);

                        vecini = help.Neighbors(intervalReorder, ValueVc_reorder);

                        ipcBase = help.eval(currentPoint, Vc);

                        if (vecini.Count == 1)
                        {
                            Vn[currentPoint] = Convert.ToString(vecini[0]);
                            ipcPointDreapta = help.eval(currentPoint, Vn);
                            if (ipc[ipc.Count - 1] < ipcPointDreapta)
                            {
                                Vc[currentPoint] = Convert.ToString(vecini[0]);
                                ipc.Add(ipcPointDreapta);
                            }
                        }
                        else
                        {
                            Vn[currentPoint] = Convert.ToString(vecini[0]);

                            ipcPointStanga = help.eval(currentPoint, Vn);

                            double probabilityStanga = help.CalculateProbability(ipcBase, ipcPointStanga, T);

                            Vn[currentPoint] = Convert.ToString(vecini[1]);

                            ipcPointDreapta = help.eval(currentPoint, Vn);

                            double probabilityDreapta = help.CalculateProbability(ipcBase, ipcPointDreapta, T);

                            if (probabilityStanga > probabilityDreapta)
                            {
                                Vc[currentPoint] = Convert.ToString(vecini[0]);

                                if (ipc[ipc.Count - 1] < ipcPointStanga)
                                {
                                    ipc.Add(ipcPointStanga);
                                }
                            }
                            else
                            {
                                Vc[currentPoint] = Convert.ToString(vecini[1]);

                                if (ipc[ipc.Count - 1] < ipcPointDreapta)
                                {
                                    ipc.Add(ipcPointDreapta);
                                }
                            }
                        }
                        break;
                    case "rsb_architecture":
                        string ValueVc_rsb_architecture = Vc[currentPoint];

                        veciniString = help.NeighborsString(intervalRsb_architecture, ValueVc_rsb_architecture);
                        ipcBase = help.eval(currentPoint, Vc);
                        if (veciniString.Count == 1)
                        {
                            Vn[currentPoint] = veciniString[0];
                            ipcPointDreapta = help.eval(currentPoint, Vn);

                            if (ipc[ipc.Count - 1] < ipcPointDreapta)
                            {
                                Vc[currentPoint] = veciniString[0];
                                ipc.Add(ipcPointDreapta);
                            }

                        }
                        else
                        {
                            Vn[currentPoint] = veciniString[0];
                            ipcPointStanga = help.eval(currentPoint, Vn);
                            double probabilityStanga = help.CalculateProbability(ipcBase, ipcPointStanga, T);
                            Vn[currentPoint] = veciniString[1];
                            ipcPointDreapta = help.eval(currentPoint, Vn);
                            double probabilityDreapta = help.CalculateProbability(ipcBase, ipcPointDreapta, T);
                            if (probabilityStanga > probabilityDreapta)
                            {
                                Vc[currentPoint] = veciniString[0];
                                if (ipc[ipc.Count - 1] < ipcPointStanga)
                                {
                                    ipc.Add(ipcPointStanga);
                                }
                            }
                            else
                            {
                                Vc[currentPoint] = veciniString[1];
                                if (ipc[ipc.Count - 1] < ipcPointDreapta)
                                {
                                    ipc.Add(ipcPointDreapta);
                                }
                            }
                        }
                        break;
                    case "separate_dispatch":
                        bool ValueVc_separate_dispatch = Convert.ToBoolean(Vc[currentPoint]);

                        if (ValueVc_separate_dispatch == true)
                        {
                            vecinBool = false;
                        }
                        else
                        {
                            vecinBool = true;
                        }

                        Vn[currentPoint] = Convert.ToString(vecinBool);

                        ipcBase = help.eval(currentPoint, Vn);
                        if (ipc[ipc.Count - 1] < ipcBase)
                        {
                            Vc[currentPoint] = Convert.ToString(vecinBool);
                            ipc.Add(ipcBase);
                        }


                        break;
                    case "integer":
                        int ValueVc_integer = Convert.ToInt32(Vc[currentPoint]);
                        vecini = help.Neighbors(intervalExecution, ValueVc_integer);
                        ipcBase = help.eval(currentPoint, Vc);
                        if (vecini.Count == 1)
                        {
                            Vn[currentPoint] = Convert.ToString(vecini[0]);
                            ipcPointDreapta = help.eval(currentPoint, Vn);
                            if (ipc[ipc.Count - 1] < ipcPointDreapta)
                            {
                                Vc[currentPoint] = Convert.ToString(vecini[0]);
                                ipc.Add(ipcPointDreapta);
                            }
                        }
                        else
                        {
                            Vn[currentPoint] = Convert.ToString(vecini[0]);
                            ipcPointStanga = help.eval(currentPoint, Vn);
                            double probabilityStanga = help.CalculateProbability(ipcBase, ipcPointStanga, T);
                            Vn[currentPoint] = Convert.ToString(vecini[1]);
                            ipcPointDreapta = help.eval(currentPoint, Vn);
                            double probabilityDreapta = help.CalculateProbability(ipcBase, ipcPointDreapta, T);
                            if (probabilityStanga > probabilityDreapta)
                            {
                                Vc[currentPoint] = Convert.ToString(vecini[0]);
                                if (ipc[ipc.Count - 1] < ipcPointStanga)
                                {
                                    ipc.Add(ipcPointStanga);
                                }
                            }
                            else
                            {
                                Vc[currentPoint] = Convert.ToString(vecini[1]);
                                if (ipc[ipc.Count - 1] < ipcPointDreapta)
                                {
                                    ipc.Add(ipcPointDreapta);
                                }
                            }
                        }
                        break;
                    case "floating":
                        int ValueVc_floating = Convert.ToInt32(Vc[currentPoint]);
                        vecini = help.Neighbors(intervalExecution, ValueVc_floating);
                        ipcBase = help.eval(currentPoint, Vc);
                        if (vecini.Count == 1)
                        {
                            Vn[currentPoint] = Convert.ToString(vecini[0]);
                            ipcPointDreapta = help.eval(currentPoint, Vn);
                            if (ipc[ipc.Count - 1] < ipcPointDreapta)
                            {
                                Vc[currentPoint] = Convert.ToString(vecini[0]);
                                ipc.Add(ipcPointDreapta);
                            }
                        }
                        else
                        {
                            Vn[currentPoint] = Convert.ToString(vecini[0]);
                            ipcPointStanga = help.eval(currentPoint, Vn);
                            double probabilityStanga = help.CalculateProbability(ipcBase, ipcPointStanga, T);
                            Vn[currentPoint] = Convert.ToString(vecini[1]);
                            ipcPointDreapta = help.eval(currentPoint, Vn);
                            double probabilityDreapta = help.CalculateProbability(ipcBase, ipcPointDreapta, T);
                            if (probabilityStanga > probabilityDreapta)
                            {
                                Vc[currentPoint] = Convert.ToString(vecini[0]);
                                if (ipc[ipc.Count - 1] < ipcPointStanga)
                                {
                                    ipc.Add(ipcPointStanga);
                                }
                            }
                            else
                            {
                                Vc[currentPoint] = Convert.ToString(vecini[1]);
                                if (ipc[ipc.Count - 1] < ipcPointDreapta)
                                {
                                    ipc.Add(ipcPointDreapta);
                                }
                            }
                        }
                        break;
                    case "branch":
                        int ValueVc_branch = Convert.ToInt32(Vc[currentPoint]);
                        vecini = help.Neighbors(intervalExecution, ValueVc_branch);
                        ipcBase = help.eval(currentPoint, Vc);
                        if (vecini.Count == 1)
                        {
                            Vn[currentPoint] = Convert.ToString(vecini[0]);
                            ipcPointDreapta = help.eval(currentPoint, Vn);
                            if (ipc[ipc.Count - 1] < ipcPointDreapta)
                            {
                                Vc[currentPoint] = Convert.ToString(vecini[0]);
                                ipc.Add(ipcPointDreapta);
                            }
                        }
                        else
                        {
                            Vn[currentPoint] = Convert.ToString(vecini[0]);
                            ipcPointStanga = help.eval(currentPoint, Vn);
                            double probabilityStanga = help.CalculateProbability(ipcBase, ipcPointStanga, T);
                            Vn[currentPoint] = Convert.ToString(vecini[1]);
                            ipcPointDreapta = help.eval(currentPoint, Vn);
                            double probabilityDreapta = help.CalculateProbability(ipcBase, ipcPointDreapta, T);
                            if (probabilityStanga > probabilityDreapta)
                            {
                                Vc[currentPoint] = Convert.ToString(vecini[0]);
                                if (ipc[ipc.Count - 1] < ipcPointStanga)
                                {
                                    ipc.Add(ipcPointStanga);
                                }
                            }
                            else
                            {
                                Vc[currentPoint] = Convert.ToString(vecini[1]);
                                if (ipc[ipc.Count - 1] < ipcPointDreapta)
                                {
                                    ipc.Add(ipcPointDreapta);
                                }
                            }
                        }
                        break;
                    case "memory":
                        int ValueVc_memory = Convert.ToInt32(Vc[currentPoint]);
                        vecini = help.Neighbors(intervalExecution, ValueVc_memory);
                        ipcBase = help.eval(currentPoint, Vc);
                        if (vecini.Count == 1)
                        {
                            Vn[currentPoint] = Convert.ToString(vecini[0]);
                            ipcPointDreapta = help.eval(currentPoint, Vn);
                            if (ipc[ipc.Count - 1] < ipcPointDreapta)
                            {
                                Vc[currentPoint] = Convert.ToString(vecini[0]);
                                ipc.Add(ipcPointDreapta);
                            }
                        }
                        else
                        {
                            Vn[currentPoint] = Convert.ToString(vecini[0]);
                            ipcPointStanga = help.eval(currentPoint, Vn);
                            double probabilityStanga = help.CalculateProbability(ipcBase, ipcPointStanga, T);
                            Vn[currentPoint] = Convert.ToString(vecini[1]);
                            ipcPointDreapta = help.eval(currentPoint, Vn);
                            double probabilityDreapta = help.CalculateProbability(ipcBase, ipcPointDreapta, T);
                            if (probabilityStanga > probabilityDreapta)
                            {
                                Vc[currentPoint] = Convert.ToString(vecini[0]);
                                if (ipc[ipc.Count - 1] < ipcPointStanga)
                                {
                                    ipc.Add(ipcPointStanga);
                                }
                            }
                            else
                            {
                                Vc[currentPoint] = Convert.ToString(vecini[1]);
                                if (ipc[ipc.Count - 1] < ipcPointDreapta)
                                {
                                    ipc.Add(ipcPointDreapta);
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
                iteratii += 1;

            } while (iteratii != MAX);

            return Vc;
        }


        public List<double> GetIPC()
        {
            return ipc;
        }
    }
}
