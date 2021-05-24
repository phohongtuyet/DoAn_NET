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
using QLDongHo.report;

namespace QLDongHo.GUI
{
    public partial class frmHoaDonKH : Form
    {
        DongHo_BUS dhUS = new DongHo_BUS();

        HoaDonChiTiet_BUS ctUS = new HoaDonChiTiet_BUS();
        HoaDon_BUS hdUS = new HoaDon_BUS();
        NhanVien_BUS nvUS = new NhanVien_BUS();
        KhachHang_BUS khUS = new KhachHang_BUS();

        int vitriclick = 0;
        DataTable dtDSChiTiet = new DataTable();

        bool themMoi = false;
        string oldValue = "";

        public string KhachHang;
        public string NhanVien;
        public string maHD;
        public frmHoaDonKH()
        {
            InitializeComponent();
        }
       
        private void frmHoaDonKH_Load(object sender, EventArgs e)
        {
            
            //ctUS.HienThiCTVaoDGV(dgvDSHH, bindingNavigator1,txtMaHD, txtDonGia, labThanhTien, cboSanPham, txtsoluong);
            dhUS.HienThiVaoComboBox(cboSanPham);
            khUS.HienThiVaoComboBox(cboKH);
            nvUS.HienThiVaoComboBox(cboNV);
            cboKH.Text = KhachHang;
            cboNV.Text = NhanVien;          
            BatTat(false);
            
        }
        private void BatTat(bool giaTri)
        {
            txtMaHD.Enabled = giaTri;


            cboSanPham.Enabled = giaTri;

            txtsoluong.Enabled = giaTri;
            txtDonGia.Enabled = giaTri;

            btnLuu.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            // btnXoa.Enabled = !giaTri;

            btnThemSP.Enabled = giaTri;
            btnXoaSP.Enabled = giaTri;
        }
        private void BatTatIn(bool giaTri)
        {
            btninHoaDon.Enabled = giaTri;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTat(true);
            themMoi = true;
            txtMaHD.Text = "";
            cboSanPham.Text = "";
            txtDonGia.Text = "";
            //txtsoluong.Text = "";

            dtDSChiTiet.Rows.Clear();

            dtDSChiTiet.Columns.Add("MaHD");
            dtDSChiTiet.Columns.Add("Đồng hồ");
            dtDSChiTiet.Columns.Add("Đơn giá");
            dtDSChiTiet.Columns.Add("Số lượng");
            dtDSChiTiet.Columns.Add("Thành tiền");
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {


            if (kiemtraSL(cboSanPham.SelectedValue.ToString(), int.Parse(txtsoluong.Text.Trim())))
            {
                if (!checktrung(cboSanPham.SelectedValue.ToString()))
                {
                    DataRow dr = dtDSChiTiet.NewRow();
                    dr[0] = txtMaHD.Text.Trim();
                    dr[1] = cboSanPham.SelectedValue.ToString();
                    dr[2] = txtsoluong.Text;
                    dr[3] = txtDonGia.Text;
                    dr[4] = (double.Parse(txtDonGia.Text) * int.Parse(txtsoluong.Text)).ToString();
                    dtDSChiTiet.Rows.Add(dr);
                }
                else
                {
                    capnhatSL(cboSanPham.SelectedValue.ToString(), int.Parse(txtsoluong.Text));
                }
                dgvDSHH.DataSource = dtDSChiTiet;
            }
            else
            {
                MessageBox.Show("Số lượng không dủ", "Lỗi");
                txtsoluong.Focus();
            }

        }
        private bool checktrung(string mahh)
        {
            for (int i = 0; i < dtDSChiTiet.Rows.Count; i++)
                if (dtDSChiTiet.Rows[i][0].ToString() == mahh)
                    return true;
            return false;
        }

        private bool kiemtraSL(string maDongHo, int sl)
        {
            DataTable dt = new DataTable();
            dt = dhUS.DanhSach("Where ID = '" + maDongHo + "' and SoLuong >= " + sl);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        private bool KiemTraTrung(string MaHD)
        {
            DataTable dt = new DataTable();
            dt = hdUS.kiemTraTrung("Where MaHD ='" + MaHD + "'");
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        private void capnhatSL(string mahh, int SL)
        {
            for (int i = 0; i < dtDSChiTiet.Rows.Count; i++)
                if (dtDSChiTiet.Rows[i][1].ToString() == mahh)
                {
                    int soluong = int.Parse(dtDSChiTiet.Rows[i][2].ToString()) + SL;
                    dtDSChiTiet.Rows[i][3] = soluong;
                    double dongia = double.Parse(dtDSChiTiet.Rows[i][3].ToString());
                    dtDSChiTiet.Rows[i][4] = (dongia * soluong).ToString();
                    break;
                }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (vitriclick < dtDSChiTiet.Rows.Count)
            {
                dtDSChiTiet.Rows.RemoveAt(vitriclick);
                dgvDSHH.DataSource = dtDSChiTiet;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BatTatIn(true);
            if (txtMaHD.TextLength == 0)
            {
                MessageBox.Show("Mã HD không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaHD.Focus();
            }
            else if (cboNV.Text == "")
            {
                MessageBox.Show("Nhân viên không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboNV.Focus();
            }
            else if (cboKH.Text == "")
            {
                MessageBox.Show("khách hàng không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboKH.Focus();
            }
            else
            {
                HoaDon_DTO info = new HoaDon_DTO();
                info.MaHD = txtMaHD.Text;
                info.NhanVien_ID = Convert.ToInt32(cboNV.SelectedValue.ToString());
                info.KhachHang_ID1 = Convert.ToInt32(cboKH.SelectedValue.ToString());
                info.NgayLap = DateTime.Now;
                hdUS.Them(info);
                if (themMoi)
                {
                    if (ctUS.ThemHDCT(dtDSChiTiet) && dhUS.UpdSL(dtDSChiTiet))
                        MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm chi tiết không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Thêm hóa đơn không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                frmHoaDonKH_Load(sender, e);
            }
        }

      

        private void dgvDSHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            vitriclick = e.RowIndex;
        }

      

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            labThanhTien.Text = (double.Parse(txtDonGia.Text) * int.Parse(txtsoluong.Text)).ToString();
        }

        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*DataTable dt = new DataTable();
            dt = dhUS.DanhSach("Where ID = '" + cboSanPham.SelectedValue.ToString() + "'");
            if (dt.Rows.Count > 0)
            {
                double gia = double.Parse(dt.Rows[0][7].ToString());
                txtDonGia.Text = gia.ToString();
                labThanhTien.Text = (double.Parse(txtDonGia.Text) * int.Parse(txtsoluong.Text)).ToString();
            }*/
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            if (KiemTraTrung(txtMaHD.Text.Trim()) == true)
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại!");
                txtMaHD.Focus();
            }
        }

        private void btninHoaDon_Click(object sender, EventArgs e)
        {
            frmInHoaDon inHD = new frmInHoaDon(); 
            inHD.maHD = txtMaHD.Text;
            inHD.ShowDialog();
            
        }
    }
}
