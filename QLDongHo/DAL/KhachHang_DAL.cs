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
    public class KhachHang_DAL
    {
        Connect db = new Connect();

        public DataTable DanhSach()
        {
            string sql = "SELECT * FROM KhachHang";
            SqlCommand sqlCmd = new SqlCommand(sql);
            db.ExecuteQuery(sqlCmd);
            return db;
        }

        public DataTable TimKiem(string tuKhoa)
        {
            string sql = "SELECT * FROM KhachHang WHERE HoVaTen LIKE '%' + @TuKhoa + '%'";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Add("@TuKhoa", SqlDbType.NVarChar, 255).Value = tuKhoa;
            db.ExecuteQuery(sqlCmd);
            return db;
        }

        public void Them(KhachHang_DTO info)
        {
            string sql = "INSERT INTO KhachHang VALUES(@HoVaTen,@DienThoai,@DiaChi)";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@HoVaTen", SqlDbType.NVarChar, 100).Value = info.HoVaTen;
            sqlCmd.Parameters.Add("@DienThoai", SqlDbType.VarChar, 20).Value = info.DienThoai;
            sqlCmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 255).Value = info.DiaChi;
            db.ExecuteNoneQuery(sqlCmd);
        }

        public void CapNhat(KhachHang_DTO info,string oldValue)
        {
            string sql = "UPDATE KhachHang SET HoVaTen = @HoVaTen,DienThoai=@DienThoai,DiaChi=@DiaChi WHERE ID = @IDCu";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@HoVaTen", SqlDbType.NVarChar, 100).Value = info.HoVaTen;
            sqlCmd.Parameters.Add("@DienThoai", SqlDbType.VarChar, 20).Value = info.DienThoai;
            sqlCmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 255).Value = info.DiaChi;
            sqlCmd.Parameters.Add("@IDCu", SqlDbType.Int).Value = oldValue;
            db.ExecuteNoneQuery(sqlCmd);
        }

        public void Xoa(KhachHang_DTO info)
        {
            string sql = "DELETE FROM KhachHang WHERE ID = @ID";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@ID", SqlDbType.Int).Value = info.Id1;
            db.ExecuteNoneQuery(sqlCmd);
        }
    }
}
