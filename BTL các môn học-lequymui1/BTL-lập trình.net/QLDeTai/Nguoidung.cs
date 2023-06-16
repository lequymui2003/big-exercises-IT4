using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLDeTai
{
    public partial class Nguoidung : Form
    {
        public Nguoidung()
        {
            InitializeComponent();
        }
        modify modify = new modify();
        Nguoidung1cs Nguoidungcs;

        private void Nguoidung_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = modify.Table("Select * from NguoiDung");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex.Message);
            }
            Delete();
        }

        private void Delete()
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            txtconfirmpassword.Text = "";
            txtemail.Text = "";
        }
        private bool CheckTextBoxes()
        {
            if (txtusername.Text == "") { MessageBox.Show("Mời bạn nhập tên người dùng"); return false; }
            if (txtpassword.Text == "") { MessageBox.Show("Mời bạn nhập mật khẩu người dùng"); return false; }
            if (txtconfirmpassword.Text == "") { MessageBox.Show("Mời bạn nhập lại mật khẩu"); return false; }
            if (txtemail.Text == "") { MessageBox.Show("Mời bạn nhập email người dùng"); return false; }
            return true;
        }
        private void GetValuesTextBoxes()
        {
            string _Username = txtusername.Text;
            string _Password = txtpassword.Text;
            string _Confirmpassword = txtconfirmpassword.Text;
            string _Email = txtemail.Text;
            Nguoidungcs = new Nguoidung1cs(_Username, _Password, _Confirmpassword, _Email);
        }

        private void btlsua_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query = "UPDATE NguoiDung SET Username = N'" + Nguoidungcs.Username + "', Password =N'" + Nguoidungcs.Password + "', Confirmpassword=N'" + Nguoidungcs.Confirmpassword + "', Email =N'" + Nguoidungcs.Email + "'";
                query += "WHERE Username ='" + Nguoidungcs.Username + "'";
                try
                {
                    if (MessageBox.Show("bạn có muốn sửa  không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Sửa Người Dùng thành công!");
                        Nguoidung_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa :" + ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                txtusername.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtpassword.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtconfirmpassword.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtemail.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            }
        }
    }
}
