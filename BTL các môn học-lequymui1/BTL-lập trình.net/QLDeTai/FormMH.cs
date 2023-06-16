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
    public partial class FormMH : Form
    {
        public FormMH()
        {
            InitializeComponent();
        }
        modify modify = new modify();
        MonHoc monhoc;
        private void FormMH_Load(object sender, EventArgs e)
        {
            try
            {
                dataformh.DataSource = modify.Table("Select * from monhoc");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex.Message);
            }
            Delete();
        }
        private void Delete()
        {
            cbbtenMH.SelectedIndex = -1;
            txtgiatc.Text = "";
            txtmmh.Text = "";
            txtsotinchi.Text = "";

        }
        private bool CheckTextBoxes()
        {
            if (cbbtenMH.SelectedIndex == -1) { MessageBox.Show("Mời bạn chọn môn học"); return false; }
            return true;
        }
        private void GetValuesTextBoxes()
        {
            string _Tenmh = cbbtenMH.Text;
            string _Mamh = txtmmh.Text;
            int _STC = int.Parse(txtsotinchi.Text);
            double _Giatien = double.Parse(txtgiatc.Text);
            monhoc = new MonHoc(_Tenmh, _Mamh, _STC, _Giatien);
        }

        private void btlthem_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query = "INSERT INTO monhoc VALUES('" + monhoc.TenMH + "', '" + monhoc.MaMH + "','" + monhoc.STC + "','" + monhoc.Giatien + "','" + monhoc.Tongtien() + "')";
                try
                {
                    if (MessageBox.Show("bạn có muốn thêm vào không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm môn học thành công!");
                        FormMH_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm :" + ex.Message);
                }
            }
        }

        private void cbbtenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbtenMH.SelectedIndex == 0)
            {
                txtmmh.Text = "01";
                txtsotinchi.Text = "4";
                txtgiatc.Text = "550";
            }
            if (cbbtenMH.SelectedIndex == 1)
            {
                txtmmh.Text = "02";
                txtsotinchi.Text = "3";
                txtgiatc.Text = "450";
            }
            if (cbbtenMH.SelectedIndex == 2)
            {
                txtmmh.Text = "03";
                txtsotinchi.Text = "3";
                txtgiatc.Text = "450";
            }
            if (cbbtenMH.SelectedIndex == 3)
            {
                txtmmh.Text = "04";
                txtsotinchi.Text = "3";
                txtgiatc.Text = "450";
            }
            if (cbbtenMH.SelectedIndex == 4)
            {
                txtmmh.Text = "05";
                txtsotinchi.Text = "3";
                txtgiatc.Text = "450";
            }
        }


        private void btlxoa_Click(object sender, EventArgs e)
        {
            if (dataformh.Rows.Count > 1)
            {
                string choose = dataformh.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DELETE FROM monhoc where tenmh ='" + choose + "'";

                try
                {
                    if (MessageBox.Show("bạn có muốn xóa  không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Xóa môn học thành công!");
                        FormMH_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa :" + ex.Message);
                }
            }
        }
    }
}
