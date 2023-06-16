namespace QLDeTai
{
    partial class FormDMK
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
            components = new System.ComponentModel.Container();
            btldmk = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtconfirmpass = new TextBox();
            txtnewpass = new TextBox();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btldmk
            // 
            btldmk.Location = new Point(116, 203);
            btldmk.Name = "btldmk";
            btldmk.Size = new Size(111, 31);
            btldmk.TabIndex = 5;
            btldmk.Text = "Đổi mật khẩu";
            btldmk.UseVisualStyleBackColor = true;
            btldmk.Click += btldmk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 22);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 59);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 0;
            label2.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 98);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 0;
            label3.Text = "Newpassword :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 137);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 0;
            label4.Text = "Confirmpassword :";
            // 
            // txtconfirmpass
            // 
            txtconfirmpass.Location = new Point(146, 130);
            txtconfirmpass.Name = "txtconfirmpass";
            txtconfirmpass.PasswordChar = '*';
            txtconfirmpass.Size = new Size(174, 27);
            txtconfirmpass.TabIndex = 4;
            // 
            // txtnewpass
            // 
            txtnewpass.Location = new Point(146, 91);
            txtnewpass.Name = "txtnewpass";
            txtnewpass.PasswordChar = '*';
            txtnewpass.Size = new Size(174, 27);
            txtnewpass.TabIndex = 3;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(146, 56);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(174, 27);
            txtpassword.TabIndex = 2;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(146, 19);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(174, 27);
            txtusername.TabIndex = 1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btldmk);
            panel1.Controls.Add(txtconfirmpass);
            panel1.Controls.Add(txtnewpass);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtpassword);
            panel1.Controls.Add(txtusername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(284, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 255);
            panel1.TabIndex = 0;
            // 
            // FormDMK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormDMK";
            Text = "FormDMK";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btldmk;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtconfirmpass;
        private TextBox txtnewpass;
        private TextBox txtpassword;
        private TextBox txtusername;
        private ErrorProvider errorProvider1;
        private Panel panel1;
    }
}