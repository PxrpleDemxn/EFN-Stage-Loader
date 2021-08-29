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

namespace EFN_StageLoader
{
    public partial class StageLoader : Window
    {
        string Stages = @"stages\";
        string SavedGames = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Leyak\Saved\SaveGames";
        string fileName = string.Empty;
        string destFile = string.Empty;

        int xd = 0;

        public StageLoader()
        {
            InitializeComponent();

            DispatcherTimer Timer = new DispatcherTimer();
            Timer.Tick += Timer_Tick;
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
        }

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
            }
            else
            {
                MessageBox.Show("Source path does not exist!");
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
            }
            else
            {
                MessageBox.Show("Source path does not exist!");
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
                }
            }
            else
            {
                MessageBox.Show("Source path does not exist!");
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
            }
            else
            {
                MessageBox.Show("Source path does not exist!");
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
            }
            else
            {
                MessageBox.Show("Source path does not exist!");
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
                }
            }
            else
            {
                MessageBox.Show("Source path does not exist!");
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
            }
            else
            {
                MessageBox.Show("Source path does not exist!");
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
            }
            else
            {
                MessageBox.Show("Source path does not exist!");
            }
        }


    }
}
