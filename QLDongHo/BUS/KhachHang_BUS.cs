using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDongHo.DAL;
using QLDongHo.DTO;

namespace QLDongHo.BUS
{
   public class KhachHang_BUS
    {
        KhachHang_DAL data = new KhachHang_DAL();

        public void HienThiVaoDGV(DataGridView dGV,
                                  BindingNavigator bN,
                                  TextBox txtID,
                                  TextBox txtHoVaTen,
                                  TextBox txtDienThoai,
                                  TextBox txtDiaChi)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = data.DanhSach();

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bS, "ID", false, DataSourceUpdateMode.Never);

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bS, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bS, "DienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bS, "DiaChi", false, DataSourceUpdateMode.Never);

            

            dGV.DataSource = bS;
            bN.BindingSource = bS;
        }

        public void HienThiVaoComboBox(ComboBox cboBox)
        {
            cboBox.DataSource = data.DanhSach();
            cboBox.ValueMember = "ID";
            cboBox.DisplayMember = "HoVaTen";
        }

        public void Them(KhachHang_DTO info)
        {
            data.Them(info);
        }

        public void CapNhat(KhachHang_DTO info, string oldValue)
        {
            data.CapNhat(info, oldValue);
        }

        public void Xoa(KhachHang_DTO info)
        {
            data.Xoa(info);
        }

        public void timKiem(string tuKhoa)
        {
            data.TimKiem(tuKhoa);
        }
    }
}
