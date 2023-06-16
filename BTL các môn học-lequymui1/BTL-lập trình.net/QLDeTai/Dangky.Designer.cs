namespace QLDeTai
{
    partial class Dangky
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
            btldangky = new Button();
            btlthoat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            txtcfpassword = new TextBox();
            txtemail = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btldangky
            // 
            btldangky.Location = new Point(44, 435);
            btldangky.Name = "btldangky";
            btldangky.Size = new Size(94, 29);
            btldangky.TabIndex = 0;
            btldangky.Text = "Đăng ký";
            btldangky.UseVisualStyleBackColor = true;
            btldangky.Click += btldangky_Click;
            // 
            // btlthoat
            // 
            btlthoat.Location = new Point(251, 435);
            btlthoat.Name = "btlthoat";
            btlthoat.Size = new Size(94, 29);
            btlthoat.TabIndex = 1;
            btlthoat.Text = "Thoát";
            btlthoat.UseVisualStyleBackColor = true;
            btlthoat.Click += btlthoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 238);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 2;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 278);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 3;
            label2.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 357);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 4;
            label3.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 319);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 5;
            label4.Text = "Confirmpassword :";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(181, 238);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(164, 27);
            txtusername.TabIndex = 6;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(181, 275);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(164, 27);
            txtpassword.TabIndex = 7;
            // 
            // txtcfpassword
            // 
            txtcfpassword.Location = new Point(181, 312);
            txtcfpassword.Name = "txtcfpassword";
            txtcfpassword.PasswordChar = '*';
            txtcfpassword.Size = new Size(164, 27);
            txtcfpassword.TabIndex = 8;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(181, 350);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(164, 27);
            txtemail.TabIndex = 9;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(361, 9);
            label5.Name = "label5";
            label5.Size = new Size(213, 27);
            label5.TabIndex = 10;
            label5.Text = "Đăng ký tài khoản";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._0af3c9613761d2d2394d99312aeba397;
            pictureBox1.Location = new Point(44, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btlthoat);
            panel1.Controls.Add(txtemail);
            panel1.Controls.Add(btldangky);
            panel1.Controls.Add(txtusername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtcfpassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtpassword);
            panel1.Location = new Point(264, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 498);
            panel1.TabIndex = 12;
            // 
            // Dangky
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(929, 590);
            Controls.Add(panel1);
            Controls.Add(label5);
            Name = "Dangky";
            Text = "Dangky";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btldangky;
        private Button btlthoat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtusername;
        private TextBox txtpassword;
        private TextBox txtcfpassword;
        private TextBox txtemail;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}