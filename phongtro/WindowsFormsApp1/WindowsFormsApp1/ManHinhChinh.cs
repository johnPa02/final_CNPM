using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            HOADON hd = HOADON.GetHoaDon(txtSoPhong.Text);
            int? tongTien = 0;
            string dichVu = "";
            List<CHITIETHOADON> ctHD = CHITIETHOADON.GetChiTietHoaDon(hd.MAHD);
            for (int i = 0; i < ctHD.Count; i++)
            {
                dichVu+=ctHD[i].TENDV+": "+(ctHD[i].DONGIA*ctHD[i].SOLUONG).ToString()+"\n";
                tongTien += ctHD[i].DONGIA * ctHD[i].SOLUONG;
            }
            string ngayLap = string.Format("{0:dd/MM/yyyy}", hd.NGAYHOADON);
            string m = "Mã Hoá Đơn: " + hd.MAHD + "\n" +
                "Tên Khách Hàng: " + hd.GetTenKhachHang(hd.MAKH) + "\n" +
                "Ngày lập: " + ngayLap + "\n" +
                dichVu +
                "Tổng tiền: " + tongTien.ToString();
            MessageBox.Show(m);
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            ThemHoaDon thd = new ThemHoaDon();
            thd.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.Show();
        }

        private void btnXemKH_Click(object sender, EventArgs e)
        {
            XemKhachHang x = new XemKhachHang();
            x.Show();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            KHACHHANG kh = new KHACHHANG();
            Random r = new Random();
            kh.MAKH = r.Next(0, 255).ToString();
            kh.SDT = txtSdt.Text;
            kh.QUEQUAN = txtQueQuan.Text;
            kh.HOTENKH = txtHoTen.Text;
            kh.NGAYSINH = DateTime.Parse(mskNgaySinh.Text);

            kh.InsertUpdate();
        }
    }
}
