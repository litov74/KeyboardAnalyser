namespace KeyboardAnalyser
{
    partial class ChangePW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePW));
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordTBNew = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.passwordTBNew2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.panel1.Controls.Add(this.passwordTB);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.passwordTBNew);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.createBtn);
            this.panel1.Controls.Add(this.passwordTBNew2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 416);
            this.panel1.TabIndex = 2;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(88, 110);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(207, 26);
            this.passwordTB.TabIndex = 11;
            this.passwordTB.Enter += new System.EventHandler(this.passwordTB_Enter);
            this.passwordTB.Leave += new System.EventHandler(this.passwordTB_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KeyboardAnalyser.Properties.Resources._lock;
            this.pictureBox1.Location = new System.Drawing.Point(56, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // passwordTBNew
            // 
            this.passwordTBNew.Location = new System.Drawing.Point(88, 170);
            this.passwordTBNew.Name = "passwordTBNew";
            this.passwordTBNew.Size = new System.Drawing.Size(207, 26);
            this.passwordTBNew.TabIndex = 9;
            this.passwordTBNew.Enter += new System.EventHandler(this.passwordTBNew_Enter);
            this.passwordTBNew.Leave += new System.EventHandler(this.passwordTBNew_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KeyboardAnalyser.Properties.Resources._lock;
            this.pictureBox3.Location = new System.Drawing.Point(56, 170);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите старый пароль, затем новый";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(84, 284);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(207, 36);
            this.createBtn.TabIndex = 5;
            this.createBtn.Text = "Обновить!";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // passwordTBNew2
            // 
            this.passwordTBNew2.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTBNew2.Location = new System.Drawing.Point(88, 212);
            this.passwordTBNew2.Name = "passwordTBNew2";
            this.passwordTBNew2.Size = new System.Drawing.Size(207, 26);
            this.passwordTBNew2.TabIndex = 4;
            this.passwordTBNew2.Enter += new System.EventHandler(this.passwordTBNew2_Enter);
            this.passwordTBNew2.Leave += new System.EventHandler(this.passwordTBNew2_Leave);

            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KeyboardAnalyser.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(56, 212);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // ChangePW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 416);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePW";
            this.Text = "Смена пароля";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordTBNew;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox passwordTBNew2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}