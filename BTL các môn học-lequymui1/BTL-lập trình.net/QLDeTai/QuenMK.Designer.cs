namespace QLDeTai
{
    partial class QuenMK
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
            label1 = new Label();
            label2 = new Label();
            txtemailquenmk = new TextBox();
            btllaylaimk = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 259);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 313);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu là :";
            // 
            // txtemailquenmk
            // 
            txtemailquenmk.Location = new Point(78, 252);
            txtemailquenmk.Name = "txtemailquenmk";
            txtemailquenmk.Size = new Size(222, 27);
            txtemailquenmk.TabIndex = 2;
            // 
            // btllaylaimk
            // 
            btllaylaimk.Location = new Point(100, 379);
            btllaylaimk.Name = "btllaylaimk";
            btllaylaimk.Size = new Size(137, 29);
            btllaylaimk.TabIndex = 4;
            btllaylaimk.Text = "Lấy lại mật khẩu";
            btllaylaimk.UseVisualStyleBackColor = true;
            btllaylaimk.Click += btllaylaimk_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btllaylaimk);
            panel1.Controls.Add(txtemailquenmk);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(300, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 439);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._0af3c9613761d2d2394d99312aeba397;
            pictureBox1.Location = new Point(19, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(367, 9);
            label3.Name = "label3";
            label3.Size = new Size(185, 27);
            label3.TabIndex = 6;
            label3.Text = "Quên Mật Khẩu";
            // 
            // QuenMK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(927, 543);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "QuenMK";
            Text = "QuenMK";
            Load += QuenMK_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtemailquenmk;
        private Button btllaylaimk;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}