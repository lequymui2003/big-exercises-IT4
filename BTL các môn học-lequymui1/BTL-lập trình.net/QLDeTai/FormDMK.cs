using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace QLDeTai
{
    public partial class FormDMK : Form
    {
        public FormDMK()
        {
            InitializeComponent();
        }


        SqlConnection cn = new SqlConnection(@"Data Source=AnhHatDe;Initial Catalog=DeTaiThucTap;Integrated Security=True");
        private void btldmk_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select count (*) from NguoiDung where Username = N'" + txtusername.Text + "' and Password = N'" + txtpassword.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            errorProvider1.Clear();//xuất hiện x và hiện thông báo khi thao tác sai
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (txtnewpass.Text == txtconfirmpass.Text)
                {
                    if (txtnewpass.Text.Length > 6)
                    {
                        SqlDataAdapter da1 = new SqlDataAdapter("Update NguoiDung set Password = N'" + txtnewpass.Text + "' where Username = N'" + txtusername.Text + "' and Password = N'" + txtpassword.Text + "'", cn);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);//Hai bước vừa rồi là khi đổi mật khẩu reset lại sql sẽ hiện ra
                        MessageBox.Show("Đổi mật khẩu thành công !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    }
                    else
                    {
                        errorProvider1.SetError(txtnewpass, "Độ dài mật khẩu không đủ !");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtnewpass, "Bạn chưa điền mật khẩu !");
                    errorProvider1.SetError(txtconfirmpass, "Mật khẩu nhập lại chưa đúng !");
                }
            }
            else
            {
                errorProvider1.SetError(txtusername, "Tên người dùng không đúng !");
                errorProvider1.SetError(txtpassword, "Mật khẩu cũ không đúng !");
            }
        }
    }
}
