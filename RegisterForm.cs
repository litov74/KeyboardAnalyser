using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Runtime.Serialization.Formatters;

namespace KeyboardAnalyser
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            
            //using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"Software\KeyboardAnalyserProperties"))
            //{
            //    if (registryKey.GetValue("UsName").ToString() != "1")
            //    {
            //        AuthorizationForm k = new AuthorizationForm();
            //        this.Close();
            //        k.Show();
            //    }
            //
            //
            //}
            nameReg.Text = "Имя";
            surnameReg.Text = "Фамилия";
            loginRegTB.Text = "Введите ваш логин";
            passwordRegTB1.Text = "Введите ваш пароль";
            passwordRegTB2.Text = "Подтверждение";
            


            
            
            

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (loginRegTB.Text == "Введите ваш логин")
            {
                MessageBox.Show("Введите ваш логин");
                return;
            }

            if (passwordRegTB1.Text == "Введите ваш пароль")
            {
                MessageBox.Show("Введите ваш пароль");
                return;
            }

            if (nameReg.Text == "Имя")
            {
                MessageBox.Show("Имя");
                return;
            }

            if (surnameReg.Text == "Фамилия")
            {
                MessageBox.Show("Фамилия");
                return;
            }

            if (surnameReg.Text == "Фамилия" && nameReg.Text == "Имя" && passwordRegTB1.Text == "Введите ваш пароль" && loginRegTB.Text == "Введите ваш логин")
            {
                MessageBox.Show("Сначала заполните все поля");
                return;
            }

            RegistryKey registryCreate = Registry.CurrentUser.CreateSubKey(@"Software\KeyboardAnalyserProperties");
            registryCreate.SetValue("UsName", nameReg.Text);
            registryCreate.SetValue("UsSurname", surnameReg.Text);
            registryCreate.SetValue("UsLogin", loginRegTB.Text);
            registryCreate.SetValue("UsPassword", passwordRegTB1.Text);
            
            registryCreate.SetValue("AutoLogOn", "");
            registryCreate.SetValue("Virgin", "0");
            this.Hide();
            AuthorizationForm k = new AuthorizationForm();
            k.Show();
        }



        private void loginRegTB_Enter(object sender, EventArgs e)
        {
            if (loginRegTB.Text == "Введите ваш логин")
                loginRegTB.Text = "";
        }

        private void loginRegTB_Leave(object sender, EventArgs e)
        {
            if (loginRegTB.Text == "")
                loginRegTB.Text = "Введите ваш логин";
        }

        private void passwordRegTB1_Enter(object sender, EventArgs e)
        {
            if (passwordRegTB1.Text == "Введите ваш пароль")
            {
                passwordRegTB1.Text = "";
                
            }
        }

        private void passwordRegTB1_Leave(object sender, EventArgs e)
        {
            if (passwordRegTB1.Text == "")
            {
                passwordRegTB1.Text = "Введите ваш пароль";

            }
            
        }

        private void nameReg_Enter(object sender, EventArgs e)
        {
            if (nameReg.Text == "Имя")
                nameReg.Text = "";
        }

        private void nameReg_Leave(object sender, EventArgs e)
        {
            if (nameReg.Text == "")
                nameReg.Text = "Имя";
        }

        private void surnameReg_Enter(object sender, EventArgs e)
        {
            if (surnameReg.Text == "Фамилия")
                surnameReg.Text = "";
        }

        private void surnameReg_Leave(object sender, EventArgs e)
        {
            if (surnameReg.Text == "")
                surnameReg.Text = "Фамилия";
        }

        private void passwordRegTB2_Enter(object sender, EventArgs e)
        {
            if (passwordRegTB2.Text == "Подтверждение")
                passwordRegTB2.Text = "";
        }

        private void passwordRegTB2_Leave(object sender, EventArgs e)
        {
            if (passwordRegTB2.Text == "")
                passwordRegTB2.Text = "Подтверждение";
            if (passwordRegTB1.Text != passwordRegTB2.Text)
                passwordRegTB2.BackColor = Color.Yellow;
            if (passwordRegTB1.Text == passwordRegTB2.Text)
                passwordRegTB2.BackColor = passwordRegTB1.BackColor;

        }

        



        private void linkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            AuthorizationForm a = new AuthorizationForm();
            a.Show();
        }
        Point lastPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
