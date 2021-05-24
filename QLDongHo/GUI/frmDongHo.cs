using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDongHo.BUS;
using QLDongHo.DTO;

namespace QLDongHo.GUI
{
    public partial class frmDongHo : Form
    {
        DongHo_BUS dhBus = new DongHo_BUS();
        DuongKinhMat_BUS dkUS = new DuongKinhMat_BUS();
        Loai_BUS lUS = new Loai_BUS();
        ThuongHieu_BUS thUS = new ThuongHieu_BUS();

        bool themMoi = false;
        string oldValue = "";
        public static int quyenHan = -1;
        public frmDongHo(int quyen)
        {
            quyenHan = quyen;
            InitializeComponent();
        }

        private void frmDongHo_Load(object sender, EventArgs e)
        {

            dgvDSDongHo.AutoGenerateColumns = false;
            if (quyenHan == 0)
            {
                btnCapNhat.Visible = false;
                btnLuu.Visible = false;
                btnThem.Visible = false;
                btnXoa.Visible = false;
            }
            dhBus.HienThiVaoDGV(dgvDSDongHo, bindingNavigator1, txtID, txtTenDongHo, txtDonGia,txtGiaBan, chkGioiTinh, cboThuongHieu, cboLoai, cboDuongKinh, nUDSoLuong);

            dkUS.HienThiVaoComboBox(cboDuongKinh);
            lUS.HienThiVaoComboBox(cboLoai);
            thUS.HienThiVaoComboBox(cboThuongHieu);

            BatTat(false);
        }
        private void BatTat(bool giaTri)
        {
            //txtID.Enabled = giaTri;
            txtTenDongHo.Enabled = giaTri;
            txtDonGia.Enabled = giaTri;
            cboLoai.Enabled = giaTri;
            cboThuongHieu.Enabled = giaTri;
            chkGioiTinh.Enabled = giaTri;
            cboDuongKinh.Enabled = giaTri;
            nUDSoLuong.Enabled = giaTri;
            txtGiaBan.Enabled = giaTri;

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
            txtTenDongHo.Text = "";
            chkGioiTinh.Checked = false;
            txtDonGia.Text = "";
            cboDuongKinh.Text = "";
            cboLoai.Text = "";
            cboThuongHieu.Text = "";
            nUDSoLuong.Value = 0;
            txtGiaBan.Text = "";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            BatTat(true);
            themMoi = false;

            oldValue = txtID.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa đồng hồ " + txtTenDongHo.Text + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                DongHo_DTO info = new DongHo_DTO();
                info.ID1 =Convert.ToInt32(txtID.Text);
                dhBus.Xoa(info);
                frmDongHo_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (txtTenDongHo.Text.Trim() == "")
                MessageBox.Show("Tên nhân viên không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);          
            else if (txtDonGia.Text.Trim() == "")
                MessageBox.Show("Điện thoại không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DongHo_DTO info = new DongHo_DTO();
               
                info.ThuongHieu_ID = Convert.ToInt32(cboThuongHieu.SelectedValue);
                info.Loai_ID = Convert.ToInt32(cboLoai.SelectedValue);
                info.DuongKinhMat_ID = Convert.ToInt32(cboDuongKinh.SelectedValue);
                info.GioiTinh = chkGioiTinh.Checked ? "F" : "M";
                info.TenDongHo = txtTenDongHo.Text;
                info.DonGia = Convert.ToInt32(txtDonGia.Text);
                info.GiaBan = Convert.ToInt32(txtGiaBan.Text);
                info.SoLuong = Convert.ToInt32(nUDSoLuong.Value);

                if (themMoi)
                {
                    dhBus.Them(info);
                }
                else
                {
                    dhBus.CapNhat(info, oldValue);
                }

                frmDongHo_Load(sender, e);
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDSDongHo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDSDongHo.Columns[e.ColumnIndex].Name == "colGioiTinh")
            {
                e.Value = e.Value.ToString() == "F" ? "Nữ" : "Nam";
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text.Trim() == "")
                MessageBox.Show("Tên từ khóa không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                dhBus.timKiem(txtTuKhoa.Text);
            }
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            dhBus.timKiem(txtTuKhoa.Text);
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

       

        /*private bool kiemMa(string maDongHo)
        {
            /*DataTable dt = new DataTable();
            dt = dhBus.kiemTraMa("Where MaDongHo = '" + txtID + "'");
            if (dt.Rows.Count == 1)
                return true;
            return false;
        }*/
    }
}
