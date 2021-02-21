namespace KeyboardAnalyser
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lagsAndLayers = new System.Windows.Forms.RadioButton();
            this.gistogram = new System.Windows.Forms.RadioButton();
            this.bothWays = new System.Windows.Forms.RadioButton();
            this.warnUser = new System.Windows.Forms.RadioButton();
            this.shutdownPC = new System.Windows.Forms.RadioButton();
            this.lockPC = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.action = new System.Windows.Forms.Panel();
            this.defenceMethod = new System.Windows.Forms.Panel();
            this.autorunChB = new System.Windows.Forms.CheckBox();
            this.hiddenTreasure = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CurrentName = new System.Windows.Forms.Label();
            this.CurrentSurname = new System.Windows.Forms.Label();
            this.ChangePassword = new System.Windows.Forms.Button();
            this.launch = new System.Windows.Forms.Button();
            this.calibrate = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mistakesAmmo = new System.Windows.Forms.Label();
            this.setNull = new System.Windows.Forms.Button();
            this.layers = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.accuracy = new System.Windows.Forms.TextBox();
            this.freqLetter = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.action.SuspendLayout();
            this.defenceMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lagsAndLayers
            // 
            this.lagsAndLayers.AutoSize = true;
            this.lagsAndLayers.Location = new System.Drawing.Point(3, 33);
            this.lagsAndLayers.Name = "lagsAndLayers";
            this.lagsAndLayers.Size = new System.Drawing.Size(195, 24);
            this.lagsAndLayers.TabIndex = 12;
            this.lagsAndLayers.TabStop = true;
            this.lagsAndLayers.Text = "Ошибки и наложения";
            this.lagsAndLayers.UseVisualStyleBackColor = true;
            this.lagsAndLayers.CheckedChanged += new System.EventHandler(this.lagsAndLayers_CheckedChanged);
            // 
            // gistogram
            // 
            this.gistogram.AutoSize = true;
            this.gistogram.Location = new System.Drawing.Point(3, 3);
            this.gistogram.Name = "gistogram";
            this.gistogram.Size = new System.Drawing.Size(154, 24);
            this.gistogram.TabIndex = 13;
            this.gistogram.TabStop = true;
            this.gistogram.Text = "Гистограммный";
            this.gistogram.UseVisualStyleBackColor = true;
            this.gistogram.CheckedChanged += new System.EventHandler(this.gistogram_CheckedChanged);
            // 
            // bothWays
            // 
            this.bothWays.AutoSize = true;
            this.bothWays.Location = new System.Drawing.Point(3, 63);
            this.bothWays.Name = "bothWays";
            this.bothWays.Size = new System.Drawing.Size(64, 24);
            this.bothWays.TabIndex = 14;
            this.bothWays.TabStop = true;
            this.bothWays.Text = "Оба";
            this.bothWays.UseVisualStyleBackColor = true;
            this.bothWays.CheckedChanged += new System.EventHandler(this.bothWays_CheckedChanged);
            // 
            // warnUser
            // 
            this.warnUser.AutoSize = true;
            this.warnUser.Location = new System.Drawing.Point(3, 58);
            this.warnUser.Name = "warnUser";
            this.warnUser.Size = new System.Drawing.Size(147, 24);
            this.warnUser.TabIndex = 18;
            this.warnUser.TabStop = true;
            this.warnUser.Text = "Предупредить";
            this.warnUser.UseVisualStyleBackColor = true;
            this.warnUser.CheckedChanged += new System.EventHandler(this.warnUser_CheckedChanged);
            // 
            // shutdownPC
            // 
            this.shutdownPC.AutoSize = true;
            this.shutdownPC.Location = new System.Drawing.Point(3, 0);
            this.shutdownPC.Name = "shutdownPC";
            this.shutdownPC.Size = new System.Drawing.Size(122, 24);
            this.shutdownPC.TabIndex = 17;
            this.shutdownPC.TabStop = true;
            this.shutdownPC.Text = "Выключить";
            this.shutdownPC.UseVisualStyleBackColor = true;
            this.shutdownPC.CheckedChanged += new System.EventHandler(this.shutdownPC_CheckedChanged);
            // 
            // lockPC
            // 
            this.lockPC.AutoSize = true;
            this.lockPC.Location = new System.Drawing.Point(3, 28);
            this.lockPC.Name = "lockPC";
            this.lockPC.Size = new System.Drawing.Size(153, 24);
            this.lockPC.TabIndex = 16;
            this.lockPC.TabStop = true;
            this.lockPC.Text = "Заблокировать";
            this.lockPC.UseVisualStyleBackColor = true;
            this.lockPC.CheckedChanged += new System.EventHandler(this.lockPC_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Настройки программы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Метод защиты:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Действие при подозрительной активности:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Запускать при включении?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Скрыть от пользователя?";
            // 
            // action
            // 
            this.action.Controls.Add(this.warnUser);
            this.action.Controls.Add(this.lockPC);
            this.action.Controls.Add(this.shutdownPC);
            this.action.Location = new System.Drawing.Point(483, 196);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(164, 87);
            this.action.TabIndex = 35;
            // 
            // defenceMethod
            // 
            this.defenceMethod.Controls.Add(this.bothWays);
            this.defenceMethod.Controls.Add(this.lagsAndLayers);
            this.defenceMethod.Controls.Add(this.gistogram);
            this.defenceMethod.Location = new System.Drawing.Point(483, 62);
            this.defenceMethod.Name = "defenceMethod";
            this.defenceMethod.Size = new System.Drawing.Size(218, 91);
            this.defenceMethod.TabIndex = 36;
            // 
            // autorunChB
            // 
            this.autorunChB.AutoSize = true;
            this.autorunChB.Location = new System.Drawing.Point(716, 331);
            this.autorunChB.Name = "autorunChB";
            this.autorunChB.Size = new System.Drawing.Size(22, 21);
            this.autorunChB.TabIndex = 38;
            this.autorunChB.UseVisualStyleBackColor = true;
            this.autorunChB.CheckedChanged += new System.EventHandler(this.autorunChB_Checked);
            // 
            // hiddenTreasure
            // 
            this.hiddenTreasure.AutoSize = true;
            this.hiddenTreasure.Location = new System.Drawing.Point(716, 365);
            this.hiddenTreasure.Name = "hiddenTreasure";
            this.hiddenTreasure.Size = new System.Drawing.Size(22, 21);
            this.hiddenTreasure.TabIndex = 39;
            this.hiddenTreasure.UseVisualStyleBackColor = true;
            this.hiddenTreasure.CheckedChanged += new System.EventHandler(this.hiddenTreasure_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Вы вошли как:";
            // 
            // CurrentName
            // 
            this.CurrentName.AutoSize = true;
            this.CurrentName.Location = new System.Drawing.Point(72, 42);
            this.CurrentName.Name = "CurrentName";
            this.CurrentName.Size = new System.Drawing.Size(0, 20);
            this.CurrentName.TabIndex = 42;
            // 
            // CurrentSurname
            // 
            this.CurrentSurname.AutoSize = true;
            this.CurrentSurname.Location = new System.Drawing.Point(72, 62);
            this.CurrentSurname.Name = "CurrentSurname";
            this.CurrentSurname.Size = new System.Drawing.Size(0, 20);
            this.CurrentSurname.TabIndex = 43;
            // 
            // ChangePassword
            // 
            this.ChangePassword.Location = new System.Drawing.Point(109, 86);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(162, 33);
            this.ChangePassword.TabIndex = 45;
            this.ChangePassword.Text = "Сменить пароль?";
            this.ChangePassword.UseVisualStyleBackColor = true;
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // launch
            // 
            this.launch.Location = new System.Drawing.Point(483, 389);
            this.launch.Name = "launch";
            this.launch.Size = new System.Drawing.Size(258, 49);
            this.launch.TabIndex = 46;
            this.launch.Text = "Запуск!";
            this.launch.UseVisualStyleBackColor = true;
            this.launch.Click += new System.EventHandler(this.launch_Click);
            // 
            // calibrate
            // 
            this.calibrate.Location = new System.Drawing.Point(109, 130);
            this.calibrate.Name = "calibrate";
            this.calibrate.Size = new System.Drawing.Size(162, 99);
            this.calibrate.TabIndex = 47;
            this.calibrate.Text = "Калибровка (обязательно для первого раза)";
            this.calibrate.UseVisualStyleBackColor = true;
            this.calibrate.Click += new System.EventHandler(this.calibrate_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.Location = new System.Drawing.Point(369, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 432);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // profilePicture
            // 
            this.profilePicture.AccessibleDescription = "";
            this.profilePicture.Image = global::KeyboardAnalyser.Properties.Resources.Client;
            this.profilePicture.Location = new System.Drawing.Point(16, 32);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(50, 50);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 44;
            this.profilePicture.TabStop = false;
            this.profilePicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.profilePicture_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Текущие данные:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(12, 254);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(292, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Среднее количество ошибок (шт/сл):";
            // 
            // mistakesAmmo
            // 
            this.mistakesAmmo.AutoSize = true;
            this.mistakesAmmo.Location = new System.Drawing.Point(310, 296);
            this.mistakesAmmo.Name = "mistakesAmmo";
            this.mistakesAmmo.Size = new System.Drawing.Size(0, 20);
            this.mistakesAmmo.TabIndex = 53;
            // 
            // setNull
            // 
            this.setNull.Location = new System.Drawing.Point(52, 389);
            this.setNull.Name = "setNull";
            this.setNull.Size = new System.Drawing.Size(258, 49);
            this.setNull.TabIndex = 56;
            this.setNull.Text = "Сбросить";
            this.setNull.UseVisualStyleBackColor = true;
            this.setNull.Click += new System.EventHandler(this.setNull_Click);
            // 
            // layers
            // 
            this.layers.AutoSize = true;
            this.layers.Location = new System.Drawing.Point(290, 332);
            this.layers.Name = "layers";
            this.layers.Size = new System.Drawing.Size(0, 20);
            this.layers.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(280, 20);
            this.label11.TabIndex = 57;
            this.label11.Text = "Среднее кол-во наложений (шт/сл):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(483, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 20);
            this.label10.TabIndex = 59;
            this.label10.Text = "Аккуратность (%):";
            // 
            // accuracy
            // 
            this.accuracy.Location = new System.Drawing.Point(635, 296);
            this.accuracy.Name = "accuracy";
            this.accuracy.Size = new System.Drawing.Size(54, 26);
            this.accuracy.TabIndex = 60;
            this.accuracy.Leave += new System.EventHandler(this.accuracy_Leave);
            // 
            // freqLetter
            // 
            this.freqLetter.AutoSize = true;
            this.freqLetter.Location = new System.Drawing.Point(310, 364);
            this.freqLetter.Name = "freqLetter";
            this.freqLetter.Size = new System.Drawing.Size(0, 20);
            this.freqLetter.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 364);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(300, 20);
            this.label12.TabIndex = 61;
            this.label12.Text = "Частая буква (гистограммный метод):";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(72, 12);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(396, 331);
            this.inputBox.TabIndex = 63;
            this.inputBox.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.freqLetter);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.accuracy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.layers);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.setNull);
            this.Controls.Add(this.mistakesAmmo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.calibrate);
            this.Controls.Add(this.launch);
            this.Controls.Add(this.ChangePassword);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.CurrentSurname);
            this.Controls.Add(this.CurrentName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.hiddenTreasure);
            this.Controls.Add(this.autorunChB);
            this.Controls.Add(this.defenceMethod);
            this.Controls.Add(this.action);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyboardAnalyser";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.action.ResumeLayout(false);
            this.action.PerformLayout();
            this.defenceMethod.ResumeLayout(false);
            this.defenceMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton lagsAndLayers;
        private System.Windows.Forms.RadioButton gistogram;
        private System.Windows.Forms.RadioButton bothWays;
        private System.Windows.Forms.RadioButton warnUser;
        private System.Windows.Forms.RadioButton shutdownPC;
        private System.Windows.Forms.RadioButton lockPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel action;
        private System.Windows.Forms.Panel defenceMethod;
        private System.Windows.Forms.CheckBox autorunChB;
        private System.Windows.Forms.CheckBox hiddenTreasure;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CurrentName;
        private System.Windows.Forms.Label CurrentSurname;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Button ChangePassword;
        private System.Windows.Forms.Button launch;
        private System.Windows.Forms.Button calibrate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label mistakesAmmo;
        private System.Windows.Forms.Button setNull;
        private System.Windows.Forms.Label layers;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox accuracy;
        private System.Windows.Forms.Label freqLetter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox inputBox;
    }
}

