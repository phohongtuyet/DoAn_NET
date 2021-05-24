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
   public class DongHo_BUS
    {
        DongHo_DAL data = new DongHo_DAL();

        public void HienThiVaoDGV(DataGridView dGV,
                                  BindingNavigator bN,
                                  TextBox txtID,
                                  TextBox txtTenDongHO,
                                  TextBox txtDonGia,
                                  TextBox txtGiaBan,
                                  CheckBox chkGioiTinh,
                                  ComboBox cboThuongHieu,
                                  ComboBox cboLoai,
                                  ComboBox cboDuongKinh,
                                  NumericUpDown nUDSoLuong)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = data.DanhSach();

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bS, "ID", false, DataSourceUpdateMode.Never);

            txtTenDongHO.DataBindings.Clear();
            txtTenDongHO.DataBindings.Add("Text", bS, "TenDongHo", false, DataSourceUpdateMode.Never);

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", bS, "DonGia", false, DataSourceUpdateMode.Never);

            txtGiaBan.DataBindings.Clear();
            txtGiaBan.DataBindings.Add("Text", bS, "GiaBan", false, DataSourceUpdateMode.Never);

            nUDSoLuong.DataBindings.Clear();
            nUDSoLuong.DataBindings.Add("Value", bS, "SoLuong", false, DataSourceUpdateMode.Never);

            cboDuongKinh.DataBindings.Clear();
            cboDuongKinh.DataBindings.Add("SelectedValue", bS, "DuongKichMat_ID", false, DataSourceUpdateMode.Never);

            cboThuongHieu.DataBindings.Clear();
            cboThuongHieu.DataBindings.Add("SelectedValue", bS, "ThuongHieu_ID", false, DataSourceUpdateMode.Never);

            cboLoai.DataBindings.Clear();
            cboLoai.DataBindings.Add("SelectedValue", bS, "Loai_ID", false, DataSourceUpdateMode.Never);

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
            cboBox.DisplayMember = "TenDongHo";
        }

        public void timKiem(string tuKhoa)
        {
            data.TimKiem(tuKhoa);
        }

        public void Them(DongHo_DTO info)
        {

            data.Them(info);
        }

        public void CapNhat(DongHo_DTO info, string oldValue)
        {
            data.CapNhat(info, oldValue);
        }

        public void Xoa(DongHo_DTO info)
        {
            data.Xoa(info);
        }
        public DataTable DanhSach(string dieuKien)
        {
            return data.DanhSach(dieuKien);
        }
        


        public bool UpdSL(DataTable dt)
        {
            DataTable dthh = new DataTable();
            dthh = data.DanhSach()
                ;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dthh.Rows.Count; j++)
                {
                    if (dt.Rows[i][1].ToString() == dthh.Rows[j][0].ToString())
                    {
                        int SLcu = int.Parse(dthh.Rows[j][8].ToString());
                        int SLmoi = int.Parse(dthh.Rows[j][8].ToString()) - int.Parse(dt.Rows[i][2].ToString());
                        if (!data.UpdSL(dthh.Rows[j][0].ToString(), SLmoi))
                            return false;
                        break;
                    }
                }

            }
            return true;
        }






    }
}
