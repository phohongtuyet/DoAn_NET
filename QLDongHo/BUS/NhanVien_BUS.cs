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
   public class NhanVien_BUS
    {
        NhanVien_DAL data = new NhanVien_DAL();

        public void HienThiVaoDGV(DataGridView dGV,
                                  BindingNavigator bN,
                                  TextBox txtID,
                                  TextBox txtHoVaTen,
                                  TextBox txtDienThoai,
                                  TextBox txtDiaChi,
                                  DateTimePicker dtpNgaySinh,
                                  CheckBox chkGioiTinh)
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

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Value", bS, "NgaySinh", false, DataSourceUpdateMode.Never);

            chkGioiTinh.DataBindings.Clear();
            Binding gt = new Binding("Checked", bS, "GioiTinh", false, DataSourceUpdateMode.Never);
            gt.Format += (s, e) =>
            {
                e.Value = (string)e.Value == "F";
            };
            chkGioiTinh.DataBindings.Add(gt);

            dGV.DataSource = bS;
            bN.BindingSource = bS;
        }

        public void HienThiVaoComboBox(ComboBox cboBox)
        {
            cboBox.DataSource = data.DanhSach();
            cboBox.ValueMember = "ID";
            cboBox.DisplayMember = "HoVaTen";
        }

        public void Them(NhanVien_DTO info)
        {
            data.Them(info);
        }

        public void CapNhat(NhanVien_DTO info, string oldValue)
        {
            data.CapNhat(info, oldValue);
        }

        public void Xoa(NhanVien_DTO info)
        {
            data.Xoa(info);
        }
    }
}
