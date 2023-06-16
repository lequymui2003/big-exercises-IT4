namespace QLDeTai
{
    partial class FormGV
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
            dataformgv = new DataGridView();
            groupBox1 = new GroupBox();
            txtmgv = new TextBox();
            label2 = new Label();
            txtsex = new TextBox();
            label7 = new Label();
            txtmamh = new TextBox();
            txtphonenumber = new TextBox();
            txtname = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            btlthem = new Button();
            btlsua = new Button();
            btlxoa = new Button();
            grbtimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataformgv).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grbtimkiem
            // 
            grbtimkiem.Controls.Add(txttimkiem);
            grbtimkiem.Controls.Add(label8);
            grbtimkiem.Location = new Point(12, 86);
            grbtimkiem.Name = "grbtimkiem";
            grbtimkiem.Size = new Size(636, 78);
            grbtimkiem.TabIndex = 1;
            grbtimkiem.TabStop = false;
            grbtimkiem.Text = "Tìm kiếm";
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(195, 29);
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
            label8.Size = new Size(110, 20);
            label8.TabIndex = 0;
            label8.Text = "Mã giảng viên :";
            // 
            // dataformgv
            // 
            dataformgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataformgv.Location = new Point(12, 170);
            dataformgv.Name = "dataformgv";
            dataformgv.RowHeadersWidth = 51;
            dataformgv.RowTemplate.Height = 29;
            dataformgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataformgv.Size = new Size(636, 380);
            dataformgv.TabIndex = 2;
            dataformgv.CellClick += dataformgv_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtmgv);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtsex);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtmamh);
            groupBox1.Controls.Add(txtphonenumber);
            groupBox1.Controls.Add(txtname);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(664, 170);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 380);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin giảng viên";
            // 
            // txtmgv
            // 
            txtmgv.Location = new Point(120, 64);
            txtmgv.Name = "txtmgv";
            txtmgv.Size = new Size(188, 27);
            txtmgv.TabIndex = 2;
            txtmgv.TextChanged += txtmgv_TextChanged;
            txtmgv.KeyPress += txtmgv_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 67);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 0;
            label2.Text = "MGV :";
            // 
            // txtsex
            // 
            txtsex.Location = new Point(120, 99);
            txtsex.Name = "txtsex";
            txtsex.Size = new Size(188, 27);
            txtsex.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 106);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 0;
            label7.Text = "Sex :";
            // 
            // txtmamh
            // 
            txtmamh.Location = new Point(120, 185);
            txtmamh.Name = "txtmamh";
            txtmamh.Size = new Size(188, 27);
            txtmamh.TabIndex = 7;
            // 
            // txtphonenumber
            // 
            txtphonenumber.Location = new Point(120, 143);
            txtphonenumber.Name = "txtphonenumber";
            txtphonenumber.Size = new Size(188, 27);
            txtphonenumber.TabIndex = 5;
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
            label6.Location = new Point(6, 150);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 0;
            label6.Text = "Phonenumber :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 192);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 0;
            label5.Text = "Mã MH :";
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
            btlthem.Location = new Point(696, 115);
            btlthem.Name = "btlthem";
            btlthem.Size = new Size(94, 29);
            btlthem.TabIndex = 4;
            btlthem.Text = "Thêm";
            btlthem.UseVisualStyleBackColor = true;
            btlthem.Click += btlthem_Click_1;
            // 
            // btlsua
            // 
            btlsua.Location = new Point(835, 114);
            btlsua.Name = "btlsua";
            btlsua.Size = new Size(94, 29);
            btlsua.TabIndex = 5;
            btlsua.Text = "Sửa";
            btlsua.UseVisualStyleBackColor = true;
            btlsua.Click += btlsua_Click;
            // 
            // btlxoa
            // 
            btlxoa.Location = new Point(971, 113);
            btlxoa.Name = "btlxoa";
            btlxoa.Size = new Size(94, 29);
            btlxoa.TabIndex = 6;
            btlxoa.Text = "Xóa";
            btlxoa.UseVisualStyleBackColor = true;
            btlxoa.Click += btlxoa_Click;
            // 
            // FormGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1095, 557);
            Controls.Add(btlxoa);
            Controls.Add(btlsua);
            Controls.Add(btlthem);
            Controls.Add(groupBox1);
            Controls.Add(dataformgv);
            Controls.Add(grbtimkiem);
            Name = "FormGV";
            Text = "FormGV";
            Load += FormGV_Load;
            grbtimkiem.ResumeLayout(false);
            grbtimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataformgv).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbtimkiem;
        private TextBox txttimkiem;
        private Label label8;
        private DataGridView dataformgv;
        private GroupBox groupBox1;
        private TextBox txtmgv;
        private Label label2;
        private TextBox txtsex;
        private Label label7;
        private TextBox txtmamh;
        private TextBox txtphonenumber;
        private TextBox txtname;
        private Label label6;
        private Label label5;
        private Label label1;
        private Button btlthem;
        private Button btlsua;
        private Button btlxoa;
    }
}