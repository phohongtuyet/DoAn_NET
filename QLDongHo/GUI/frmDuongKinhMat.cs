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
    public partial class frmDuongKinhMat : Form
    {
        DuongKinhMat_BUS dkBus = new DuongKinhMat_BUS();
        bool themMoi = false;
        string oldValue = "";
        public static int quyenHan = -1;
        public frmDuongKinhMat(int quyen)
        {
            quyenHan = quyen;
            InitializeComponent();
        }

        private void frmDuongKinhMat_Load(object sender, EventArgs e)
        {
            dgvDuongKinh.AutoGenerateColumns = false;
            if (quyenHan == 0)
            {
                btnCapNhat.Visible = false;
                btnLuu.Visible = false;
                btnThem.Visible = false;
                btnXoa.Visible = false;
            }
            dkBus.HienThiVaoDGV(dgvDuongKinh, bindingNavigator1, txtID, nupDuongKinh);
            BatTat(false);
        }
        private void BatTat(bool giaTri)
        {
            //txtID.Enabled = giaTri;
            nupDuongKinh.Enabled = giaTri;
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
            nupDuongKinh.Value = 0;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            BatTat(true);
            themMoi = false;

            oldValue = txtID.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa đường kính " + nupDuongKinh.Text + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                DuongKinhMat_DTO info = new DuongKinhMat_DTO();
                info.Id1 = Convert.ToInt32(txtID.Text);
                dkBus.Xoa(info);

                frmDuongKinhMat_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (nupDuongKinh.Text.Trim() == "")
                MessageBox.Show("Số đường kính không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DuongKinhMat_DTO info = new DuongKinhMat_DTO();
                info.SoKichThuocMat1 = Convert.ToInt32(nupDuongKinh.Value);

                if (themMoi)
                {
                    dkBus.Them(info);
                }
                else
                {
                    dkBus.CapNhat(info, oldValue);
                }

                frmDuongKinhMat_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
