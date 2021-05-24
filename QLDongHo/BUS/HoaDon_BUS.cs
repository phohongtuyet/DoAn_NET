using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDongHo.DAL;
using QLDongHo.DTO;

namespace QLDongHo.BUS
{
   public class HoaDon_BUS
    {
        HoaDon_DAL data = new HoaDon_DAL();

        public void HienThiVaoDGV(DataGridView dGV,
                                  BindingNavigator bN,
                                  TextBox txtMaHD,
                                  ComboBox cboNhanVien,
                                  ComboBox cboKhachHang,
                                  DateTimePicker dtpNgayLap)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = data.DanhSach();

            txtMaHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add("Text", bS, "MaHD", false, DataSourceUpdateMode.Never);

            cboNhanVien.DataBindings.Clear();
            cboNhanVien.DataBindings.Add("SelectedValue", bS, "NhanVien_ID", false, DataSourceUpdateMode.Never);

            cboKhachHang.DataBindings.Clear();
            cboKhachHang.DataBindings.Add("SelectedValue", bS, "KhachHang_ID", false, DataSourceUpdateMode.Never);
        
            dtpNgayLap.DataBindings.Clear();
            dtpNgayLap.DataBindings.Add("Value", bS, "NgayLapHoaDon", false, DataSourceUpdateMode.Never);

            dGV.DataSource = bS;
            bN.BindingSource = bS;
        }

        public void HienThiVaoComboBox(ComboBox cboBox)
        {
            cboBox.DataSource = data.DanhSach();
            cboBox.ValueMember = "MaHD";
            cboBox.DisplayMember = "MaHD";
        }

        public void Them(HoaDon_DTO info)
        {
            data.Them(info);
        }

        public void CapNhat(HoaDon_DTO info, string oldValue)
        {
            data.CapNhat(info, oldValue);
        }

        public void Xoa(HoaDon_DTO info)
        {
            data.Xoa(info);
        }
        public DataTable kiemTraTrung(string dieuKien)
        {
            return data.KiemTraTrung(dieuKien);
        }
    }
}
