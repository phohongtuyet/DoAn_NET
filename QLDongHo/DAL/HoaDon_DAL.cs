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
    public class HoaDon_DAL
    {
        Connect db = new Connect();
        SqlCommand cmd = new SqlCommand();

        public DataTable DanhSach()
        {
            string sql = "SELECT h.*, n.HoVaTen NhanVien, k.HoVaten KhachHang FROM((HoaDon h INNER JOIN NhanVien n ON h.NhanVien_ID = n.ID)INNER JOIN KhachHang k ON h.KhachHang_ID = k.ID)";
            SqlCommand sqlCmd = new SqlCommand(sql);
            db.ExecuteQuery(sqlCmd);
            return db;
        }

        public void Them(HoaDon_DTO info)
        {
            string sql = "INSERT INTO HoaDon VALUES(@MaHD,@NhanVien_ID,@KhachHang_ID,@NgayLapHoaDon)";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@MaHD", SqlDbType.VarChar, 5).Value = info.MaHD;
            sqlCmd.Parameters.Add("@NhanVien_ID", SqlDbType.Int).Value = info.NhanVien_ID;
            sqlCmd.Parameters.Add("@KhachHang_ID", SqlDbType.Int).Value = info.KhachHang_ID1;
            sqlCmd.Parameters.Add("@NgayLapHoaDon", SqlDbType.DateTime).Value = info.NgayLap;
            sqlCmd.CommandTimeout = 30;
            db.ExecuteNoneQuery(sqlCmd);
        }

        public void CapNhat(HoaDon_DTO info,string oldValue)
        {
            string sql = "UPDATE HoaDon SET NhanVien_ID = @NhanVien_ID, KhachHang_ID=@KhachHang_ID, NgayLapHoaDon=@NgayLapHoaDon WHERE MaHD = @MaHDCu";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@MaHD", SqlDbType.VarChar, 5).Value = info.MaHD;
            sqlCmd.Parameters.Add("@NhanVien_ID", SqlDbType.Int).Value = info.NhanVien_ID;
            sqlCmd.Parameters.Add("@KhachHang_ID", SqlDbType.Int).Value = info.KhachHang_ID1;
            sqlCmd.Parameters.Add("@NgayLapHoaDon", SqlDbType.DateTime).Value = info.NgayLap;
            sqlCmd.Parameters.Add("@MaHDCu", SqlDbType.Int).Value = oldValue;
            db.ExecuteNoneQuery(sqlCmd);
        }

        public void Xoa(HoaDon_DTO info)
        {
            string sql = "DELETE FROM HoaDon WHERE MaHD = @MaHD";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@MaHD", SqlDbType.VarChar, 5).Value = info.MaHD;
            db.ExecuteNoneQuery(sqlCmd);
        }

        public DataTable KiemTraTrung(string dieuKien)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from HoaDon " + dieuKien;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = db.Connection;
            try
            {
                db.OpenConnect();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                //sda.SelectCommand.CommandTimeout = 0;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                db.CloseConn();
            }
            return dt;
        }
    }
}
