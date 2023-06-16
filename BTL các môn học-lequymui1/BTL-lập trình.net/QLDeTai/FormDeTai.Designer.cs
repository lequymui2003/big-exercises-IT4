namespace QLDeTai
{
    partial class FormDeTai
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
            dataformdt = new DataGridView();
            groupBox1 = new GroupBox();
            cbbtenDeTai = new ComboBox();
            txtmdt = new TextBox();
            label2 = new Label();
            txtgioihan = new TextBox();
            label5 = new Label();
            label1 = new Label();
            btlthem = new Button();
            btlsua = new Button();
            btlxoa = new Button();
            grbtimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataformdt).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grbtimkiem
            // 
            grbtimkiem.Controls.Add(txttimkiem);
            grbtimkiem.Controls.Add(label8);
            grbtimkiem.Location = new Point(12, 77);
            grbtimkiem.Name = "grbtimkiem";
            grbtimkiem.Size = new Size(636, 78);
            grbtimkiem.TabIndex = 2;
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
            label8.Size = new Size(81, 20);
            label8.TabIndex = 0;
            label8.Text = "Tên đề tài :";
            // 
            // dataformdt
            // 
            dataformdt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataformdt.Location = new Point(12, 166);
            dataformdt.Name = "dataformdt";
            dataformdt.RowHeadersWidth = 51;
            dataformdt.RowTemplate.Height = 29;
            dataformdt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataformdt.Size = new Size(636, 380);
            dataformdt.TabIndex = 3;
            dataformdt.CellClick += dataformdt_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbbtenDeTai);
            groupBox1.Controls.Add(txtmdt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtgioihan);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(667, 166);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 380);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đề tài";
            // 
            // cbbtenDeTai
            // 
            cbbtenDeTai.FormattingEnabled = true;
            cbbtenDeTai.Items.AddRange(new object[] { "xay dung co so du lieu quan ly ban hang", "xay dung co so du lieu quan ly sinh vien", "xay dung ung dung quan ly ben xe", "xay dung ung dung quan ly ban ve may bay", "xay dung ung dung chat nhom Tcp Socket console", "xay dung ung dung chat giữa hai máy UDP Windows Form" });
            cbbtenDeTai.Location = new Point(120, 24);
            cbbtenDeTai.Name = "cbbtenDeTai";
            cbbtenDeTai.Size = new Size(188, 28);
            cbbtenDeTai.TabIndex = 11;
            cbbtenDeTai.SelectedIndexChanged += cbbtenDeTai_SelectedIndexChanged;
            // 
            // txtmdt
            // 
            txtmdt.Location = new Point(120, 64);
            txtmdt.Name = "txtmdt";
            txtmdt.ReadOnly = true;
            txtmdt.Size = new Size(188, 27);
            txtmdt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 0;
            label2.Text = "MĐT :";
            // 
            // txtgioihan
            // 
            txtgioihan.Location = new Point(120, 104);
            txtgioihan.Name = "txtgioihan";
            txtgioihan.Size = new Size(188, 27);
            txtgioihan.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 111);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 0;
            label5.Text = "Giới hạn :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Đề Tài :";
            // 
            // btlthem
            // 
            btlthem.Location = new Point(687, 106);
            btlthem.Name = "btlthem";
            btlthem.Size = new Size(94, 29);
            btlthem.TabIndex = 8;
            btlthem.Text = "Thêm";
            btlthem.UseVisualStyleBackColor = true;
            btlthem.Click += btlthem_Click;
            // 
            // btlsua
            // 
            btlsua.Location = new Point(831, 106);
            btlsua.Name = "btlsua";
            btlsua.Size = new Size(94, 29);
            btlsua.TabIndex = 9;
            btlsua.Text = "Sửa";
            btlsua.UseVisualStyleBackColor = true;
            btlsua.Click += btlsua_Click;
            // 
            // btlxoa
            // 
            btlxoa.Location = new Point(960, 109);
            btlxoa.Name = "btlxoa";
            btlxoa.Size = new Size(94, 29);
            btlxoa.TabIndex = 10;
            btlxoa.Text = "Xóa";
            btlxoa.UseVisualStyleBackColor = true;
            btlxoa.Click += btlxoa_Click;
            // 
            // FormDeTai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1080, 558);
            Controls.Add(btlxoa);
            Controls.Add(btlsua);
            Controls.Add(btlthem);
            Controls.Add(groupBox1);
            Controls.Add(dataformdt);
            Controls.Add(grbtimkiem);
            Name = "FormDeTai";
            Text = "FormDeTai";
            Load += FormDeTai_Load;
            grbtimkiem.ResumeLayout(false);
            grbtimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataformdt).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbtimkiem;
        private TextBox txttimkiem;
        private Label label8;
        private DataGridView dataformdt;
        private GroupBox groupBox1;
        private TextBox txtmdt;
        private Label label2;
        private TextBox txtgioihan;
        private Label label5;
        private Label label1;
        private Button btlthem;
        private Button btlsua;
        private Button btlxoa;
        private ComboBox cbbtenDeTai;
    }
}