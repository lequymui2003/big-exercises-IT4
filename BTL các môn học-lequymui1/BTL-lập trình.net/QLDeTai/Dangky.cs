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
using System.Text.RegularExpressions;
namespace QLDeTai
{
    public partial class Dangky : Form
    {
        public Dangky()
        {
            InitializeComponent();
        }
        modify Modify = new modify();

        public bool CheckAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[\w.]{3,20}@gmail.com$");
        }

        private void btldangky_Click(object sender, EventArgs e)
        {
            string Username = txtusername.Text;
            string Password = txtpassword.Text;
            string Confirmpassword = txtcfpassword.Text;
            string Email = txtemail.Text;
            if (!CheckAccount(Username)) { MessageBox.Show("Vui lòng nhập tên tài khoản bao gồm các ký tự hoa,ký tự thường và số, có độ dài 6-24 ký tự"); return; }
            if (!CheckAccount(Password)) { MessageBox.Show("Vui lòng nhập tên tài khoản bao gồm các ký tự hoa,ký tự thường và số, có độ dài 6-24 ký tự"); return; }
            if (!CheckAccount(Confirmpassword)) { MessageBox.Show("Vui lòng nhập lại mật khẩu không trùng khớp"); return; }
            if (!CheckEmail(Email)) { MessageBox.Show("Vui lòng nhập email bao gồm các ký tự hoa, ký tự thường và số, có độ dài từ 3-20 ký tự, phải có @gmail.com"); return; }
            if (Modify.Taikhoans("Select * from NguoiDung where Email ='" + Email + "'").Count != 0) { MessageBox.Show("Email đã được đăng ký vui lòng đăng ký email khác"); return; }
            try
            {
                string query = "Insert into NguoiDung values('" + Username + "','" + Password + "','" + Confirmpassword + "','" + Email + "') ";
                Modify.Command(query);
                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tên tải khoản này đã được đăng ký! Vui lòng đăng ký tài khoản khác!");
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
    }
}
