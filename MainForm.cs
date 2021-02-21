using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace KeyboardAnalyser
{
    public partial class MainForm : Form
    {
        [DllImport("user32")]
        public static extern void LockWorkStation();
        public MainForm()
        {
            InitializeComponent();

            //after initializing our form, we restore options, chosen before.
            //Whole this module resores options
            // [READY]  

            RegistryKey registryRead = Registry.CurrentUser.OpenSubKey(@"Software\KeyboardAnalyserProperties");
            CurrentName.Text = registryRead.GetValue("UsName").ToString();
            accuracy.Text = registryRead.GetValue("Accuracy").ToString();
            CurrentSurname.Text = registryRead.GetValue("UsSurname").ToString();
            mistakesAmmo.Text = registryRead.GetValue("Mistakes").ToString();
            layers.Text = registryRead.GetValue("Layers").ToString();
            freqLetter.Text = registryRead.GetValue("FreqLetter").ToString();
            //speed.Text = registryRead.GetValue("Speed").ToString();
            using (RegistryKey registryRead2 = Registry.CurrentUser.OpenSubKey(@"Software\KeyboardAnalyserProperties"))
                if (registryRead2.GetValue("ProfilePic").ToString() != "")
                    profilePicture.Image = new Bitmap(registryRead2.GetValue("ProfilePic").ToString());
            if (registryRead.GetValue("Defence").ToString() == "1")
                gistogram.Checked = true;
            if (registryRead.GetValue("Defence").ToString() == "2")
                lagsAndLayers.Checked = true;
            if (registryRead.GetValue("Defence").ToString() == "3")
                bothWays.Checked = true;
            if (registryRead.GetValue("StrangerThings").ToString() == "1")
                shutdownPC.Checked = true;
            if (registryRead.GetValue("StrangerThings").ToString() == "2")
                lockPC.Checked = true;
            if (registryRead.GetValue("StrangerThings").ToString() == "3")
                warnUser.Checked = true;
            if (registryRead.GetValue("AutoRun").ToString() == "0")
                autorunChB.Checked = false;
            if (registryRead.GetValue("AutoRun").ToString() == "1")
                autorunChB.Checked = true;
            if (registryRead.GetValue("HiddenTreasure").ToString() == "1")
                hiddenTreasure.Checked = true;
            if (registryRead.GetValue("HiddenTreasure").ToString() == "0")
                hiddenTreasure.Checked = false;

            //end of restoring module


        }



        //this button was [REMOVED]!
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // point helps us to move whole window [READY]
        Point lastPoint;

        private void MainForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MainForm_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        //this can hide programm, that is why it is [NOT READY]
        //well, it works MB



        //this module adds program to autorun [READY]
        private void autorunChB_Checked(object sender, EventArgs e)
        {
            RegistryKey registryRead = Registry.CurrentUser.CreateSubKey(@"Software\KeyboardAnalyserProperties");
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (autorunChB.Checked == true)
            {
                registryRead.SetValue("AutoRun", "1");
                reg.SetValue("Keyboard Analyser", Application.ExecutablePath.ToString());
            }
            if (autorunChB.Checked == false)
            {
                registryRead.SetValue("AutoRun", "0");
                reg.DeleteValue("Keyboard Analyser");
            }
        }


        // allows us to choose our profile picture and store to registry route to photo [READY] 
        private void profilePicture_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Выбор обложки профиля";
            openFileDialog1.DefaultExt = "JPEG";
            openFileDialog1.Filter = "Images(*.BMP; *.JPG; *.GIF,*.PNG,*.TIFF)| *.BMP; *.JPG; *.GIF; *.PNG; *.TIFF |" + "All files (*.*)|*.*";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                RegistryKey registryWrite = Registry.CurrentUser.CreateSubKey(@"Software\KeyboardAnalyserProperties");
                registryWrite.SetValue("ProfilePic", openFileDialog1.FileName);
                profilePicture.Image = new Bitmap(openFileDialog1.FileName);

            }
        }
        //opens a form to change a PW [READY]
        private void ChangePassword_Click(object sender, EventArgs e)
        {
            ChangePW k = new ChangePW();
            this.Hide();
            k.Show();
        }
        // _________________________________________________________________________________________________________
        //___________________________________________________________________________________________________________
        // only
        //      for
        //          choosing
        //                      defence
        //                                  method
        //
        //


        private void gistogram_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey registryWrite = Registry.CurrentUser.CreateSubKey(@"Software\KeyboardAnalyserProperties");
            if (gistogram.Checked == true)
                registryWrite.SetValue("Defence", "1");
        }

        private void lagsAndLayers_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey registryWrite = Registry.CurrentUser.CreateSubKey(@"Software\KeyboardAnalyserProperties");
            if (lagsAndLayers.Checked == true)
                registryWrite.SetValue("Defence", "2");
        }

        private void bothWays_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey registryWrite = Registry.CurrentUser.CreateSubKey(@"Software\KeyboardAnalyserProperties");
            if (bothWays.Checked == true)
                registryWrite.SetValue("Defence", "3");
        }
        //___________________________________________________________________________________________________________
        //END OF DEFENCE MODULE
        //
        //

        //OPENS a Calibration window [READY]
        private void calibrate_Click(object sender, EventArgs e)
        {
            Calibrate k = new Calibrate();
            this.Hide();
            k.Show();
        }


        //nulls our results [READY]
        private void setNull_Click(object sender, EventArgs e)
        {
            RegistryKey registryWrite = Registry.CurrentUser.CreateSubKey(@"Software\KeyboardAnalyserProperties");
            registryWrite.SetValue("Layers", "0");
            registryWrite.SetValue("Mistakes", "0");
            registryWrite.SetValue("FreqLetter", "");
            freqLetter.Text = "";
            layers.Text = "0";
            mistakesAmmo.Text = "0";
        }

        //some bullshit. IDK what is it. [FAILS]
        private void accuracy_Leave(object sender, EventArgs e)
        {

            RegistryKey registryWrite = Registry.CurrentUser.CreateSubKey(@"Software\KeyboardAnalyserProperties");
            if (accuracy.Text == "" | int.Parse(accuracy.Text) > 100 | int.Parse(accuracy.Text) < 0)
                accuracy.Text = registryWrite.GetValue("Accuracy").ToString();
            else
                registryWrite.SetValue("Accuracy", accuracy.Text);
        }
        GlobalKeyboardHook ghook;
        bool keyleft = false;
        bool keyup = false;
        int layer = 0;
        int mistake = 0;
        RegistryKey registryWrite = Registry.CurrentUser.CreateSubKey(@"Software\KeyboardAnalyserProperties");
        RegistryKey registryRead = Registry.CurrentUser.OpenSubKey(@"Software\KeyboardAnalyserProperties");
        private void launch_Click(object sender, EventArgs e)
        {


            if (registryRead.GetValue("Layers").ToString() == "0" || registryRead.GetValue("Mistakes").ToString() == "0")
            {
                MessageBox.Show("Сначала откалибруйте программу.");
                return;
            }


            else if (registryRead.GetValue("Layers").ToString() != "0" || registryRead.GetValue("Mistakes").ToString() != "0")
            {
                //this.Hide();
                if (registryRead.GetValue("HiddenTreasure").ToString() == "1")
                {
                    this.Hide();

                }
                ghook = new GlobalKeyboardHook();
                ghook.KeyDown += new System.Windows.Forms.KeyEventHandler(ghook_KeyDown);
                foreach (Keys key in Enum.GetValues(typeof(Keys)))
                    ghook.HookedKeys.Add(key);
                ghook.hook();


            }

        }

        public void ghook_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            inputBox.Text += ((char)e.KeyValue).ToString();
            //Проверяем наложения вот тут
/*
            if (e.KeyCode == Keys.Q || e.KeyCode == Keys.W || e.KeyCode == Keys.E || e.KeyCode == Keys.R || e.KeyCode == Keys.T || e.KeyCode == Keys.Y || e.KeyCode == Keys.A || e.KeyCode == Keys.S || e.KeyCode == Keys.D || e.KeyCode == Keys.F || e.KeyCode == Keys.G || e.KeyCode == Keys.H || e.KeyCode == Keys.Z || e.KeyCode == Keys.X || e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.B)
            {
                keyup = true;
            }
            if (e.KeyCode == Keys.U || e.KeyCode == Keys.I || e.KeyCode == Keys.O || e.KeyCode == Keys.P || e.KeyCode == Keys.J || e.KeyCode == Keys.K || e.KeyCode == Keys.L || e.KeyCode == Keys.N || e.KeyCode == Keys.M)
            {
                keyleft = true;
            }
            else
            {
                keyleft = true;
            }
            if (keyleft && keyup)                                           [НЕ РАБОТАЕТ]
            {

                layer += 1;
            }
            */
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                mistake += 1;
            }
            if (e.KeyCode == Keys.Space)
            {
                mistake = 0;
                layer = 0;
            }
                
            
            
            if (mistake > int.Parse(registryRead.GetValue("Mistakes").ToString()) | layer > int.Parse(registryRead.GetValue("Layers").ToString()))
            {
                mistake = 0;
                layer = 0;
                if (registryRead.GetValue("StrangerThings").ToString() == "1")
                {
                    var psi = new ProcessStartInfo("shutdown", "/s /t 0");
                    psi.CreateNoWindow = true;
                    psi.UseShellExecute = false;
                    Process.Start(psi);
                }
                if (registryRead.GetValue("StrangerThings").ToString() == "2")
                {
                    LockWorkStation();
                }
                if (registryRead.GetValue("StrangerThings").ToString() == "3")
                {
                    MessageBox.Show("Внимание, подозрительная активность!");
                }
            }
        }
                
        public void ghook_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Q || e.KeyCode == Keys.W || e.KeyCode == Keys.E || e.KeyCode == Keys.R || e.KeyCode == Keys.T || e.KeyCode == Keys.Y || e.KeyCode == Keys.A || e.KeyCode == Keys.S || e.KeyCode == Keys.D || e.KeyCode == Keys.F || e.KeyCode == Keys.G || e.KeyCode == Keys.H || e.KeyCode == Keys.Z || e.KeyCode == Keys.X || e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.B)
            {
                keyup = false;

                layer = 0;
                
                
            }
            else if (e.KeyCode == Keys.U || e.KeyCode == Keys.I || e.KeyCode == Keys.O || e.KeyCode == Keys.P || e.KeyCode == Keys.J || e.KeyCode == Keys.K || e.KeyCode == Keys.L || e.KeyCode == Keys.N || e.KeyCode == Keys.M)
            {
                keyleft = false;
            }
        } 
            

        private void hiddenTreasure_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey registryWrite = Registry.CurrentUser.CreateSubKey(@"Software\KeyboardAnalyserProperties");
            if (hiddenTreasure.Checked == true)
            {
                
                registryWrite.SetValue("HiddenTreasure", "1");
                this.ShowInTaskbar = false;

            }
            else
            {
                registryWrite.SetValue("HiddenTreasure", "0");
            }
            
        }

        private void shutdownPC_CheckedChanged(object sender, EventArgs e)
        {
            if (shutdownPC.Checked == true)
            {
                registryWrite.SetValue("StrangerThings", "1");
            }
        }

        private void lockPC_CheckedChanged(object sender, EventArgs e)
        {
            if (lockPC.Checked == true)
            {
                registryWrite.SetValue("StrangerThings", "2");
            }
        }

        private void warnUser_CheckedChanged(object sender, EventArgs e)
        {
            if (warnUser.Checked == true)
            {
                registryWrite.SetValue("StrangerThings", "3");
            }
        }
    }



}
