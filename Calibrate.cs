using System.Windows.Input;
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
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using System.Security.Cryptography;

namespace KeyboardAnalyser
{
    public partial class Calibrate : Form
    {
        public Calibrate()
        {
            InitializeComponent();
            textBox2.Text = "";
        }


        //gets you back to main screen
        private void getBack_Click(object sender, EventArgs e)
        {
            MainForm k = new MainForm();
            this.Hide();
            k.Show();
        }


        
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }
        /*
         * The next part controls if the key is DOWN and other is not UP
         *
         * 
         * 
         *ВНИМАНИЕ: НЕ КАЖДАЯ КЛАВИАТУРА МОЖЕТ ОДНОВРЕМЕННО ОТПРАВЛЯТЬ НЕСКОЛЬКО НАЖАТИЙ 
         * ПРИКОЛ В ТОМ, ЧТО ТОЛЬКО ВОТ ТАК МОЖНО РЕШИТЬ ВОПРОС С НАЛОЖЕНИЯМИ. ЕДИНСТВЕННЫЙ МЕТОД!
         * 
         * Проверено на клавиатуре LANTEC 104 USB (не работает), на Genius 104 PS/2 (работает хорошо)
         * Возможно, будет работать отлично на МЕХАНИЧЕСКОЙ клавиатуре, но меня не так хорошо спонсируют, чтобы это покупать.
         * 
         * 
         * [ПРАВКА от 30.04.20:05.00] Работает с ЛЮБЫМИ клавиатурами. Баг пофиксили, время работает адекватно (хоть и практически не используется)
         */
        bool keyup = false;
        bool keyleft = false;
        
        int layers = 1;
        int space = 0;
        Stopwatch t = new Stopwatch();
        double time = 0;
        RegistryKey registryWrite = Registry.CurrentUser.CreateSubKey(@"Software\KeyboardAnalyserProperties");
        Stopwatch sw = new Stopwatch();
        int mistake = 0;
        GlobalKeyboardHook kk = new GlobalKeyboardHook();
        private void textBox2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            t.Start();
            if (e.KeyCode == Keys.Q || e.KeyCode == Keys.W || e.KeyCode == Keys.E || e.KeyCode == Keys.R || e.KeyCode == Keys.T || e.KeyCode == Keys.Y || e.KeyCode == Keys.A || e.KeyCode == Keys.S || e.KeyCode == Keys.D || e.KeyCode == Keys.F || e.KeyCode == Keys.G || e.KeyCode == Keys.H || e.KeyCode == Keys.Z || e.KeyCode == Keys.X || e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.B)
            {
                keyup = true;
            }
            if (e.KeyCode == Keys.U || e.KeyCode == Keys.I || e.KeyCode == Keys.O || e.KeyCode == Keys.P || e.KeyCode == Keys.J || e.KeyCode == Keys.K || e.KeyCode == Keys.L || e.KeyCode == Keys.N || e.KeyCode == Keys.M )
            {
                keyleft = true;
            }
            else
            {
                keyleft = true;
            }
            if (keyleft && keyup)
            {
                
                layers += 1;
            }
            
            if (e.KeyValue == (char)Keys.Delete || e.KeyValue == (char)Keys.Back)
            {
                mistake += 1;
                if (mistake > 6)
                {
                    mistake = 0;
                }
                    //Таймер срабатывет через 1с. после активации. О какой скорости мы говорим?
                    //сделал 2 таймера. шош пусть будет, так даже вроде работает

            }
            if (e.KeyValue == (char)Keys.Space || e.KeyValue == (char)Keys.Enter)
            {
                if (int.Parse(time.ToString()) > int.Parse(registryWrite.GetValue("Speed").ToString()))
                {
                    registryWrite.SetValue("Speed", time.ToString());

                }
                if (mistake > Int32.Parse(registryWrite.GetValue("Mistakes").ToString()))
                {
                    registryWrite.SetValue("Mistakes", mistake.ToString());
                    mistake = 0;
                }
                registryWrite.SetValue("Speed", sw.ElapsedMilliseconds.ToString());
                if (Int32.Parse(registryWrite.GetValue("Layers").ToString()) < layers)
                {
                    //у количества наложений стоит /=2. деление на 2 из-за разницы в двух словах. примерное значенние должно быть 3-5.
                    layers /= 2;
                    registryWrite.SetValue("Layers", layers.ToString());
                    layers = 0;
                }
                
            }
            registryWrite.SetValue("FreqLetter", freq(textBox2.Text).ToString());
        }

        private void textBox2_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            t.Stop();
            time += Convert.ToDouble(t.ElapsedMilliseconds);
            t.Reset();
            if (e.KeyCode == Keys.Q || e.KeyCode == Keys.W || e.KeyCode == Keys.E || e.KeyCode == Keys.R || e.KeyCode == Keys.T || e.KeyCode == Keys.Y || e.KeyCode == Keys.A || e.KeyCode == Keys.S || e.KeyCode == Keys.D || e.KeyCode == Keys.F || e.KeyCode == Keys.G || e.KeyCode == Keys.H || e.KeyCode == Keys.Z || e.KeyCode == Keys.X || e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.B)
            {
                keyup = false;

                //layers = 0;
                if (sw.IsRunning)
                {
                    sw.Stop();
                    if (sw.ElapsedMilliseconds > 3000)
                    {
                        sw.Reset();
                    }
                }
            }
            else if (e.KeyCode == Keys.U || e.KeyCode == Keys.I || e.KeyCode == Keys.O || e.KeyCode == Keys.P || e.KeyCode == Keys.J || e.KeyCode == Keys.K || e.KeyCode == Keys.L || e.KeyCode == Keys.N || e.KeyCode == Keys.M)
            {
                keyleft = false;
            }
        }
        //Определяем самую частовстречаемую букву/символ
        //можно выбрать Value или freq, по настроению. Работают оба. Для разработки проще freq, для работы без разницы
        private static char Value(string s)
        {
            return(s.Select(x => new { Symbol = x, Count = s.Count(y => y == x) }).OrderByDescending(x => x.Count).First().Symbol);
        }
        static Char freq (string s)
        {
            int[] count = new int[2048];
            int max = 0;
            Char result = Char.MinValue;
            Array.Clear(count, 0, count.Length-1);
            foreach (Char c in s)
                if (++count[c]>max)
                {
                    max = count[c];
                    result = c;

                }
            return result;
        }
        


    }
}
