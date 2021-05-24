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
    public partial class frmHoaDon : Form
    {
        DongHo_BUS dhUS = new DongHo_BUS();
        HoaDonChiTiet_BUS ctUS = new HoaDonChiTiet_BUS();
        HoaDon_BUS hdUS = new HoaDon_BUS();
        NhanVien_BUS nvUS = new NhanVien_BUS();
        KhachHang_BUS khUS = new KhachHang_BUS();

        int vitriclick = 0;
        DataTable dtDSChiTiet = new DataTable();

        public string KhachHang;
        public string NhanVien;

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dgvDSHoaDon.AutoGenerateColumns = false;

           // dgvDSHH.AutoGenerateColumns = false;
            hdUS.HienThiVaoDGV(dgvDSHoaDon, bindingNavigatorHoaDon, txtMaHD, cboNhanVien, cboKhachHang, dtpNgayLap);
            //ctUS.HienThiCTVaoDGV(dgvDSHH, bindingNavigatorSanPham, txtGia, lbThanhTien, cboSanPham, txtSoLuong);
            nvUS.HienThiVaoComboBox(cboNhanVien);
            khUS.HienThiVaoComboBox(cboKhachHang);
            //dhUS.HienThiVaoComboBox(cboSanPham);

            cboKhachHang.Text = KhachHang;
            cboNhanVien.Text = NhanVien;
            BatTat(false);
            
          
        }

       

        private void BatTat(bool giaTri)
        {
            txtMaHD.Enabled = giaTri;
            cboKhachHang.Enabled = giaTri;
            cboNhanVien.Enabled = giaTri;
            dtpNgayLap.Enabled = giaTri;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           


        }
        

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            
        }



        

       

        private void capnhatSL(string mahh, int SL)
        {
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {

            if (vitriclick < dtDSChiTiet.Rows.Count)
            {
                dtDSChiTiet.Rows.RemoveAt(vitriclick);
                dgvDSHH.DataSource = dtDSChiTiet;
            }
        }

        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
           try
            {
                DataTable dt = new System.Data.DataTable();
                dt = ctUS.getData(txtMaHD.Text.Trim());
                dgvDSHH.DataSource = dt;

            }
            catch
            {
                dgvDSHH.DataSource = null;
            }
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            
           
        }

        

        private void dgvDSHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvDSHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
