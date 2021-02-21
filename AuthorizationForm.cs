using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardAnalyser
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\KeyboardAnalyserProperties"))
                rememberMeChB.Checked = key.GetValue("AutoLogOn").ToString() == "true" ? rememberMeChB.Checked = true: rememberMeChB.Checked = false;
            RegistryKey key2 = Registry.CurrentUser.OpenSubKey(@"Software\KeyboardAnalyserProperties");


        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            using (RegistryKey key2 = Registry.CurrentUser.OpenSubKey(@"Software\KeyboardAnalyserProperties"))
                if (passwordTB.Text == key2?.GetValue("UsPassword")?.ToString() & loginTB.Text == key2?.GetValue("UsLogin")?.ToString())
                {
                    this.Hide();
                    MainForm registerForm = new MainForm();
                    registerForm.Show();
                }
                else
                    MessageBox.Show("Проверьте данные пользователя");
            if (loginTB.Text == "")
                MessageBox.Show("Сначала введите логин");
            if (passwordTB.Text == "")
                MessageBox.Show("Кажется, вы не ввели пароль");

        }

        private void linkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X,e.Y);
        }
        private void rememberMeChB_Checked(object sender, MouseEventArgs e)
        {

        }

        private void rememberMeChB_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\KeyboardAnalyserProperties");
            if (rememberMeChB.Checked == true)
                key.SetValue("AutoLogOn", "true");
            else
                key.SetValue("AutoLogOn", "false");
        }
    }
}
