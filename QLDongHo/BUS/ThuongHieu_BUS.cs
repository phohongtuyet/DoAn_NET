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
   public class ThuongHieu_BUS
    {
        ThuongHieu_DAL data = new ThuongHieu_DAL();

        public void HienThiVaoDGV(DataGridView dGV,
                                  BindingNavigator bN,
                                  TextBox txtID,
                                  TextBox txtTenThuongHieu)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = data.DanhSach();

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bS, "ID", false, DataSourceUpdateMode.Never);

            txtTenThuongHieu.DataBindings.Clear();
            txtTenThuongHieu.DataBindings.Add("Text", bS, "TenThuongHieu", false, DataSourceUpdateMode.Never);

            dGV.DataSource = bS;
            bN.BindingSource = bS;
        }

        public void HienThiVaoComboBox(ComboBox cboBox)
        {
            cboBox.DataSource = data.DanhSach();
            cboBox.ValueMember = "ID";
            cboBox.DisplayMember = "TenThuongHieu";
        }

        public void Them(ThuongHieu_DTO info)
        {
            data.Them(info);
        }

        public void CapNhat(ThuongHieu_DTO info, string oldValue)
        {
            data.CapNhat(info, oldValue);
        }

        public void Xoa(ThuongHieu_DTO info)
        {
            data.Xoa(info);
        }
    }
}
