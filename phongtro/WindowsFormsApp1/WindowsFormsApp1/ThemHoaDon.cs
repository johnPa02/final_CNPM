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
    public partial class ThemHoaDon : Form
    {
        

        public ThemHoaDon()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == null)
            {
                MessageBox.Show("Không được bỏ trống mã hoá đơn");
            }
            else
            {
                List<HOADON> list = HOADON.GetAll();
                var check = list.Where(item => item.MAHD.Equals(txtMaHD.Text)).FirstOrDefault();
                
                if (check == null)
                {
                    try
                    {
                        HOADON hd = new HOADON();
                        hd.MAHD = txtMaHD.Text;
                        hd.MAKH = txtMaKH.Text;
                        hd.NGAYHOADON = dtNgayLap.Value;
                        hd.MAPHONG = txtMaPhong.Text;
                        hd.InsertUpdate();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                try
                {
                    CHITIETHOADON ctHD = new CHITIETHOADON();
                    ctHD.MAHD = txtMaHD.Text;
                    ctHD.TENDV = cmbTenDV.Text;
                    ctHD.SOLUONG = Int32.Parse(txtSoLuong.Text);
                    ctHD.DONGIA = Int32.Parse(txtDonGia.Text);
                    ctHD.InsertUpdate();

                    cmbTenDV.SelectedIndex = -1;
                    txtSoLuong.Text = "";
                    txtDonGia.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cmbTenDV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
