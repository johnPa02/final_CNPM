using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            txtTenDangNhap.Select();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            MATKHAU obj = new MATKHAU();
            List<MATKHAU> list = obj.GetAll();
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            var check = list.Where(item => item.USERNAME.Equals(tenDangNhap)).FirstOrDefault();
            if (check != null)
            {
                if (check.PW.Equals(matKhau))
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    ManHinhChinh mhc = new ManHinhChinh();
                    mhc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Mat khau khong dung!");
                }
            }
            else
            {
                MessageBox.Show("Khong ton tai tai khoan!");
            }
        }
    }
}
