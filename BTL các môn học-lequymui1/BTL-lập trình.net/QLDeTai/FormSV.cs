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
    public partial class FormSV : Form
    {
        public FormSV()
        {
            InitializeComponent();
        }
        modify modify = new modify();
        SinhVien sinhvien;

        private void FormSV_Load(object sender, EventArgs e)
        {
            try
            {
                dataformsv.DataSource = modify.Table("Select * from sinhvien");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex.Message);
            }
            Delete();
        }
        private void Delete()
        {
            txtmsv.Text = "";
            txtname.Text = "";
            txtsex.Text = "";
            txtdate.Text = "";
            txtaddress.Text = "";
            txtclass.Text = "";
            txtphonenumber.Text = "";
        }
        private bool CheckTextBoxes()
        {
            if (txtmsv.Text == "") { MessageBox.Show("Mời bạn nhập mã sinh viên"); return false; }
            if (txtname.Text == "") { MessageBox.Show("Mời bạn nhập tên sinh viên"); return false; }
            if (txtsex.Text == "") { MessageBox.Show("Mời bạn nhập giới tính"); return false; }
            if (txtdate.Text == "") { MessageBox.Show("Mời bạn nhập ngày sinh"); return false; }
            if (txtaddress.Text == "") { MessageBox.Show("Mời bạn nhập địa chỉ"); return false; }
            if (txtclass.Text == "") { MessageBox.Show("Mời bạn nhập tên lớp"); return false; }
            if (txtphonenumber.Text == "") { MessageBox.Show("Mời bạn nhập số điện thoại"); return false; }
            return true;
        }
        private void GetValuesTextBoxes()
        {
            string _Masv = txtmsv.Text;
            string _Name = txtname.Text;
            string _Sex = txtsex.Text;
            int _Age = int.Parse(txtdate.Text);
            string _Address = txtaddress.Text;
            string _Class = txtclass.Text;
            int _Phonenumber = int.Parse(txtphonenumber.Text);
            sinhvien = new SinhVien(_Masv, _Name, _Sex, _Age, _Address, _Class, _Phonenumber);
        }
        private void btlthem_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query = "INSERT INTO sinhvien VALUES('" + sinhvien.Name + "', '" + sinhvien.Masv + "','" + sinhvien.Age1 + "','" + sinhvien.Sex + "','" + sinhvien.Phonenumber + "', '" + sinhvien.Address + "','" + sinhvien.Class + "')";
                try
                {
                    if (MessageBox.Show("bạn có muốn thêm vào không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm sinh viên thành công!");
                        FormSV_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm :" + ex.Message);
                }
            }
        }

        private void txtmsv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btlsua_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query = "UPDATE sinhvien SET hoten = N'" + sinhvien.Name + "', masv ='" + sinhvien.Masv + "', tuoi ='" + sinhvien.Age1 + "', gioitinh ='" + sinhvien.Sex + "', sdt ='" + sinhvien.Phonenumber + "',diachi = '" + sinhvien.Address + "',lop = '" + sinhvien.Class + "'";
                query += "WHERE hoten ='" + sinhvien.Name + "'";
                try
                {
                    if (MessageBox.Show("bạn có muốn sửa  không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Sửa sinh viên thành công!");
                        FormSV_Load(sender, e);
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
            if (dataformsv.Rows.Count > 1)
            {
                txtname.Text = dataformsv.SelectedRows[0].Cells[0].Value.ToString();
                txtmsv.Text = dataformsv.SelectedRows[0].Cells[1].Value.ToString();
                txtdate.Text = dataformsv.SelectedRows[0].Cells[2].Value.ToString();
                txtsex.Text = dataformsv.SelectedRows[0].Cells[3].Value.ToString();
                txtphonenumber.Text = dataformsv.SelectedRows[0].Cells[4].Value.ToString();
                txtaddress.Text = dataformsv.SelectedRows[0].Cells[5].Value.ToString();
                txtclass.Text = dataformsv.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void btlxoa_Click(object sender, EventArgs e)
        {
            if (dataformsv.Rows.Count > 1)
            {
                string choose = dataformsv.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DELETE FROM sinhvien where hoten ='" + choose + "'";

                try
                {
                    if (MessageBox.Show("bạn có muốn xóa  không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Xóa sinh viên thành công!");
                        FormSV_Load(sender, e);
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
                FormSV_Load(sender, e);
            }
            else
            {
                string query = "Select * from sinhvien where lop like '%" + name + "%'";
                dataformsv.DataSource = modify.Table(query);
            }
        }

       
    }
}
