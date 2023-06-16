namespace QLDeTai
{
    partial class FormBĐ
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
            dataformbd = new DataGridView();
            groupBox1 = new GroupBox();
            txtMĐT = new TextBox();
            label4 = new Label();
            txtnhanxet = new TextBox();
            txtdiemlan2 = new TextBox();
            label3 = new Label();
            txtmsv = new TextBox();
            label2 = new Label();
            txtdiemlan1 = new TextBox();
            label5 = new Label();
            label1 = new Label();
            btlthem = new Button();
            btlsua = new Button();
            btlxoa = new Button();
            grbtimkiem = new GroupBox();
            txttimkiem = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataformbd).BeginInit();
            groupBox1.SuspendLayout();
            grbtimkiem.SuspendLayout();
            SuspendLayout();
            // 
            // dataformbd
            // 
            dataformbd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataformbd.Location = new Point(22, 172);
            dataformbd.Name = "dataformbd";
            dataformbd.RowHeadersWidth = 51;
            dataformbd.RowTemplate.Height = 29;
            dataformbd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataformbd.Size = new Size(636, 380);
            dataformbd.TabIndex = 4;
            dataformbd.CellClick += dataformbd_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMĐT);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtnhanxet);
            groupBox1.Controls.Add(txtdiemlan2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtmsv);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtdiemlan1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(664, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 390);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin bảng điểm";
            // 
            // txtMĐT
            // 
            txtMĐT.Location = new Point(120, 25);
            txtMĐT.Name = "txtMĐT";
            txtMĐT.Size = new Size(188, 27);
            txtMĐT.TabIndex = 16;
            txtMĐT.KeyPress += txtMĐT_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 197);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 15;
            label4.Text = "Nhận xét :";
            // 
            // txtnhanxet
            // 
            txtnhanxet.Location = new Point(120, 190);
            txtnhanxet.Name = "txtnhanxet";
            txtnhanxet.Size = new Size(188, 27);
            txtnhanxet.TabIndex = 14;
            // 
            // txtdiemlan2
            // 
            txtdiemlan2.Location = new Point(120, 147);
            txtdiemlan2.Name = "txtdiemlan2";
            txtdiemlan2.Size = new Size(188, 27);
            txtdiemlan2.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 154);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 12;
            label3.Text = "Điểm lần 2 :";
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
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 0;
            label2.Text = "MSV :";
            // 
            // txtdiemlan1
            // 
            txtdiemlan1.Location = new Point(120, 104);
            txtdiemlan1.Name = "txtdiemlan1";
            txtdiemlan1.Size = new Size(188, 27);
            txtdiemlan1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 111);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 0;
            label5.Text = "Điểm lần 1 :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 0;
            label1.Text = "MĐT :";
            // 
            // btlthem
            // 
            btlthem.Location = new Point(664, 100);
            btlthem.Name = "btlthem";
            btlthem.Size = new Size(94, 29);
            btlthem.TabIndex = 9;
            btlthem.Text = "Thêm";
            btlthem.UseVisualStyleBackColor = true;
            btlthem.Click += btlthem_Click;
            // 
            // btlsua
            // 
            btlsua.Location = new Point(797, 100);
            btlsua.Name = "btlsua";
            btlsua.Size = new Size(94, 29);
            btlsua.TabIndex = 10;
            btlsua.Text = "Sửa";
            btlsua.UseVisualStyleBackColor = true;
            btlsua.Click += btlsua_Click;
            // 
            // btlxoa
            // 
            btlxoa.Location = new Point(924, 100);
            btlxoa.Name = "btlxoa";
            btlxoa.Size = new Size(94, 29);
            btlxoa.TabIndex = 11;
            btlxoa.Text = "Xóa";
            btlxoa.UseVisualStyleBackColor = true;
            btlxoa.Click += btlxoa_Click;
            // 
            // grbtimkiem
            // 
            grbtimkiem.Controls.Add(txttimkiem);
            grbtimkiem.Controls.Add(label8);
            grbtimkiem.Location = new Point(22, 74);
            grbtimkiem.Name = "grbtimkiem";
            grbtimkiem.Size = new Size(636, 78);
            grbtimkiem.TabIndex = 12;
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
            label8.Size = new Size(79, 20);
            label8.TabIndex = 0;
            label8.Text = "Mã đề tài :";
            // 
            // FormBĐ
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 564);
            Controls.Add(grbtimkiem);
            Controls.Add(btlxoa);
            Controls.Add(btlsua);
            Controls.Add(btlthem);
            Controls.Add(groupBox1);
            Controls.Add(dataformbd);
            Name = "FormBĐ";
            Text = "FormBĐ";
            Load += FormBĐ_Load;
            ((System.ComponentModel.ISupportInitialize)dataformbd).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grbtimkiem.ResumeLayout(false);
            grbtimkiem.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataformbd;
        private GroupBox groupBox1;
        private TextBox txtmsv;
        private Label label2;
        private TextBox txtdiemlan1;
        private Label label5;
        private Label label1;
        private Button btlthem;
        private Button btlsua;
        private Button btlxoa;
        private TextBox txtMĐT;
        private Label label4;
        private TextBox txtnhanxet;
        private TextBox txtdiemlan2;
        private Label label3;
        private GroupBox grbtimkiem;
        private TextBox txttimkiem;
        private Label label8;
    }
}