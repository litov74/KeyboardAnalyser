using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
//using WikiReader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardAnalyser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //here such objects as RegKey are done. P.S. I don't make .Close() cause then the registry will be reopened many times
            RegistryKey registryCreate = Registry.CurrentUser.CreateSubKey(@"Software\KeyboardAnalyserProperties");
            RegistryKey registryRead = Registry.CurrentUser.OpenSubKey(@"Software\KeyboardAnalyserProperties");
            if (registryRead?.GetValue("")?.ToString() != "0x10000000")
            {
                // don't touch "" (null value). This shit is used to initialise if the params exist!
                //by adding anything to this list, you add one more value to registry
                registryCreate.SetValue("", "0x10000000");
                registryCreate.SetValue("StrangerThings", "1");
                registryCreate.SetValue("Begin", "0");
                registryCreate.SetValue("Mistakes", "0");
                registryCreate.SetValue("Speed", "0");
                registryCreate.SetValue("Layers", "0");
                registryCreate.SetValue("AutoRun", "0");
                registryCreate.SetValue("Accuracy", "75");
                registryCreate.SetValue("HiddenTreasure", "0");
                registryCreate.SetValue("Defence", "1");
                registryCreate.SetValue("ProfilePic", "");
                registryCreate.SetValue("UsName", "");
                registryCreate.SetValue("UsSurname", "");
                registryCreate.SetValue("UsLogin", "");
                registryCreate.SetValue("UsPassword", "");
                registryCreate.SetValue("AutoLogOn", "false");
                registryCreate.SetValue("Virgin", "1");
                registryCreate.SetValue("Up", "0");
                registryCreate.SetValue("Down", "0");
                registryCreate.SetValue("ATTENTION", "0");
                registryCreate.SetValue("FreqLetter", "");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            //Here the program firstly choose what would be opened firstly. NEVER do thin actions in Forms, or you'll have a critical error.
            if (registryRead.GetValue("AutoLogOn").ToString() == "true")
                Application.Run(new MainForm());
            else if (registryRead.GetValue("Virgin").ToString() == "0")
                Application.Run(new AuthorizationForm());
            else if (registryRead.GetValue("Virgin").ToString() == "1")
                Application.Run(new RegisterForm());


            

            if (registryRead.GetValue("Begin").ToString() == "1")
            {
                if (registryRead.GetValue("HiddenTreasure").ToString() == "1")
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = Path.Combine("cmd.exe", "");

                    proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.StartInfo.CreateNoWindow = true;

                    proc.StartInfo.RedirectStandardOutput = true;

                    proc.StartInfo.UseShellExecute = false;
                    proc.Start();
                }
            }
        }
    }
    

}