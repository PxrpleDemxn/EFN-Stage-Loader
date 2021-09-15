using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
//using Memory;

namespace EFN_StageLoader
{
    public partial class StageLoader : Window
    {
        string Stages = @"stages\";
        string SavedGames = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Leyak\Saved\SaveGames";
        string fileName = string.Empty;
        string destFile = string.Empty;

        //Mem m = new Mem();
        //bool openProc = false;
        //int PID = 0;
        //float xPos, yPos, zPos;
        //bool PlayerControl = false;
        //int pc = 2;
        public StageLoader()
        {
            InitializeComponent();

            //DispatcherTimer Timer = new DispatcherTimer();
            //Timer.Tick += Timer_Tick;
            //Timer.Interval = new TimeSpan(0, 0, 1);
            //Timer.Start();
        }














        //private void Timer_Tick(object sender, EventArgs e)
        //{
        //    PID = m.GetProcIdFromName("Leyak-Win64-Shipping");
        //    Console.WriteLine(PID);

        //    if (PID > 0) openProc = m.OpenProcess(PID);

        //    if (openProc && PID != 0)
        //    {

        //        if (pc == 0)
        //        {
        //            PlayerControl = true;
        //            lbl_cm.Foreground = Brushes.Green;
        //            lbl_cm.Content = PlayerControl;

        //        }
        //        else
        //        {
        //            PlayerControl = false;
        //            lbl_cm.Foreground = Brushes.Red;
        //            lbl_cm.Content = PlayerControl;
        //        }
        //        pc = m.ReadByte("Leyak-Win64-Shipping.exe+04733CC8,0x331");
        //        xPos = m.ReadFloat("Leyak-Win64-Shipping.exe+0472A578,0x0,0x20,0x290,0x1d0");
        //        yPos = m.ReadFloat("Leyak-Win64-Shipping.exe+0472A578,0x0,0x20,0x290,0x1d4");
        //        zPos = m.ReadFloat("Leyak-Win64-Shipping.exe+0472A578,0x0,0x20,0x290,0x1d8");
        //        lbl_pos.Content = "X = " + Math.Round(xPos/100,2) + " | Y = " + Math.Round(yPos/100,2) + " | Z = " + Math.Round(yPos / 100, 2);
                
                
        //    }
        //    else
        //    {
        //        PlayerControl = false;
        //        lbl_cm.Content = "N/A";
        //        lbl_cm.Foreground = Brushes.Red;
        //        lbl_pos.Content = "X = ? | Y = ? | Z = ?";
        //    }
        //}

        private void btn_st1_Click(object sender, RoutedEventArgs e)
        {
            if (Directory.Exists(SavedGames) && Directory.Exists(Stages))
            {
                string[] files = Directory.GetFiles(Stages + @"Stage1");

                foreach (string s in files)
                {
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(SavedGames, fileName);
                    File.Copy(s, destFile, true);
                }
                lbl_st.Content = btn_st1.Content + " Loaded";
            }
            else if(!Directory.Exists(SavedGames))
            {
                lbl_st.Content = "ERROR";
                MessageBox.Show("Press NEW GAME atleast once before you try to load a stage!\nStage loader needs to have base folder for game saves");
            }
            else if(!Directory.Exists(Stages))
            {
                lbl_st.Content = "ERROR";
                MessageBox.Show("Stages path does not exist or they are invalid!\nTry to download/extract stage loader again.");
            }

        }

        private void btn_st2_Click(object sender, RoutedEventArgs e)
        {
            if (Directory.Exists(SavedGames) && Directory.Exists(Stages))
            {
                string[] files = Directory.GetFiles(Stages + @"Stage2");

                foreach (string s in files)
                {
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(SavedGames, fileName);
                    File.Copy(s, destFile, true);
                }
                lbl_st.Content = btn_st2.Content + " Loaded";
            }
            else if (!Directory.Exists(SavedGames))
            {
                lbl_st.Content = "ERROR";
                MessageBox.Show("Press NEW GAME atleast once before you try to load a stage!\nStage loader needs to have base folder for game saves");
            }
            else if (!Directory.Exists(Stages))
            {
                lbl_st.Content = "ERROR";
                MessageBox.Show("Stages path does not exist or they are invalid!\nTry to download/extract stage loader again.");
            }
        }

        private void btn_st3_Click(object sender, RoutedEventArgs e)
        {
            if (Directory.Exists(SavedGames) && Directory.Exists(Stages))
            {
                string[] files = Directory.GetFiles(Stages + @"Stage3");

                foreach (string s in files)
                {
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(SavedGames, fileName);
                    File.Copy(s, destFile, true);
                    lbl_st.Content = btn_st3.Content + " Loaded";
                }
            }
            else if (!Directory.Exists(SavedGames))
            {
                lbl_st.Content = "ERROR";
                MessageBox.Show("Press NEW GAME atleast once before you try to load a stage!\nStage loader needs to have base folder for game saves");
            }
            else if (!Directory.Exists(Stages))
            {
                lbl_st.Content = "ERROR";
                MessageBox.Show("Stages path does not exist or they are invalid!\nTry to download/extract stage loader again.");
            }
        }

        private void btn_st4_Click(object sender, RoutedEventArgs e)
        {
            if (Directory.Exists(SavedGames) && Directory.Exists(Stages))
            {
                string[] files = Directory.GetFiles(Stages + @"Stage4");

                foreach (string s in files)
                {
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(SavedGames, fileName);
                    File.Copy(s, destFile, true);
                }
                lbl_st.Content = btn_st4.Content + " Loaded";
            }
            else if (!Directory.Exists(SavedGames))
            {
                lbl_st.Content = "ERROR";
                MessageBox.Show("Press NEW GAME atleast once before you try to load a stage!\nStage loader needs to have base folder for game saves");
            }
            else if (!Directory.Exists(Stages))
            {
                lbl_st.Content = "ERROR";
                MessageBox.Show("Stages path does not exist or they are invalid!\nTry to download/extract stage loader again.");
            }
        }

        private void btn_st5_Click(object sender, RoutedEventArgs e)
        {
            if (Directory.Exists(SavedGames) && Directory.Exists(Stages))
            {
                string[] files = Directory.GetFiles(Stages + @"Stage5");

                foreach (string s in files)
                {
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(SavedGames, fileName);
                    File.Copy(s, destFile, true);
                }
                lbl_st.Content = btn_st5.Content + " Loaded";
            }
            else if (!Directory.Exists(SavedGames))
            {
                lbl_st.Content = "ERROR";
                MessageBox.Show("Press NEW GAME atleast once before you try to load a stage!\nStage loader needs to have base folder for game saves");
            }
            else if (!Directory.Exists(Stages))
            {
                lbl_st.Content = "ERROR";
                MessageBox.Show("Stages path does not exist or they are invalid!\nTry to download/extract stage loader again.");
            }
        }

        private void btn_st6_Click(object sender, RoutedEventArgs e)
        {
            if (Directory.Exists(SavedGames) && Directory.Exists(Stages))
            {
                string[] files = Directory.GetFiles(Stages + @"Stage6");

                foreach (string s in files)
                {
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(SavedGames, fileName);
                    File.Copy(s, destFile, true);
                    lbl_st.Content = btn_st6.Content + " Loaded";
                }
            }
            else if (!Directory.Exists(SavedGames))
            {
                lbl_st.Content = "ERROR";
                MessageBox.Show("Press NEW GAME atleast once before you try to load a stage!\nStage loader needs to have base folder for game saves");
            }
            else if (!Directory.Exists(Stages))
            {
                lbl_st.Content = "ERROR";
                MessageBox.Show("Stages path does not exist or they are invalid!\nTry to download/extract stage loader again.");
            }
        }

        private void btn_st7_Click(object sender, RoutedEventArgs e)
        {
            if (Directory.Exists(SavedGames) && Directory.Exists(Stages))
            {
                string[] files = Directory.GetFiles(Stages + @"Stage7");

                foreach (string s in files)
                {
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(SavedGames, fileName);
                    File.Copy(s, destFile, true);
                }
                lbl_st.Content = btn_st7.Content + " Loaded";
            }
            else if (!Directory.Exists(SavedGames))
            {
                lbl_st.Content = "ERROR";
                MessageBox.Show("Press NEW GAME atleast once before you try to load a stage!\nStage loader needs to have base folder for game saves");
            }
            else if (!Directory.Exists(Stages))
            {
                lbl_st.Content = "ERROR";
                MessageBox.Show("Stages path does not exist or they are invalid!\nTry to download/extract stage loader again.");
            }
        }

        private void btn_st8_Click(object sender, RoutedEventArgs e)
        {
            if (Directory.Exists(SavedGames) && Directory.Exists(Stages))
            {
                string[] files = Directory.GetFiles(Stages + @"Stage8");

                foreach (string s in files)
                {
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(SavedGames, fileName);
                    File.Copy(s, destFile, true);
                }
                lbl_st.Content = btn_st8.Content + " Loaded";
            }
            else if (!Directory.Exists(SavedGames))
            {
                lbl_st.Content = "ERROR";
                MessageBox.Show("Press NEW GAME atleast once before you try to load a stage!\nStage loader needs to have base folder for game saves");
            }
            else if (!Directory.Exists(Stages))
            {
                lbl_st.Content = "ERROR";
                MessageBox.Show("Stages path does not exist or they are invalid!\nTry to download/extract stage loader again.");
            }
        }


    }
}
