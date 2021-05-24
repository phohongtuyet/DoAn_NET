using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLDongHo.DTO;

namespace QLDongHo.DAL
{
    public class TaiKhoan_DAL
    {
        Connect db = new Connect();

        public DataTable DanhSach()
        {
            string sql = "SELECT tk.*, nv.HoVaTen NhanVien FROM(TaiKhoan tk INNER JOIN NhanVien nv ON tk.NhanVien_ID = nv.ID)";
            SqlCommand sqlCmd = new SqlCommand(sql);
            db.ExecuteQuery(sqlCmd);
            return db;
        }
        public DataTable ChiTiet(string maNV, string matKhau)
        {
            string sql = "SELECT tk.*, nv.HoVaTen NhanVien FROM(TaiKhoan tk INNER JOIN NhanVien nv ON tk.NhanVien_ID = nv.ID) where tk.taikhoan = @taikhoan and matkhau = @matkhau ";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Add("@taikhoan", SqlDbType.VarChar, 50).Value = maNV;
            sqlCmd.Parameters.Add("@matkhau", SqlDbType.VarChar, 255).Value = matKhau;
            db.ExecuteQuery(sqlCmd);
            return db;
        }
        public void Them(TaiKhoan_DTO info)
        {
            string sql = "INSERT INTO TaiKhoan VALUES(@NhanVien_ID,@quyen,@taikhoan,@matkhau)";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@NhanVien_ID", SqlDbType.Int).Value = info.NhanVien_ID;
            sqlCmd.Parameters.Add("@quyen", SqlDbType.Int).Value = info.Quyen;
            sqlCmd.Parameters.Add("@taikhoan", SqlDbType.VarChar, 50).Value = info.TaiKhoan;
            sqlCmd.Parameters.Add("@matkhau", SqlDbType.VarChar,255).Value = info.MatKhau;
            db.ExecuteNoneQuery(sqlCmd);
        }

        public void CapNhat(TaiKhoan_DTO info,string oldValue)
        {
            string sql = "UPDATE TaiKhoan SET NhanVien_ID = @NhanVien_ID,quyen=@quyen,taikhoan=@taikhoan,matkhau=@matkhau WHERE ID = @IDCu";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@NhanVien_ID", SqlDbType.Int).Value = info.NhanVien_ID;
            sqlCmd.Parameters.Add("@quyen", SqlDbType.Int).Value = info.Quyen;
            sqlCmd.Parameters.Add("@taikhoan", SqlDbType.VarChar, 50).Value = info.TaiKhoan;
            sqlCmd.Parameters.Add("@matkhau", SqlDbType.VarChar, 255).Value = info.MatKhau;
            sqlCmd.Parameters.Add("@IDCu", SqlDbType.Int).Value = oldValue;
            db.ExecuteNoneQuery(sqlCmd);
        }

        public void Xoa(TaiKhoan_DTO info)
        {
            string sql = "DELETE FROM TaiKhoan WHERE ID = @ID";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@ID", SqlDbType.Int).Value = info.ID1;
            db.ExecuteNoneQuery(sqlCmd);
        }
    }
}
