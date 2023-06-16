namespace QLDeTai
{
    partial class Dangnhap
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
            btldangnhap = new Button();
            btlthoat = new Button();
            label1 = new Label();
            label2 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            linkquenmk = new LinkLabel();
            linkdangky = new LinkLabel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btldangnhap
            // 
            btldangnhap.BackColor = Color.Transparent;
            btldangnhap.Location = new Point(46, 386);
            btldangnhap.Name = "btldangnhap";
            btldangnhap.Size = new Size(94, 29);
            btldangnhap.TabIndex = 3;
            btldangnhap.Text = "Đăng nhập";
            btldangnhap.UseVisualStyleBackColor = false;
            btldangnhap.Click += btldangnhap_Click;
            // 
            // btlthoat
            // 
            btlthoat.Location = new Point(250, 386);
            btlthoat.Name = "btlthoat";
            btlthoat.Size = new Size(94, 29);
            btlthoat.TabIndex = 6;
            btlthoat.Text = "Thoát";
            btlthoat.UseVisualStyleBackColor = true;
            btlthoat.Click += btlthoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 225);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 268);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 0;
            label2.Text = "Password :";
            label2.Click += label2_Click;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(134, 218);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(210, 27);
            txtusername.TabIndex = 1;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(134, 261);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(210, 27);
            txtpassword.TabIndex = 2;
            // 
            // linkquenmk
            // 
            linkquenmk.AutoSize = true;
            linkquenmk.Location = new Point(46, 325);
            linkquenmk.Name = "linkquenmk";
            linkquenmk.Size = new Size(120, 20);
            linkquenmk.TabIndex = 5;
            linkquenmk.TabStop = true;
            linkquenmk.Text = "Quên mật khẩu ?";
            linkquenmk.LinkClicked += linkquenmk_LinkClicked;
            // 
            // linkdangky
            // 
            linkdangky.AutoSize = true;
            linkdangky.Location = new Point(281, 325);
            linkdangky.Name = "linkdangky";
            linkdangky.Size = new Size(63, 20);
            linkdangky.TabIndex = 4;
            linkdangky.TabStop = true;
            linkdangky.Text = "Đăng ký";
            linkdangky.LinkClicked += linkdangky_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(406, 9);
            label3.Name = "label3";
            label3.Size = new Size(136, 27);
            label3.TabIndex = 0;
            label3.Text = "Đăng Nhập";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = Properties.Resources._0af3c9613761d2d2394d99312aeba397;
            pictureBox1.Location = new Point(46, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btlthoat);
            panel1.Controls.Add(linkdangky);
            panel1.Controls.Add(btldangnhap);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(linkquenmk);
            panel1.Controls.Add(txtusername);
            panel1.Controls.Add(txtpassword);
            panel1.Location = new Point(286, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 478);
            panel1.TabIndex = 8;
            // 
            // Dangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(923, 565);
            Controls.Add(panel1);
            Controls.Add(label3);
            DoubleBuffered = true;
            ForeColor = Color.Black;
            Name = "Dangnhap";
            Text = "Dangnhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btldangnhap;
        private Button btlthoat;
        private Label label1;
        private Label label2;
        private TextBox txtusername;
        private TextBox txtpassword;
        private LinkLabel linkquenmk;
        private LinkLabel linkdangky;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}