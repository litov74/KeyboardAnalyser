using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardAnalyser
{
    public partial class ChangePW : Form
    {
        public ChangePW()
        {
            InitializeComponent();
            passwordTB.Text = "Старый пароль";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
             using (RegistryKey key2 = Registry.CurrentUser.CreateSubKey(@"Software\KeyboardAnalyserProperties"))
                if (passwordTB.Text == key2?.GetValue("UsPassword")?.ToString() & passwordTBNew.Text != "" & passwordTBNew2.Text == passwordTBNew.Text)
                {
                    key2.SetValue("UsPassword", passwordTBNew.Text);
                    MessageBox.Show("Вы сменили пароль пользователя!");
                    MainForm k = new MainForm();
                    this.Hide();
                    k.Show();
                }
                else
                    MessageBox.Show("Проверьте данные пользователя");

        }

        private void passwordTB_Enter(object sender, EventArgs e)
        {
            if (passwordTB.Text == "Старый пароль")
            {
                passwordTB.Text = "";

            }
        }

        private void passwordTB_Leave(object sender, EventArgs e)
        {
            if (passwordTB.Text == "")
            {
                passwordTB.Text = "Старый пароль";

            }
        }

        private void passwordTBNew_Enter(object sender, EventArgs e)
        {
            if (passwordTBNew.Text == "Новый пароль")
            {
                passwordTBNew.Text = "";

            }
        }

        private void passwordTBNew_Leave(object sender, EventArgs e)
        {
            if (passwordTBNew.Text == "")
            {
                passwordTBNew.Text = "Новый пароль";

            }
        }

        private void passwordTBNew2_Enter(object sender, EventArgs e)
        {
            if (passwordTBNew2.Text == "Новый пароль")
            {
                passwordTBNew2.Text = "";

            }
        }

        private void passwordTBNew2_Leave(object sender, EventArgs e)
        {
            if (passwordTBNew2.Text == "")
            {
                passwordTBNew2.Text = "Новый пароль";

            }
            if (passwordTBNew2.Text != passwordTBNew.Text)
                passwordTBNew2.BackColor = Color.Red;
            else
                passwordTBNew2.BackColor = Color.White;
        }
    }
}
