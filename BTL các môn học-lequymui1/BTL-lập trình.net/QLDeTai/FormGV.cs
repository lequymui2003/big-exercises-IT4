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

namespace QLDeTai
{
    public partial class FormGV : Form
    {
        public FormGV()
        {
            InitializeComponent();
        }
        modify modify = new modify();
        GiangVien giangvien;
        private void FormGV_Load(object sender, EventArgs e)
        {
            try
            {
                dataformgv.DataSource = modify.Table("Select * from giangvien");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex.Message);
            }
            Delete();
        }
        private void Delete()
        {
            txtname.Text = "";
            txtmgv.Text = "";
            txtsex.Text = "";
            txtphonenumber.Text = "";
            txtmamh.Text = "";
        }
        private bool CheckTextBoxes()
        {
            if (txtname.Text == "") { MessageBox.Show("Mời bạn nhập tên giãng viên"); return false; }
            if (txtmgv.Text == "") { MessageBox.Show("Mời bạn nhập mã giảng viên"); return false; }
            if (txtsex.Text == "") { MessageBox.Show("Mời bạn nhập giới tính"); return false; }
            if (txtphonenumber.Text == "") { MessageBox.Show("Mời bạn nhập số điện thoại"); return false; }
            if (txtmamh.Text == "") { MessageBox.Show("Mời bạn nhập mã môn học"); return false; }
            return true;
        }
        private void GetValuesTextBoxes()
        {
            string _Magv = txtmgv.Text;
            string _Name = txtname.Text;
            string _Sex = txtsex.Text;
            string _Mamh = txtmamh.Text;
            int _Phonenumber = int.Parse(txtphonenumber.Text);
            giangvien = new GiangVien(_Name, _Magv, _Phonenumber, _Mamh, _Sex);
        }



        private void btlsua_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query = "UPDATE giangvien SET hoten = N'" + giangvien.Hoten + "', gioitinh ='" + giangvien.Sex + "', maGV ='" + giangvien.Magv + "', sdt ='" + giangvien.Sdt + "', maMH ='" + giangvien.Mamh + "'";
                query += "WHERE hoten ='" + giangvien.Hoten + "'";
                try
                {
                    if (MessageBox.Show("bạn có muốn sửa  không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Sửa giảng viên thành công!");
                        FormGV_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa :" + ex.Message);
                }
            }
        }

        private void btlxoa_Click(object sender, EventArgs e)
        {
            if (dataformgv.Rows.Count > 1)
            {
                string choose = dataformgv.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DELETE FROM giangvien where hoten ='" + choose + "'";

                try
                {
                    if (MessageBox.Show("bạn có muốn xóa  không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Xóa giảng viên thành công!");
                        FormGV_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa :" + ex.Message);
                }
            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string name = txttimkiem.Text.Trim();
            if (name == "")
            {
                FormGV_Load(sender, e);
            }
            else
            {
                string query = "Select * from giangvien where maGV like '%" + name + "%'";
                dataformgv.DataSource = modify.Table(query);
            }
        }

        private void dataformgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataformgv.Rows.Count > 1)
            {
                txtname.Text = dataformgv.SelectedRows[0].Cells[0].Value.ToString();
                txtsex.Text = dataformgv.SelectedRows[0].Cells[1].Value.ToString();
                txtmgv.Text = dataformgv.SelectedRows[0].Cells[2].Value.ToString();
                txtphonenumber.Text = dataformgv.SelectedRows[0].Cells[3].Value.ToString();
                txtmamh.Text = dataformgv.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void txtmgv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btlthem_Click_1(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query = "INSERT INTO giangvien VALUES('" + giangvien.Hoten + "', '" + giangvien.Sex + "','" + giangvien.Magv + "','" + giangvien.Sdt + "','" + giangvien.Mamh + "')";
                try
                {
                    if (MessageBox.Show("bạn có muốn thêm vào không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm giảng viên thành công!");
                        FormGV_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm :" + ex.Message);
                }
            }
        }

        private void txtmgv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
