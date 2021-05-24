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
    public partial class frmKhachHang : Form
    {
        KhachHang_BUS khBus = new KhachHang_BUS();
        bool themMoi = false;
        string oldValue = "";
        public static int quyenHan = -1;

        public frmKhachHang(int quyen)
        {
            quyenHan = quyen;
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvDSNhanVien.AutoGenerateColumns = false;
            if (quyenHan == 0)
            {
                btnCapNhat.Visible = false;
                btnLuu.Visible = false;
                btnThem.Visible = false;
                btnXoa.Visible = false;
            }
            khBus.HienThiVaoDGV(dgvDSNhanVien, bindingNavigator1, txtID, txtHoVaTen, txtDienThoai, txtDiaChi);
            BatTat(false);
        }
        private void BatTat(bool giaTri)
        {
           // txtID.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;

            btnLuu.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnCapNhat.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTat(true);
            themMoi = true;

            txtID.Text = "";
            txtHoVaTen.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            BatTat(true);
            themMoi = false;

            oldValue = txtID.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa khách hàng " + txtHoVaTen.Text + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                KhachHang_DTO info = new KhachHang_DTO();
                info.Id1 = Convert.ToInt32(txtID.Text);
                khBus.Xoa(info);
                frmKhachHang_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text.Trim() == "")
                MessageBox.Show("Tên khách hàng không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtDienThoai.Text.Trim() == "")
                MessageBox.Show("Điện thoại không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtDiaChi.Text.Trim() == "")
                MessageBox.Show("Địa chỉ không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                KhachHang_DTO info = new KhachHang_DTO();
                info.HoVaTen = txtHoVaTen.Text;
                info.DienThoai = txtDienThoai.Text;
                info.DiaChi = txtDiaChi.Text;

                if (themMoi)
                {
                    khBus.Them(info);
                }
                else
                {
                    khBus.CapNhat(info, oldValue);
                }

                frmKhachHang_Load(sender, e);
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            Regexp(@"^\+?(09|08|03|05|07)\d{8}", txtDienThoai, picbox);
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

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            khBus.timKiem(txtTuKhoa.Text);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            khBus.timKiem(txtTuKhoa.Text);
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
