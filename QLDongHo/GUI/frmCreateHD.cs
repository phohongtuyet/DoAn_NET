using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDongHo.BUS;
using QLDongHo.DTO;

namespace QLDongHo.GUI
{
    public partial class frmCreateHD : Form
    {
        public frmCreateHD()
        {
            InitializeComponent();
        }
        KhachHang_BUS khUS = new KhachHang_BUS();
        frmHoaDonKH kh = null;
        private void btnLapHD_Click(object sender, EventArgs e)
        {
            if (txtten.Text.Trim() == "")
                MessageBox.Show("Tên khách hàng không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtsdt.Text.Trim() == "")
                MessageBox.Show("Điện thoại không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtdiachi.Text.Trim() == "")
                MessageBox.Show("Địa chỉ không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                KhachHang_DTO info = new KhachHang_DTO();
                info.HoVaTen = txtten.Text;
                info.DienThoai = txtsdt.Text;
                info.DiaChi = txtdiachi.Text;
                khUS.Them(info);
            }
            frmHoaDonKH hd = new frmHoaDonKH();
            hd.KhachHang = txtten.Text;
            hd.NhanVien = txtNhanVien.Text;
            hd.ShowDialog();
            this.Close();
            
        }

        public string NhanVien;

        private void frmCreateHD_Load(object sender, EventArgs e)
        {
            txtNhanVien.Text = NhanVien;
        }
        
        public void Regexp(string re, TextBox tb, PictureBox pc)
        {
            Regex regex = new Regex(re);

            if (regex.IsMatch(tb.Text))
            {
                pc.Image = Properties.Resources.check;
            }
            else
            {
                pc.Image = Properties.Resources.cancel;
            }
        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {
            Regexp(@"^\+?(09|08|03|05|07)\d{8}", txtsdt, pictureBox1);
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
