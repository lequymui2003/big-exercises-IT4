using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDeTai
{
    public partial class Trangchu : Form
    {
        public Trangchu(string Username)
        {
            InitializeComponent();
            label1.Text = Username;
        }
        private Form currenFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currenFormChild != null)
            {
                currenFormChild.Close();
            }
            currenFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btlinformation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Information());
            label2.Text = btlinformation.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currenFormChild != null)
            {
                currenFormChild.Close();
            }
            label2.Text = "Home";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormDMK());
            label2.Text = linkLabel1.Text;
        }

        private void btlnguoidung_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Nguoidung());
            label2.Text = btlnguoidung.Text;
        }

        private void btlsinhvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSV());
            label2.Text = btlsinhvien.Text;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new Dangky());
            label2.Text = linkLabel2.Text;
        }

        private void btlgiangvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormGV());
            label2.Text = btlgiangvien.Text;
        }

        private void btlMonhoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMH());
            label2.Text = btlMonhoc.Text;
        }

        private void btldetai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDeTai());
            label2.Text = btldetai.Text;
        }

        private void btlbangdiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBĐ());
            label2.Text = btlbangdiem.Text;
        }

        
    }
}
