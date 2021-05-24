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
   public class Loai_BUS
    {
        Loai_DAL data = new Loai_DAL();

        public void HienThiVaoDGV(DataGridView dGV,
                                  BindingNavigator bN,
                                  TextBox txtID,
                                  TextBox txtTenLoai)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = data.DanhSach();

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bS, "ID", false, DataSourceUpdateMode.Never);

            txtTenLoai.DataBindings.Clear();
            txtTenLoai.DataBindings.Add("Text", bS, "TenLoai", false, DataSourceUpdateMode.Never);

            dGV.DataSource = bS;
            bN.BindingSource = bS;
        }

        public void HienThiVaoComboBox(ComboBox cboBox)
        {
            cboBox.DataSource = data.DanhSach();
            cboBox.ValueMember = "ID";
            cboBox.DisplayMember = "TenLoai";
        }

        public void Them(Loai_DTO info)
        {
            data.Them(info);
        }

        public void CapNhat(Loai_DTO info, string oldValue)
        {
            data.CapNhat(info, oldValue);
        }

        public void Xoa(Loai_DTO info)
        {
            data.Xoa(info);
        }
    }
}
