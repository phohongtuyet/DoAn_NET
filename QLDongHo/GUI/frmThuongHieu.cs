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
    public partial class frmThuongHieu : Form
    {
        ThuongHieu_BUS thBus = new ThuongHieu_BUS();
        bool themMoi = false;
        string oldValue = "";
        public static int quyenHan = -1;
        public frmThuongHieu(int quyen)
        {
            quyenHan = quyen;
            InitializeComponent();
        }

        private void frmThuongHieu_Load(object sender, EventArgs e)
        {
            dgvThuongHieu.AutoGenerateColumns = false;
            if (quyenHan == 0)
            {
                btnCapNhat.Visible = false;
                btnLuu.Visible = false;
                btnThem.Visible = false;
            }
                thBus.HienThiVaoDGV(dgvThuongHieu, bindingNavigator1, txtID, txtTenThuongHieu);
            BatTat(false);
        }
        private void BatTat(bool giaTri)
        {
            //txtID.Enabled = giaTri;
            txtTenThuongHieu.Enabled = giaTri;
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
            txtTenThuongHieu.Text = "";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            BatTat(true);
            themMoi = false;

            oldValue = txtID.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa phòng ban " + txtTenThuongHieu.Text + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                ThuongHieu_DTO info = new ThuongHieu_DTO();
                info.Id1 = Convert.ToInt32(txtID.Text);
                thBus.Xoa(info);

                frmThuongHieu_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenThuongHieu.Text.Trim() == "")
                MessageBox.Show("Tên thương hiệu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ThuongHieu_DTO info = new ThuongHieu_DTO();
                info.TenThuongHieu = txtTenThuongHieu.Text;

                if (themMoi)
                {
                    thBus.Them(info);
                }
                else
                {
                    thBus.CapNhat(info, oldValue);
                }

                frmThuongHieu_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
