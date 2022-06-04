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
    public partial class XemKhachHang : Form
    {
        public XemKhachHang()
        {
            InitializeComponent();
        }

        private void XemKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLPTDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qLPTDataSet.KHACHHANG);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
