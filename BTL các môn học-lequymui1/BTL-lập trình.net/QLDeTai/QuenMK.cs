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
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
            label2.Text = "";
        }
        modify Modify = new modify();
        private void QuenMK_Load(object sender, EventArgs e)
        {

        }

        private void btllaylaimk_Click(object sender, EventArgs e)
        {
            string email = txtemailquenmk.Text;
            if (email.Trim() == "") { MessageBox.Show("Vui lòng nhập email đăng kí !"); }
            else
            {
                string query = "Select * from NguoiDung where Email ='" + email + "'";
                if (Modify.Taikhoans(query).Count != 0)
                {
                    label2.ForeColor = Color.Blue;
                    label2.Text = "Mật Khẩu :" + Modify.Taikhoans(query)[0].Matkhau;
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Email này chưa được đăng ký!";
                }
            }
        }
    }
}
