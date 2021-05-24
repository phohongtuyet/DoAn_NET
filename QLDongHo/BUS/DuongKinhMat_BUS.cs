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
   public class DuongKinhMat_BUS
    {
        DuongKinhMat_DAL data = new DuongKinhMat_DAL();

        public void HienThiVaoDGV(DataGridView dGV,
                                  BindingNavigator bN,
                                  TextBox txtID,
                                  NumericUpDown nupDk)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = data.DanhSach();

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bS, "ID", false, DataSourceUpdateMode.Never);

            nupDk.DataBindings.Clear();
            nupDk.DataBindings.Add("value", bS, "SoKichThuocMat", false, DataSourceUpdateMode.Never);

            dGV.DataSource = bS;
            bN.BindingSource = bS;
        }

        public void HienThiVaoComboBox(ComboBox cboBox)
        {
            cboBox.DataSource = data.DanhSach();
            cboBox.ValueMember = "ID";
            cboBox.DisplayMember = "SoKichThuocMat";
        }

        public void Them(DuongKinhMat_DTO info)
        {
            data.Them(info);
        }

        public void CapNhat(DuongKinhMat_DTO info, string oldValue)
        {
            data.CapNhat(info, oldValue);
        }

        public void Xoa(DuongKinhMat_DTO info)
        {
            data.Xoa(info);
        }
    }
}
