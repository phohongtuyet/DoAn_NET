using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDongHo.BUS;
using QLDongHo.DTO;

namespace QLDongHo.GUI
{
    public partial class frmTaiKhoan : Form
    {
        TaiKhoan_BUS tkBus = new TaiKhoan_BUS();
        NhanVien_BUS nvBus = new NhanVien_BUS();
        bool themMoi = false;
        string olvale = "";
        public static int quyenHan = -1;
        public frmTaiKhoan(int quyen)
        {
            quyenHan = quyen;
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvDSTaiKhoan.AutoGenerateColumns = false;
            if (quyenHan == 0)
            {
                btnCapNhat.Visible = false;
                btnLuu.Visible = false;
                btnThem.Visible = false;
                btnXoa.Visible = false;
            }
            tkBus.HienThiVaoDGV(dgvDSTaiKhoan, bindingNavigator1, txtID, txtTaiKhoan, txtMatKhau, cboNhanVien, cboQuyenHan);
            nvBus.HienThiVaoComboBox(cboNhanVien);
            BatTat(false);
        }
        private void BatTat(bool giaTri)
        {
            cboNhanVien.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            btnLuu.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnCapNhat.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTat(true);
            themMoi = true;

            cboNhanVien.Text = "";
            cboQuyenHan.Text = "";
            txtMatKhau.Text = "";
            txtTaiKhoan.Text = "";
            txtID.Text = "";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            BatTat(true);
            themMoi = false;

            olvale = txtID.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa tài khoản nhân viên " + cboNhanVien.Text + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                TaiKhoan_DTO info = new TaiKhoan_DTO();
                info.ID1 = Convert.ToInt32(dgvDSTaiKhoan.CurrentRow.Cells[0].Value.ToString());
                tkBus.Xoa(info);

                frmTaiKhoan_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MD5 md5Hash = MD5.Create();
            if (cboNhanVien.Text == "")
                MessageBox.Show("Chưa chọn nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (cboQuyenHan.Text == "")
                MessageBox.Show("Chưa chọn quyền hạn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtMatKhau.Text == "")
                MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                TaiKhoan_DTO info = new TaiKhoan_DTO();
               
                info.NhanVien_ID = Convert.ToInt32(cboNhanVien.SelectedValue);
                info.Quyen = cboQuyenHan.SelectedIndex;
                info.TaiKhoan = txtTaiKhoan.Text;
                info.MatKhau = tkBus.GetMd5Hash(md5Hash, Convert.ToString(txtMatKhau.Text));

                if (themMoi)
                {
                    tkBus.Them(info);
                }
                else
                {
                    info.ID1 = Convert.ToInt32(txtID.Text);
                    tkBus.capNhat(info, olvale);
                }

                frmTaiKhoan_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDSTaiKhoan.Columns[e.ColumnIndex].Name == "ColMatKhau")
            {
                e.Value = "••••••••••";
            }

            if (dgvDSTaiKhoan.Columns[e.ColumnIndex].Name == "ColQuyenHan")
            {
                e.Value = Convert.ToInt32(e.Value) == 0 ? "Nhân viên" : "Quản lý";
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {

        }
    }
}
