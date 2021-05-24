
namespace QLDongHo.GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSaoLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhoiPhucc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDongHo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDuongKinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSDongHo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDangNhap = new System.Windows.Forms.ToolStripButton();
            this.btnDangXuat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDongHo = new System.Windows.Forms.ToolStripButton();
            this.btnThuongHieu = new System.Windows.Forms.ToolStripButton();
            this.btnLoai = new System.Windows.Forms.ToolStripButton();
            this.btnDuongKinh = new System.Windows.Forms.ToolStripButton();
            this.btnHoaDon = new System.Windows.Forms.ToolStripButton();
            this.btnNhanVien = new System.Windows.Forms.ToolStripButton();
            this.btnTaiKhoan = new System.Windows.Forms.ToolStripButton();
            this.btnKhachHang = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHuongDan = new System.Windows.Forms.ToolStripButton();
            this.btnThongTin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuQuanLy,
            this.mnuBaoCao,
            this.mnuTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1275, 28);
            this.menuStrip1.TabIndex = 2;
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangNhap,
            this.mnuDangXuat,
            this.toolStripSeparator1,
            this.mnuSaoLuu,
            this.mnuKhoiPhucc,
            this.toolStripSeparator3,
            this.mnuThoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(85, 24);
            this.mnuHeThong.Text = "&Hệ thống";
            // 
            // mnuDangNhap
            // 
            this.mnuDangNhap.Name = "mnuDangNhap";
            this.mnuDangNhap.Size = new System.Drawing.Size(183, 26);
            this.mnuDangNhap.Text = "Đăng &nhập";
            this.mnuDangNhap.Click += new System.EventHandler(this.mnuDangNhap_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(183, 26);
            this.mnuDangXuat.Text = "Đăng &xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // mnuSaoLuu
            // 
            this.mnuSaoLuu.Name = "mnuSaoLuu";
            this.mnuSaoLuu.Size = new System.Drawing.Size(183, 26);
            this.mnuSaoLuu.Text = "&Sao Lưu";
            this.mnuSaoLuu.Click += new System.EventHandler(this.mnuSaoLuu_Click);
            // 
            // mnuKhoiPhucc
            // 
            this.mnuKhoiPhucc.Name = "mnuKhoiPhucc";
            this.mnuKhoiPhucc.Size = new System.Drawing.Size(183, 26);
            this.mnuKhoiPhucc.Text = "&Khôi phục";
            this.mnuKhoiPhucc.Click += new System.EventHandler(this.mnuKhoiPhucc_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(180, 6);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuThoat.Size = new System.Drawing.Size(183, 26);
            this.mnuThoat.Text = "&Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDongHo,
            this.mnuNhanVien,
            this.mnuTaiKhoan,
            this.mnuHoaDon,
            this.mnuLoai,
            this.mnuKhachHang,
            this.mnuDuongKinh});
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(73, 24);
            this.mnuQuanLy.Text = "&Quản lý";
            // 
            // mnuDongHo
            // 
            this.mnuDongHo.Name = "mnuDongHo";
            this.mnuDongHo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.mnuDongHo.Size = new System.Drawing.Size(220, 26);
            this.mnuDongHo.Text = "&Đồng hồ";
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.mnuNhanVien.Size = new System.Drawing.Size(220, 26);
            this.mnuNhanVien.Text = "&Nhân viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.mnuTaiKhoan.Size = new System.Drawing.Size(220, 26);
            this.mnuTaiKhoan.Text = "&Tài khoản";
            this.mnuTaiKhoan.Click += new System.EventHandler(this.mnuTaiKhoan_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.mnuHoaDon.Size = new System.Drawing.Size(220, 26);
            this.mnuHoaDon.Text = "&Hóa đơn";
            this.mnuHoaDon.Click += new System.EventHandler(this.mnuHoaDon_Click);
            // 
            // mnuLoai
            // 
            this.mnuLoai.Name = "mnuLoai";
            this.mnuLoai.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.mnuLoai.Size = new System.Drawing.Size(220, 26);
            this.mnuLoai.Text = "&Loại";
            this.mnuLoai.Click += new System.EventHandler(this.mnuLoai_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.mnuKhachHang.Size = new System.Drawing.Size(220, 26);
            this.mnuKhachHang.Text = "&Khánh hàng";
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
            // 
            // mnuDuongKinh
            // 
            this.mnuDuongKinh.Name = "mnuDuongKinh";
            this.mnuDuongKinh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D8)));
            this.mnuDuongKinh.Size = new System.Drawing.Size(220, 26);
            this.mnuDuongKinh.Text = "&Đường kính";
            this.mnuDuongKinh.Click += new System.EventHandler(this.mnuDuongKinh_Click);
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDSDongHo,
            this.mnuDoanhThu,
            this.mnuDSHD});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(77, 24);
            this.mnuBaoCao.Text = "&Báo cáo";
            // 
            // mnuDSDongHo
            // 
            this.mnuDSDongHo.Name = "mnuDSDongHo";
            this.mnuDSDongHo.Size = new System.Drawing.Size(224, 26);
            this.mnuDSDongHo.Text = "&Danh sách đồng hồ";
            this.mnuDSDongHo.Click += new System.EventHandler(this.mnuDSDongHo_Click);
            // 
            // mnuDoanhThu
            // 
            this.mnuDoanhThu.Name = "mnuDoanhThu";
            this.mnuDoanhThu.Size = new System.Drawing.Size(224, 26);
            this.mnuDoanhThu.Text = "Doanh thu";
            this.mnuDoanhThu.Click += new System.EventHandler(this.mnuDoanhThu_Click);
            // 
            // mnuDSHD
            // 
            this.mnuDSHD.Name = "mnuDSHD";
            this.mnuDSHD.Size = new System.Drawing.Size(224, 26);
            this.mnuDSHD.Text = "DS Hóa Đơn";
            this.mnuDSHD.Click += new System.EventHandler(this.mnuDSHD_Click);
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHuongDan,
            this.mnuThongTin});
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(78, 24);
            this.mnuTroGiup.Text = "&Trợ giúp";
            // 
            // mnuHuongDan
            // 
            this.mnuHuongDan.Name = "mnuHuongDan";
            this.mnuHuongDan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.mnuHuongDan.Size = new System.Drawing.Size(230, 26);
            this.mnuHuongDan.Text = "&Hướng dẫn";
            this.mnuHuongDan.Click += new System.EventHandler(this.mnuHuongDan_Click);
            // 
            // mnuThongTin
            // 
            this.mnuThongTin.Name = "mnuThongTin";
            this.mnuThongTin.Size = new System.Drawing.Size(230, 26);
            this.mnuThongTin.Text = "Thông tin &phần mềm";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDangNhap,
            this.btnDangXuat,
            this.toolStripSeparator2,
            this.btnDongHo,
            this.btnThuongHieu,
            this.btnLoai,
            this.btnDuongKinh,
            this.btnHoaDon,
            this.btnNhanVien,
            this.btnTaiKhoan,
            this.btnKhachHang,
            this.toolStripSeparator4,
            this.btnHuongDan,
            this.btnThongTin,
            this.toolStripSeparator5,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1275, 68);
            this.toolStrip1.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Image = global::QLDongHo.Properties.Resources.login32;
            this.btnDangNhap.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDangNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(86, 65);
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Image = global::QLDongHo.Properties.Resources.logout32;
            this.btnDangXuat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(81, 65);
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 68);
            // 
            // btnDongHo
            // 
            this.btnDongHo.Image = global::QLDongHo.Properties.Resources.wristwatch__1_;
            this.btnDongHo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDongHo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDongHo.Name = "btnDongHo";
            this.btnDongHo.Size = new System.Drawing.Size(71, 65);
            this.btnDongHo.Text = "Đồng hồ";
            this.btnDongHo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDongHo.Click += new System.EventHandler(this.btnDongHo_Click);
            // 
            // btnThuongHieu
            // 
            this.btnThuongHieu.Image = global::QLDongHo.Properties.Resources.catalogue;
            this.btnThuongHieu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnThuongHieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThuongHieu.Name = "btnThuongHieu";
            this.btnThuongHieu.Size = new System.Drawing.Size(96, 65);
            this.btnThuongHieu.Text = "Thương hiệu";
            this.btnThuongHieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThuongHieu.Click += new System.EventHandler(this.btnThuongHieu_Click);
            // 
            // btnLoai
            // 
            this.btnLoai.Image = global::QLDongHo.Properties.Resources.packages;
            this.btnLoai.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLoai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoai.Name = "btnLoai";
            this.btnLoai.Size = new System.Drawing.Size(41, 65);
            this.btnLoai.Text = "Loại";
            this.btnLoai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLoai.Click += new System.EventHandler(this.btnLoai_Click);
            // 
            // btnDuongKinh
            // 
            this.btnDuongKinh.Image = global::QLDongHo.Properties.Resources.diameter;
            this.btnDuongKinh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDuongKinh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDuongKinh.Name = "btnDuongKinh";
            this.btnDuongKinh.Size = new System.Drawing.Size(90, 65);
            this.btnDuongKinh.Text = "Đường kính";
            this.btnDuongKinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDuongKinh.Click += new System.EventHandler(this.btnDuongKinh_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Image = global::QLDongHo.Properties.Resources.receipt;
            this.btnHoaDon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(95, 65);
            this.btnHoaDon.Text = "Hóa đơn KH";
            this.btnHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Image = global::QLDongHo.Properties.Resources.users32_2;
            this.btnNhanVien.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(79, 65);
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Image = global::QLDongHo.Properties.Resources.users32;
            this.btnTaiKhoan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTaiKhoan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(75, 65);
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Image = global::QLDongHo.Properties.Resources.customer;
            this.btnKhachHang.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnKhachHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(113, 65);
            this.btnKhachHang.Text = "DS Khách hàng";
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 68);
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.Image = global::QLDongHo.Properties.Resources.help32;
            this.btnHuongDan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHuongDan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(88, 65);
            this.btnHuongDan.Text = "Hướng dẫn";
            this.btnHuongDan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHuongDan.Click += new System.EventHandler(this.btnHuongDan_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.Image = global::QLDongHo.Properties.Resources.information;
            this.btnThongTin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnThongTin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(151, 65);
            this.btnThongTin.Text = "Thông tin phần mềm";
            this.btnThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 68);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QLDongHo.Properties.Resources.exit;
            this.btnThoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 65);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTrangThai,
            this.toolThoiGian});
            this.statusStrip1.Location = new System.Drawing.Point(0, 470);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1275, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.Color.Blue;
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(0, 20);
            // 
            // toolThoiGian
            // 
            this.toolThoiGian.Name = "toolThoiGian";
            this.toolThoiGian.Size = new System.Drawing.Size(151, 20);
            this.toolThoiGian.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLDongHo.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1275, 496);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Quản lý cửa hàng đồng hồ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuDongHo;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuDSDongHo;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuHuongDan;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTin;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDangNhap;
        private System.Windows.Forms.ToolStripButton btnDangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnDongHo;
        private System.Windows.Forms.ToolStripButton btnThuongHieu;
        private System.Windows.Forms.ToolStripButton btnLoai;
        private System.Windows.Forms.ToolStripButton btnDuongKinh;
        private System.Windows.Forms.ToolStripButton btnHoaDon;
        private System.Windows.Forms.ToolStripButton btnNhanVien;
        private System.Windows.Forms.ToolStripButton btnTaiKhoan;
        private System.Windows.Forms.ToolStripButton btnKhachHang;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnHuongDan;
        private System.Windows.Forms.ToolStripButton btnThongTin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuLoai;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuDuongKinh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolThoiGian;
        private System.Windows.Forms.ToolStripMenuItem mnuSaoLuu;
        private System.Windows.Forms.ToolStripMenuItem mnuKhoiPhucc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnuDSHD;
    }
}