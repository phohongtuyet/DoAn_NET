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
    public partial class frmLoai : Form
    {
        Loai_BUS lUS = new Loai_BUS();
        bool themMoi = false;
        string oldValue = "";
        public static int quyenHan = -1;

        public frmLoai(int quyen)
        {
            quyenHan = quyen;
            InitializeComponent();
        }

        private void frmLoai_Load(object sender, EventArgs e)
        {
            dgvThuongHieu.AutoGenerateColumns = false;
            if (quyenHan == 0)
            {
                btnCapNhat.Visible = false;
                btnLuu.Visible = false;
                btnThem.Visible = false;
                btnXoa.Visible = false;
            }
            lUS.HienThiVaoDGV(dgvThuongHieu, bindingNavigator1, txtID, txtTenLoai);
            BatTat(false);
        }
        private void BatTat(bool giaTri)
        {
            //txtID.Enabled = giaTri;
            txtTenLoai.Enabled = giaTri;
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
            txtTenLoai.Text = "";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            BatTat(true);
            themMoi = false;

            oldValue = txtID.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa phòng ban " + txtTenLoai.Text + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Loai_DTO info = new Loai_DTO();
                info.Id1 = Convert.ToInt32(txtID.Text);
                lUS.Xoa(info);

                frmLoai_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenLoai.Text.Trim() == "")
                MessageBox.Show("Tên loại không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Loai_DTO info = new Loai_DTO();
                info.TenLoai = txtTenLoai.Text;

                if (themMoi)
                {
                    lUS.Them(info);
                }
                else
                {
                    lUS.CapNhat(info, oldValue);
                }

                frmLoai_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
