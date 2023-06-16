namespace QLDeTai
{
    partial class FormSV
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
            grbtimkiem = new GroupBox();
            txttimkiem = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            txtmsv = new TextBox();
            label2 = new Label();
            txtsex = new TextBox();
            label7 = new Label();
            txtclass = new TextBox();
            txtphonenumber = new TextBox();
            txtaddress = new TextBox();
            txtdate = new TextBox();
            txtname = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btlthem = new Button();
            btlsua = new Button();
            btlxoa = new Button();
            dataformsv = new DataGridView();
            grbtimkiem.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataformsv).BeginInit();
            SuspendLayout();
            // 
            // grbtimkiem
            // 
            grbtimkiem.Controls.Add(txttimkiem);
            grbtimkiem.Controls.Add(label8);
            grbtimkiem.Location = new Point(12, 74);
            grbtimkiem.Name = "grbtimkiem";
            grbtimkiem.Size = new Size(982, 78);
            grbtimkiem.TabIndex = 0;
            grbtimkiem.TabStop = false;
            grbtimkiem.Text = "Tìm kiếm";
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(157, 29);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(208, 27);
            txttimkiem.TabIndex = 1;
            txttimkiem.TextChanged += txttimkiem_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(77, 36);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 0;
            label8.Text = "Tên Lớp :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtmsv);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtsex);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtclass);
            groupBox1.Controls.Add(txtphonenumber);
            groupBox1.Controls.Add(txtaddress);
            groupBox1.Controls.Add(txtdate);
            groupBox1.Controls.Add(txtname);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1014, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 380);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // txtmsv
            // 
            txtmsv.Location = new Point(120, 64);
            txtmsv.Name = "txtmsv";
            txtmsv.Size = new Size(188, 27);
            txtmsv.TabIndex = 2;
            txtmsv.KeyPress += txtmsv_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 67);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 0;
            label2.Text = "MSV :";
            // 
            // txtsex
            // 
            txtsex.Location = new Point(120, 143);
            txtsex.Name = "txtsex";
            txtsex.Size = new Size(188, 27);
            txtsex.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 150);
            label7.Name = "label7";
            label7.Size = new Size(32, 20);
            label7.TabIndex = 0;
            label7.Text = "Sex";
            // 
            // txtclass
            // 
            txtclass.Location = new Point(120, 263);
            txtclass.Name = "txtclass";
            txtclass.Size = new Size(188, 27);
            txtclass.TabIndex = 7;
            // 
            // txtphonenumber
            // 
            txtphonenumber.Location = new Point(120, 186);
            txtphonenumber.Name = "txtphonenumber";
            txtphonenumber.Size = new Size(188, 27);
            txtphonenumber.TabIndex = 5;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(120, 225);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(188, 27);
            txtaddress.TabIndex = 6;
            // 
            // txtdate
            // 
            txtdate.Location = new Point(120, 105);
            txtdate.Name = "txtdate";
            txtdate.Size = new Size(188, 27);
            txtdate.TabIndex = 3;
            // 
            // txtname
            // 
            txtname.Location = new Point(120, 29);
            txtname.Name = "txtname";
            txtname.Size = new Size(188, 27);
            txtname.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 193);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 0;
            label6.Text = "Phonenumber :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 270);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 0;
            label5.Text = "Class :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 232);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 0;
            label4.Text = "Address :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 112);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 0;
            label3.Text = "Date :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // btlthem
            // 
            btlthem.Location = new Point(1034, 101);
            btlthem.Name = "btlthem";
            btlthem.Size = new Size(94, 29);
            btlthem.TabIndex = 2;
            btlthem.Text = "Thêm";
            btlthem.UseVisualStyleBackColor = true;
            btlthem.Click += btlthem_Click;
            // 
            // btlsua
            // 
            btlsua.Location = new Point(1180, 101);
            btlsua.Name = "btlsua";
            btlsua.Size = new Size(94, 29);
            btlsua.TabIndex = 3;
            btlsua.Text = "Sửa";
            btlsua.UseVisualStyleBackColor = true;
            btlsua.Click += btlsua_Click;
            // 
            // btlxoa
            // 
            btlxoa.Location = new Point(1321, 101);
            btlxoa.Name = "btlxoa";
            btlxoa.Size = new Size(94, 29);
            btlxoa.TabIndex = 4;
            btlxoa.Text = "Xóa";
            btlxoa.UseVisualStyleBackColor = true;
            btlxoa.Click += btlxoa_Click;
            // 
            // dataformsv
            // 
            dataformsv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataformsv.Location = new Point(12, 172);
            dataformsv.Name = "dataformsv";
            dataformsv.RowHeadersWidth = 51;
            dataformsv.RowTemplate.Height = 29;
            dataformsv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataformsv.Size = new Size(982, 380);
            dataformsv.TabIndex = 0;
            dataformsv.CellClick += dataGridView1_CellClick;
            // 
            // FormSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1427, 588);
            Controls.Add(dataformsv);
            Controls.Add(groupBox1);
            Controls.Add(btlxoa);
            Controls.Add(btlsua);
            Controls.Add(btlthem);
            Controls.Add(grbtimkiem);
            Name = "FormSV";
            Text = "FormSV";
            Load += FormSV_Load;
            grbtimkiem.ResumeLayout(false);
            grbtimkiem.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataformsv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbtimkiem;
        private GroupBox groupBox1;
        private TextBox txtmsv;
        private Label label2;
        private Button btlthem;
        private Button btlsua;
        private Button btlxoa;
        private TextBox txtsex;
        private Label label7;
        private TextBox txtclass;
        private TextBox txtphonenumber;
        private TextBox txtaddress;
        private TextBox txtdate;
        private TextBox txtname;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private DataGridView dataformsv;
        private TextBox txttimkiem;
        private Label label8;
    }
}