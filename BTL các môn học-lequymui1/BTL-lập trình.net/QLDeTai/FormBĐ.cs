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
    public partial class FormBĐ : Form
    {
        public FormBĐ()
        {
            InitializeComponent();
        }
        modify modify = new modify();
        BangDiem bangdiem;
        private void FormBĐ_Load(object sender, EventArgs e)
        {
            try
            {
                dataformbd.DataSource = modify.Table("Select * from bangdiem");
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
            txtMĐT.Text = "";
            txtdiemlan1.Text = "";
            txtdiemlan2.Text = "";
            txtnhanxet.Text = "";
        }
        private bool CheckTextBoxes()
        {
            if (txtmsv.Text == "") { MessageBox.Show("Mời bạn nhập mã sinh viên"); return false; }
            if (txtMĐT.Text == "") { MessageBox.Show("Mời bạn nhập mã đề tài"); return false; }
            if (txtdiemlan1.Text == "") { MessageBox.Show("Mời bạn nhập điểm lần 1"); return false; }
            if (txtdiemlan2.Text == "") { MessageBox.Show("Mời bạn nhập điểm lần 2"); return false; }
            if (txtnhanxet.Text == "") { MessageBox.Show("Mời bạn nhập nhận xét"); return false; }
            return true;
        }
        private void GetValuesTextBoxes()
        {
            string _Masv = txtmsv.Text;
            string _Madt = txtMĐT.Text;
            float _Diemlan1 = float.Parse(txtdiemlan1.Text);
            float _Diemlan2 = float.Parse(txtdiemlan2.Text);
            string _Nhanxet = txtnhanxet.Text;
            bangdiem = new BangDiem(_Madt, _Masv, _Diemlan1, _Diemlan2, _Nhanxet);
        }

        private void btlthem_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query = "INSERT INTO bangdiem VALUES('" + bangdiem.MaDT + "', '" + bangdiem.MaSV + "','" + bangdiem.Diemlan1 + "','" + bangdiem.Diemlan2 + "','" + bangdiem.Nhanxet + "')";
                try
                {
                    if (MessageBox.Show("bạn có muốn thêm vào không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm bảng điểm thành công!");
                        FormBĐ_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm :" + ex.Message);
                }
            }
        }

        private void btlsua_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query = "UPDATE bangdiem SET maDT = N'" + bangdiem.MaDT + "', masv ='" + bangdiem.MaSV + "', diemlan1 ='" + bangdiem.Diemlan1 + "', diemlan2 ='" + bangdiem.Diemlan2 + "', nhanxet ='" + bangdiem.Nhanxet + "'";
                query += "WHERE maDT ='" + bangdiem.MaDT + "'";
                try
                {
                    if (MessageBox.Show("bạn có muốn sửa  không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Sửa bảng điểm thành công!");
                        FormBĐ_Load(sender, e);
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
            if (dataformbd.Rows.Count > 1)
            {
                string choose = dataformbd.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DELETE FROM bangdiem where maDT ='" + choose + "'";

                try
                {
                    if (MessageBox.Show("bạn có muốn xóa  không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Xóa bảng điểm thành công!");
                        FormBĐ_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa :" + ex.Message);
                }
            }
        }

        private void txtMĐT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtmsv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dataformbd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataformbd.Rows.Count > 1)
            {
                txtMĐT.Text = dataformbd.SelectedRows[0].Cells[0].Value.ToString();
                txtmsv.Text = dataformbd.SelectedRows[0].Cells[1].Value.ToString();
                txtdiemlan1.Text = dataformbd.SelectedRows[0].Cells[2].Value.ToString();
                txtdiemlan2.Text = dataformbd.SelectedRows[0].Cells[3].Value.ToString();
                txtnhanxet.Text = dataformbd.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string name = txttimkiem.Text.Trim();
            if (name == "")
            {
                FormBĐ_Load(sender, e);
            }
            else
            {
                string query = "Select * from bangdiem where maDT like '%" + name + "%'";
                dataformbd.DataSource = modify.Table(query);
            }
        }
    }
}
