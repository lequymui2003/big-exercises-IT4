namespace QLDeTai
{
    partial class FormMH
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
            dataformh = new DataGridView();
            groupBox1 = new GroupBox();
            txtgiatc = new TextBox();
            label3 = new Label();
            cbbtenMH = new ComboBox();
            txtmmh = new TextBox();
            label2 = new Label();
            txtsotinchi = new TextBox();
            label5 = new Label();
            label1 = new Label();
            btlthem = new Button();
            btlxoa = new Button();
            grbtimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataformh).BeginInit();
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
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(77, 36);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 0;
            label8.Text = "Tên môn học :";
            // 
            // dataformh
            // 
            dataformh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataformh.Location = new Point(12, 161);
            dataformh.Name = "dataformh";
            dataformh.RowHeadersWidth = 51;
            dataformh.RowTemplate.Height = 29;
            dataformh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataformh.Size = new Size(636, 370);
            dataformh.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtgiatc);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbbtenMH);
            groupBox1.Controls.Add(txtmmh);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtsotinchi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(654, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 370);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin môn học";
            // 
            // txtgiatc
            // 
            txtgiatc.Location = new Point(120, 146);
            txtgiatc.Name = "txtgiatc";
            txtgiatc.ReadOnly = true;
            txtgiatc.Size = new Size(188, 27);
            txtgiatc.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 153);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 9;
            label3.Text = "Giá tiền tín chỉ :";
            // 
            // cbbtenMH
            // 
            cbbtenMH.FormattingEnabled = true;
            cbbtenMH.Items.AddRange(new object[] { "Co so du lieu", "Lap trinh mang", "Thiet ke web\t", "Lap trinh .Net", "Lap trinh C" });
            cbbtenMH.Location = new Point(120, 24);
            cbbtenMH.Name = "cbbtenMH";
            cbbtenMH.Size = new Size(188, 28);
            cbbtenMH.TabIndex = 8;
            cbbtenMH.SelectedIndexChanged += cbbtenMH_SelectedIndexChanged;
            // 
            // txtmmh
            // 
            txtmmh.Location = new Point(120, 64);
            txtmmh.Name = "txtmmh";
            txtmmh.ReadOnly = true;
            txtmmh.Size = new Size(188, 27);
            txtmmh.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 67);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã MH :";
            // 
            // txtsotinchi
            // 
            txtsotinchi.Location = new Point(120, 102);
            txtsotinchi.Name = "txtsotinchi";
            txtsotinchi.ReadOnly = true;
            txtsotinchi.Size = new Size(188, 27);
            txtsotinchi.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 109);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 0;
            label5.Text = "Số tín chỉ :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên MH :";
            // 
            // btlthem
            // 
            btlthem.Location = new Point(686, 109);
            btlthem.Name = "btlthem";
            btlthem.Size = new Size(94, 29);
            btlthem.TabIndex = 5;
            btlthem.Text = "Thêm";
            btlthem.UseVisualStyleBackColor = true;
            btlthem.Click += btlthem_Click;
            // 
            // btlxoa
            // 
            btlxoa.Location = new Point(858, 109);
            btlxoa.Name = "btlxoa";
            btlxoa.Size = new Size(94, 29);
            btlxoa.TabIndex = 7;
            btlxoa.Text = "Xóa";
            btlxoa.UseVisualStyleBackColor = true;
            btlxoa.Click += btlxoa_Click;
            // 
            // FormMH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1064, 543);
            Controls.Add(btlxoa);
            Controls.Add(btlthem);
            Controls.Add(groupBox1);
            Controls.Add(dataformh);
            Controls.Add(grbtimkiem);
            Name = "FormMH";
            Text = "FormMH";
            Load += FormMH_Load;
            grbtimkiem.ResumeLayout(false);
            grbtimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataformh).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbtimkiem;
        private TextBox txttimkiem;
        private Label label8;
        private DataGridView dataformh;
        private GroupBox groupBox1;
        private TextBox txtmmh;
        private Label label2;
        private TextBox txtsotinchi;
        private Label label5;
        private Label label1;
        private Button btlthem;
        private ComboBox cbbtenMH;
        private Button btlxoa;
        private TextBox txtgiatc;
        private Label label3;
    }
}