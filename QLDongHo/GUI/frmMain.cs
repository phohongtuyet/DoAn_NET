using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Services;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDongHo.BUS;
using QLDongHo.report;


namespace QLDongHo.GUI
{
    public partial class frmMain : Form
    {
        frmDongHo fDH = null;
        frmHoaDon fHD = null;
        frmDuongKinhMat fDK = null;
        frmNhanVien fNV = null;
        frmTaiKhoan fTK = null;
        frmDangNhap fDN = null;
        frmLoai fL = null;
        frmKhachHang fKH = null;
        frmThuongHieu fTH = null;
        frmDanhSachSanPham fDS = null;
        TaiKhoan_BUS tkBus = new TaiKhoan_BUS();
        CSDL_BUS csdlUS = new CSDL_BUS();
        frmDoanhThu rp = null;
        frmCreateHD CHD = null;




        public static int quyenHan = -1;
        public static string hoVaTen = "";
        

        public frmMain()
        {
            InitializeComponent();
        }
        public void ChuaDangNhap()
        {
            btnDangNhap.Enabled = true;

            btnDangXuat.Enabled = false;
            btnDongHo.Enabled = false;
            btnNhanVien.Enabled = false;
            btnDuongKinh.Enabled = false;
            btnHoaDon.Enabled = false;
            btnKhachHang.Enabled = false;
            btnTaiKhoan.Enabled = false;
            btnThuongHieu.Enabled = false;

            mnuDangXuat.Enabled = false;
            mnuDongHo.Enabled = false;
            mnuNhanVien.Enabled = false;
            //mnuPhieuLuong.Enabled = false;
            mnuTaiKhoan.Enabled = false;
            mnuDSDongHo.Enabled = false;
            mnuQuanLy.Enabled = false;
            mnuBaoCao.Enabled = false;
            lblTrangThai.Text = "Chưa đăng nhập";
        }

        public void QuanLy()
        {
            btnDangNhap.Enabled = false;

            btnDangXuat.Enabled = true;
            btnDongHo.Enabled = true;
            btnNhanVien.Enabled = true;
            btnDuongKinh.Enabled = true;
            btnHoaDon.Enabled = true;
            btnKhachHang.Enabled = true;
            btnTaiKhoan.Enabled = true;
            btnThuongHieu.Enabled = true;

            mnuDangXuat.Enabled = true;
            mnuDongHo.Enabled = true;
            mnuNhanVien.Enabled = true;
            //mnuPhieuLuong.Enabled = true;
            mnuTaiKhoan.Enabled = true;
            mnuDSDongHo.Enabled = true;
            mnuQuanLy.Enabled = true;
            mnuBaoCao.Enabled = true;
            lblTrangThai.Text = "Quản lý: " + hoVaTen;
        }

        public void NhanVien()
        {
            btnDangNhap.Enabled = false;

            btnDangXuat.Enabled = true;
            btnDongHo.Enabled = true;
            btnNhanVien.Enabled = false;
            btnDuongKinh.Enabled = false;
            btnHoaDon.Enabled = true;
            btnKhachHang.Enabled = false;
            btnTaiKhoan.Enabled = false;
            btnThuongHieu.Enabled = false;


            mnuDangXuat.Enabled = true;
            mnuDongHo.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuDongHo.Enabled = true;
            mnuTaiKhoan.Enabled = false;
            mnuDSDongHo.Enabled = true;
            mnuLoai.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuDuongKinh.Enabled = false;
            mnuQuanLy.Enabled = true;
            mnuBaoCao.Enabled = true;
            mnuKhachHang.Enabled = false;
            mnuDSHD.Enabled = false;
            mnuDoanhThu.Enabled = false;
           


            lblTrangThai.Text = "Nhân viên: " + hoVaTen;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
           LamLai:
                if (fDN == null || fDN.IsDisposed)
                    fDN = new frmDangNhap();

                if (fDN.ShowDialog() == DialogResult.OK)
                {
                    if (fDN.txtTenTaiKhoan.Text.Trim() == "")
                    {
                        MessageBox.Show("Tên tài khoản không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        fDN.txtTenTaiKhoan.Focus();
                        goto LamLai;
                    }
                    else if (fDN.txtMatKhau.Text.Trim() == "")
                    {
                        MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        fDN.txtMatKhau.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        //MD5 md5Hash = MD5.Create();
                        if (tkBus.DangNhap(fDN.txtTenTaiKhoan.Text, fDN.txtMatKhau.Text) == true)
                                {
                        
                                    if (quyenHan == 1)
                                   {
                                        QuanLy();
                                        MessageBox.Show("Đăng nhập thành công");
                                   }
                               
                                    else if (quyenHan == 0)
                                    {
                                        NhanVien();
                                        MessageBox.Show("Đăng nhập thành công");
                                    }
                                    else
                                        ChuaDangNhap();
                        }
                        else
                        {
                             MessageBox.Show("Đăng nhập không thành công");
                            goto LamLai;
                        }
                     }
                }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form dm in MdiChildren)
            {
                dm.Close();
            }

            ChuaDangNhap();
        }
        
        #region Toolbar
        private void btnDongHo_Click(object sender, EventArgs e)
        {
            if (fDH == null || fDH.IsDisposed)
            {
                fDH = new frmDongHo(quyenHan);
                fDH.MdiParent = this;
                fDH.Show();
            }
            else
                fDH.Activate();
        }

        private void btnThuongHieu_Click(object sender, EventArgs e)
        {
            if (fTH == null || fTH.IsDisposed)
            {
                fTH = new frmThuongHieu(quyenHan);
                fTH.MdiParent = this;
                fTH.Show();
            }
            else
                fTH.Activate();
        }

        private void btnLoai_Click(object sender, EventArgs e)
        {
            if (fL == null || fL.IsDisposed)
            {
                fL = new frmLoai(quyenHan);
                fL.MdiParent = this;
                fL.Show();
            }
            else
                fL.Activate();
        }

        private void btnDuongKinh_Click(object sender, EventArgs e)
        {
            if (fDK == null || fDK.IsDisposed)
            {
                fDK = new frmDuongKinhMat(quyenHan);
                fDK.MdiParent = this;
                fDK.Show();
            }
            else
                fDK.Activate();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            if (CHD == null || CHD.IsDisposed)
            {
                CHD = new frmCreateHD();
                CHD.NhanVien = hoVaTen;
                CHD.MdiParent = this;
                CHD.Show();
            }
            else
                CHD.Activate();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (fNV == null || fNV.IsDisposed)
            {
                fNV = new frmNhanVien(quyenHan);
                fNV.MdiParent = this;
                fNV.Show();
            }
            else
                fNV.Activate();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            if (fTK == null || fTK.IsDisposed)
            {
                fTK = new frmTaiKhoan(quyenHan);
                fTK.MdiParent = this;
                fTK.Show();
            }
            else
                fTK.Activate();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            if (fKH == null || fKH.IsDisposed)
            {
                fKH = new frmKhachHang(quyenHan);
                fKH.MdiParent = this;
                fKH.Show();
            }
            else
                fKH.Activate();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

       
        #region menu
        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            btnDangNhap_Click(sender, e);
        }
       

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            btnDangXuat_Click(sender, e);
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            btnThoat_Click(sender, e);
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            btnNhanVien_Click(sender, e);
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            btnTaiKhoan_Click(sender, e);
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            btnHoaDon_Click(sender, e);
        }

        private void mnuLoai_Click(object sender, EventArgs e)
        {
            btnLoai_Click(sender, e);
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            btnKhachHang_Click(sender, e);
        }

        private void mnuDuongKinh_Click(object sender, EventArgs e)
        {
            btnDuongKinh_Click(sender, e);
        }
        private void mnuDSDongHo_Click(object sender, EventArgs e)
        {

            if (fDS == null || fDS.IsDisposed)
            {
                fDS = new frmDanhSachSanPham();
                fDS.MdiParent = this;
                fDS.Show();
            }
            else
                fDS.Activate();
        }

        private void mnuDoanhThu_Click(object sender, EventArgs e)
        {
            if (rp == null || rp.IsDisposed)
            {
                rp = new frmDoanhThu();
                rp.MdiParent = this;
                rp.Show();
            }
            else
                rp.Activate();
        }

        private void mnuHuongDan_Click(object sender, EventArgs e)
        {
            btnHuongDan_Click(sender, e);
        }
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
        }


      

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolThoiGian.Text = DateTime.Now.ToString();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rp == null || rp.IsDisposed)
            {
                rp = new frmDoanhThu();
                rp.MdiParent = this;
                rp.Show();
            }
            else
                rp.Activate();
            /*using (frmDoanhThu rp=new frmDoanhThu())
            {
                rp.ShowDialog();
            }   */ 
        }

        private void mnuSaoLuu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saoluuFolder = new FolderBrowserDialog();
            saoluuFolder.Description = "Chọn thư mục lưu trữ";
            if (saoluuFolder.ShowDialog() == DialogResult.OK)
            {
                string sDuongDan = saoluuFolder.SelectedPath;
                try
                {
                    csdlUS.SaoLuu(sDuongDan);
                    MessageBox.Show("Đã sao lưu dữ liệu vào " + sDuongDan);
                }
                catch
                {
                    MessageBox.Show("Thao tác không thành công");
                }              
                    
            }                 
        }

        private void mnuKhoiPhucc_Click(object sender, EventArgs e)
        {
            OpenFileDialog phuchoiFile = new OpenFileDialog();
            phuchoiFile.Filter = "*.bak|*.bak";
            phuchoiFile.Title = "Chọn tập tin phục hồi (.bak)";
            if (phuchoiFile.ShowDialog() == DialogResult.OK &&
           phuchoiFile.CheckFileExists == true)
            {
                string sDuongDan = phuchoiFile.FileName;
                try
                {
                    csdlUS.PhucHoi(sDuongDan);
                    MessageBox.Show("Đã phục hồi dữ liệu thành công ");
                }
                catch
                {
                    MessageBox.Show("Thao tác phục hồi dữ liệu không thành công");
                }
                
            }
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this,"file://D:\\DH19PM\\2020-2021\\HK-VI\\LTQL\\DoAnQLDH\\DoAn_NET\\DoAn_NET.chm");
        }

        private void mnuDSHD_Click(object sender, EventArgs e)
        {
            if (fHD == null || fHD.IsDisposed)
            {
                fHD = new frmHoaDon();
                fHD.MdiParent = this;
                fHD.Show();
            }
            else
                fHD.Activate();
        }

       
    }
    
}
