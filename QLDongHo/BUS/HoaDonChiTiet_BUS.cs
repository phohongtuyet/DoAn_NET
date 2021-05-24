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
   public class HoaDonChiTiet_BUS
    {
        HoaDonChiTiet_DAL data = new HoaDonChiTiet_DAL();

        public void HienThiCTVaoDGV(DataGridView dGV, BindingNavigator bN,
                                    TextBox txtMaHD,
                                   TextBox txtDonGia,
                                   Label LabThanhtien,
                                   ComboBox cboDongHo,
                                   TextBox txtsSoLuong)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = data.DanhSach();

            txtMaHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add("Text", bS, "HoaDon_ID", false, DataSourceUpdateMode.Never);

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", bS, "DonGia", false, DataSourceUpdateMode.Never);

            LabThanhtien.DataBindings.Clear();
            LabThanhtien.DataBindings.Add("Text", bS, "ThanhTien", false, DataSourceUpdateMode.Never);

            cboDongHo.DataBindings.Clear();
            cboDongHo.DataBindings.Add("SelectedValue", bS, "DongHo_ID", false, DataSourceUpdateMode.Never);

            txtsSoLuong.DataBindings.Clear();
            txtsSoLuong.DataBindings.Add("Text", bS, "SoLuong", false, DataSourceUpdateMode.Never);

            dGV.AutoGenerateColumns = false;
            dGV.DataSource = bS;
            bN.BindingSource = bS;
        }

        public DataTable getData(string ma)
        {
            return data.DanhSach(ma);
        }
        
        public void Them(HoaDonChiTiet_DTO info)
        {
            data.Them(info);
        }

        public void CapNhat(HoaDonChiTiet_DTO info, string oldValue)
        {
            data.CapNhat(info, oldValue);
        }

        public void Xoa(HoaDonChiTiet_DTO info)
        {
            data.Xoa(info);
        }

        public bool ThemHDCT(DataTable dt)
        {
            return data.themHDCT(dt);
        }
    }
}
