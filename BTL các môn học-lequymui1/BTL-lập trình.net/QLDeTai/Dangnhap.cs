using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLDeTai
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void btldangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AnhHatDe;Initial Catalog=DeTaiThucTap;Integrated Security=True");
            try
            {
                con.Open();
                string Username = txtusername.Text;
                string Password = txtpassword.Text;
                string sql = "select * from NguoiDung where Username ='" + Username + "' and Password = '" + Password + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    Trangchu trangchu = new Trangchu(Username);
                    trangchu.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }



        private void btlthoat_Click(object sender, EventArgs e)
        {
            DialogResult drg = MessageBox.Show("Bạn chắc chắn muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo);
            if (drg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkdangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dangky dangky = new Dangky();
            dangky.Show();
        }

        private void linkquenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMK quenMK = new QuenMK();
            quenMK.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
