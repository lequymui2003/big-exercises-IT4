namespace QLDeTai
{
    partial class Nguoidung
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
            groupBox1 = new GroupBox();
            txtconfirmpassword = new TextBox();
            label4 = new Label();
            txtemail = new TextBox();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btlsua = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtconfirmpassword);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(txtpassword);
            groupBox1.Controls.Add(txtusername);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 191);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin người dùng";
            // 
            // txtconfirmpassword
            // 
            txtconfirmpassword.Location = new Point(150, 110);
            txtconfirmpassword.Name = "txtconfirmpassword";
            txtconfirmpassword.Size = new Size(323, 27);
            txtconfirmpassword.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 117);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 0;
            label4.Text = "Confirmpassword :";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(150, 147);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(323, 27);
            txtemail.TabIndex = 4;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(150, 68);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(323, 27);
            txtpassword.TabIndex = 2;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(150, 32);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(323, 27);
            txtusername.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 154);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 0;
            label3.Text = "Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 75);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 0;
            label2.Text = "Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 39);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 235);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(729, 334);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btlsua
            // 
            btlsua.Location = new Point(533, 44);
            btlsua.Name = "btlsua";
            btlsua.Size = new Size(96, 40);
            btlsua.TabIndex = 2;
            btlsua.Text = "Sửa";
            btlsua.UseVisualStyleBackColor = true;
            btlsua.Click += btlsua_Click;
            // 
            // Nguoidung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1033, 623);
            Controls.Add(btlsua);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Nguoidung";
            Text = "Nguoidung";
            Load += Nguoidung_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtemail;
        private TextBox txtpassword;
        private TextBox txtusername;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btlsua;
        private TextBox txtconfirmpassword;
        private Label label4;
    }
}