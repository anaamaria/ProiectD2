using System;
using System.Collections.Generic;

namespace ProiectD2
{
    public class HillClimbing
    {
        List<double> ipc = new List<double>();
        public Dictionary<string, string> HillClimbingAlgo(int MAX)
        {
            ipc.Clear();
            Dictionary<string, string> Vc = new Dictionary<string, string>();
            Dictionary<string, string> Vn = new Dictionary<string, string>();

            HelpingMethods help = new HelpingMethods();

            bool local;
            List<string> keyList = new List<string>(Vc.Keys);
            Dictionary<string, string> best = new Dictionary<string, string>();
            Random rand = new Random();
            string currentPoint;

            List<int> vecini = new List<int>();
            List<string> veciniString = new List<string>();
            bool vecinBool;
            double IpcVc;

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
                local = false;

                currentPoint = keyList[rand.Next(keyList.Count)];

                if (ipc.Count == 0)
                {
                    double ipcFirst = help.eval(currentPoint, Vc);
                    ipc.Add(ipcFirst);
                }

                do
                {
                    switch (currentPoint)
                    {
                        case "superscalar":
                            int ValueVc_superscalar = Convert.ToInt32(Vc[currentPoint]);
                            vecini = help.Neighbors(intervalSuperscalar, ValueVc_superscalar);
                            if (vecini.Count == 1)
                            {
                                Vn[currentPoint] = Convert.ToString(vecini[0]);
                            }
                            else
                            {
                                Vn[currentPoint] = Convert.ToString(vecini[0]);
                                double ipcPointStanga = help.eval(currentPoint, Vn);

                                Vn[currentPoint] = Convert.ToString(vecini[1]);

                                double ipcPointDreapta = help.eval(currentPoint, Vn);

                                if (ipcPointStanga > ipcPointDreapta)
                                {
                                    Vn[currentPoint] = Convert.ToString(vecini[0]);
                                }
                                else
                                {
                                    Vn[currentPoint] = Convert.ToString(vecini[1]);
                                }
                            }
                            break;
                        case "rename":
                            int ValueVc_rename = Convert.ToInt32(Vc[currentPoint]);
                            vecini = help.Neighbors(intervalRename, ValueVc_rename);
                            if (vecini.Count == 1)
                            {
                                Vn[currentPoint] = Convert.ToString(vecini[0]);
                            }
                            else
                            {
                                Vn[currentPoint] = Convert.ToString(vecini[0]);
                                double ipcPointStanga = help.eval(currentPoint, Vn);

                                Vn[currentPoint] = Convert.ToString(vecini[1]);
                                double ipcPointDreapta = help.eval(currentPoint, Vn);

                                if (ipcPointStanga > ipcPointDreapta)
                                {
                                    Vn[currentPoint] = Convert.ToString(vecini[0]);
                                }
                                else
                                {
                                    Vn[currentPoint] = Convert.ToString(vecini[1]);
                                }
                            }
                            break;
                        case "reorder":
                            int ValueVc_reorder = Convert.ToInt32(Vc[currentPoint]);
                            vecini = help.Neighbors(intervalReorder, ValueVc_reorder);
                            if (vecini.Count == 1)
                            {
                                Vn[currentPoint] = Convert.ToString(vecini[0]);
                            }
                            else
                            {
                                Vn[currentPoint] = Convert.ToString(vecini[0]);
                                double ipcPointStanga = help.eval(currentPoint, Vn);

                                Vn[currentPoint] = Convert.ToString(vecini[1]);
                                double ipcPointDreapta = help.eval(currentPoint, Vn);

                                if (ipcPointStanga > ipcPointDreapta)
                                {
                                    Vn[currentPoint] = Convert.ToString(vecini[0]);
                                }
                                else
                                {
                                    Vn[currentPoint] = Convert.ToString(vecini[1]);
                                }
                            }
                            break;
                        case "rsb_architecture":
                            string ValueVc_rsb_architecture = Vc[currentPoint];

                            veciniString = help.NeighborsString(intervalRsb_architecture, ValueVc_rsb_architecture);

                            if (veciniString.Count == 1)
                            {
                                Vn[currentPoint] = veciniString[0];
                            }
                            else
                            {
                                Vn[currentPoint] = veciniString[0];
                                double ipcPointStanga = help.eval(currentPoint, Vn);

                                Vn[currentPoint] = veciniString[1];
                                double ipcPointDreapta = help.eval(currentPoint, Vn);

                                if (ipcPointStanga > ipcPointDreapta)
                                {
                                    Vn[currentPoint] = veciniString[0];
                                }
                                else
                                {
                                    Vn[currentPoint] = veciniString[1];
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

                            break;
                        case "integer":
                            int ValueVc_integer = Convert.ToInt32(Vc[currentPoint]);
                            vecini = help.Neighbors(intervalExecution, ValueVc_integer);

                            if (vecini.Count == 1)
                            {
                                Vn[currentPoint] = Convert.ToString(vecini[0]);
                            }
                            else
                            {
                                Vn[currentPoint] = Convert.ToString(vecini[0]);
                                double ipcPointStanga = help.eval(currentPoint, Vn);

                                Vn[currentPoint] = Convert.ToString(vecini[1]);
                                double ipcPointDreapta = help.eval(currentPoint, Vn);

                                if (ipcPointStanga > ipcPointDreapta)
                                {
                                    Vn[currentPoint] = Convert.ToString(vecini[0]);
                                }
                                else
                                {
                                    Vn[currentPoint] = Convert.ToString(vecini[1]);
                                }
                            }
                            break;
                        case "floating":
                            int ValueVc_floating = Convert.ToInt32(Vc[currentPoint]);
                            vecini = help.Neighbors(intervalExecution, ValueVc_floating);

                            if (vecini.Count == 1)
                            {
                                Vn[currentPoint] = Convert.ToString(vecini[0]);
                            }
                            else
                            {
                                Vn[currentPoint] = Convert.ToString(vecini[0]);
                                double ipcPointStanga = help.eval(currentPoint, Vn);

                                Vn[currentPoint] = Convert.ToString(vecini[1]);
                                double ipcPointDreapta = help.eval(currentPoint, Vn);

                                if (ipcPointStanga > ipcPointDreapta)
                                {
                                    Vn[currentPoint] = Convert.ToString(vecini[0]);
                                }
                                else
                                {
                                    Vn[currentPoint] = Convert.ToString(vecini[1]);
                                }
                            }
                            break;
                        case "branch":
                            int ValueVc_branch = Convert.ToInt32(Vc[currentPoint]);
                            vecini = help.Neighbors(intervalExecution, ValueVc_branch);

                            if (vecini.Count == 1)
                            {
                                Vn[currentPoint] = Convert.ToString(vecini[0]);
                            }
                            else
                            {
                                Vn[currentPoint] = Convert.ToString(vecini[0]);
                                double ipcPointStanga = help.eval(currentPoint, Vn);

                                Vn[currentPoint] = Convert.ToString(vecini[1]);
                                double ipcPointDreapta = help.eval(currentPoint, Vn);

                                if (ipcPointStanga > ipcPointDreapta)
                                {
                                    Vn[currentPoint] = Convert.ToString(vecini[0]);
                                }
                                else
                                {
                                    Vn[currentPoint] = Convert.ToString(vecini[1]);
                                }
                            }
                            break;
                        case "memory":
                            int ValueVc_memory = Convert.ToInt32(Vc[currentPoint]);
                            vecini = help.Neighbors(intervalExecution, ValueVc_memory);

                            if (vecini.Count == 1)
                            {
                                Vn[currentPoint] = Convert.ToString(vecini[0]);
                            }
                            else
                            {
                                Vn[currentPoint] = Convert.ToString(vecini[0]);
                                double ipcPointStanga = help.eval(currentPoint, Vn);

                                Vn[currentPoint] = Convert.ToString(vecini[1]);
                                double ipcPointDreapta = help.eval(currentPoint, Vn);

                                if (ipcPointStanga > ipcPointDreapta)
                                {
                                    Vn[currentPoint] = Convert.ToString(vecini[0]);
                                }
                                else
                                {
                                    Vn[currentPoint] = Convert.ToString(vecini[1]);
                                }
                            }
                            break;
                        default:
                            break;
                    }

                    double ipcVn = help.eval(currentPoint, Vn);
                    IpcVc = help.eval(currentPoint, Vc);

                    if (ipcVn > IpcVc)
                    {
                        Vc[currentPoint] = Vn[currentPoint];
                    }
                    else
                    {
                        local = true;
                    }

                } while (!local);
                iteratii += 1;
                double Ipcbest = help.eval(currentPoint, best);
                if (IpcVc > Ipcbest)
                {
                    best[currentPoint] = Vc[currentPoint];
                    ipc.Add(IpcVc);

                }
            } while (iteratii != MAX);

            return best;
        }


        public List<double> GetIPC()
        {
            return ipc;
        }

    }
}
