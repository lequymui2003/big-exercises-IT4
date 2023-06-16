using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLDeTai
{
    public partial class FormDeTai : Form
    {
        public FormDeTai()
        {
            InitializeComponent();
        }
        modify modify = new modify();
        Detai detai;
        private void FormDeTai_Load(object sender, EventArgs e)
        {
            try
            {
                dataformdt.DataSource = modify.Table("Select * from detai");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex.Message);
            }
            Delete();
        }
        private void Delete()
        {
            cbbtenDeTai.SelectedIndex = -1;
            txtmdt.Text = "";
            txtgioihan.Text = "";
        }
        private bool CheckTextBoxes()
        {
            if (cbbtenDeTai.SelectedIndex == -1) { MessageBox.Show("Mời bạn chọn môn học"); return false; }
            return true;
        }
        private void GetValuesTextBoxes()
        {
            string _Tendetai = cbbtenDeTai.Text;
            string _Madt = txtmdt.Text;
            string _Gioihan = txtgioihan.Text;
            detai = new Detai(_Tendetai, _Madt, _Gioihan);
        }

        private void btlthem_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query = "INSERT INTO detai VALUES('" + detai.TenDT + "', '" + detai.MaDT + "','" + detai.Gioihan + "')";
                try
                {
                    if (MessageBox.Show("bạn có muốn thêm vào không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm đề tài thành công!");
                        FormDeTai_Load(sender, e);
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
                string query = "UPDATE detai SET tenDT = N'" + detai.TenDT + "', maDT ='" + detai.MaDT + "', gioihan ='" + detai.Gioihan + "'";
                query += "WHERE tenDT ='" + detai.TenDT + "'";
                try
                {
                    if (MessageBox.Show("bạn có muốn sửa  không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Sửa đề tài thành công!");
                        FormDeTai_Load(sender, e);
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
            if (dataformdt.Rows.Count > 1)
            {
                string choose = dataformdt.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DELETE FROM detai where tenDT ='" + choose + "'";

                try
                {
                    if (MessageBox.Show("bạn có muốn xóa  không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Xóa môn học thành công!");
                        FormDeTai_Load(sender, e);
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
                FormDeTai_Load(sender, e);
            }
            else
            {
                string query = "Select * from detai where tenDT like '%" + name + "%'";
                dataformdt.DataSource = modify.Table(query);
            }
        }

        private void dataformdt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataformdt.Rows.Count > 1)
            {
                cbbtenDeTai.SelectedItem = dataformdt.SelectedRows[0].Cells[0].Value.ToString();
                txtmdt.Text = dataformdt.SelectedRows[0].Cells[1].Value.ToString();
                txtgioihan.Text = dataformdt.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void cbbtenDeTai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbtenDeTai.SelectedIndex == 0)
            {
                txtmdt.Text = "0111";
            }
            if (cbbtenDeTai.SelectedIndex == 1)
            {
                txtmdt.Text = "0222";
            }
            if (cbbtenDeTai.SelectedIndex == 2)
            {
                txtmdt.Text = "0333";
            }
            if (cbbtenDeTai.SelectedIndex == 3)
            {
                txtmdt.Text = "0444";
            }
            if (cbbtenDeTai.SelectedIndex == 4)
            {
                txtmdt.Text = "0555";
            }
            if (cbbtenDeTai.SelectedIndex == 5)
            {
                txtmdt.Text = "0666";
            }
        }
    }
}
