using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDongHo.DAL;
using QLDongHo.DTO;
using QLDongHo.GUI;

namespace QLDongHo.BUS
{
   public class TaiKhoan_BUS
    {
        TaiKhoan_DAL data = new TaiKhoan_DAL();

        public void HienThiVaoDGV(DataGridView dGV, BindingNavigator bN,
                                    TextBox txtID,
                                    TextBox txtTaiKhoan,
                                    TextBox txtMatKhau,

                                    ComboBox cboNhanVien,
                                    ComboBox cboQuyen)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = data.DanhSach();

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", bS, "ID", false, DataSourceUpdateMode.Never);

            txtTaiKhoan.DataBindings.Clear();
            txtTaiKhoan.DataBindings.Add("Text", bS, "taikhoan", false, DataSourceUpdateMode.Never);

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", bS, "matkhau", false, DataSourceUpdateMode.Never);


            cboNhanVien.DataBindings.Clear();
            cboNhanVien.DataBindings.Add("SelectedValue", bS, "NhanVien_ID", false, DataSourceUpdateMode.Never);

            cboQuyen.DataBindings.Clear();
            cboQuyen.DataBindings.Add("SelectedIndex", bS, "quyen", false, DataSourceUpdateMode.Never);

            dGV.AutoGenerateColumns = false;
            dGV.DataSource = bS;
            bN.BindingSource = bS;
        }

        public void Them(TaiKhoan_DTO info)
        {
            data.Them(info);
        }

        public void Xoa(TaiKhoan_DTO info)
        {
            data.Xoa(info);
        }

        public void capNhat(TaiKhoan_DTO info,string oldValue)
        {
            data.CapNhat(info, oldValue);
        }

        public bool DangNhap (string taikhoannv, string matkhau)
        {
           MD5 md5Hash = MD5.Create();
           string matkhauMH = GetMd5Hash(md5Hash, matkhau);

            var taiKhoan = data.ChiTiet(taikhoannv, matkhauMH);

            if (taiKhoan.Rows.Count > 0)
            {
                frmMain.hoVaTen = taiKhoan.Rows[0]["NhanVien"].ToString();
                frmMain.quyenHan = Convert.ToInt32(taiKhoan.Rows[0]["quyen"]);

                return true;
            }
            else
                return false;
        }
        //ma hoa MD5
        public string GetMd5Hash(MD5 md5Hash, string input)
        {

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
