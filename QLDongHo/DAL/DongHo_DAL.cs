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
    public class DongHo_DAL
    {
        Connect db = new Connect();
        SqlCommand cmd = new SqlCommand();
        public DataTable DanhSach()
        {
            string sql = "SELECT dh.*,th.TenThuongHieu ThuongHieu, dk.SoKichThuocMat DuongKinhMat,l.TenLoai Loai FROM (((DongHo dh INNER JOIN ThuongHieu th ON dh.ThuongHieu_ID = th.ID) INNER JOIN Loai l ON dh.Loai_ID=l.ID) INNER JOIN DuongKinhMat dk ON dh.DuongKichMat_ID=dk.ID) ";
            SqlCommand sqlCmd = new SqlCommand(sql);
            db.ExecuteQuery(sqlCmd);
            return db;
        }

        public DataTable TimKiem(string tuKhoa)
        {
            string sql = "SELECT dh.*,th.TenThuongHieu ThuongHieu, dk.SoKichThuocMat DuongKinhMat,l.TenLoai Loai FROM (((DongHo dh INNER JOIN ThuongHieu th ON dh.ThuongHieu_ID = th.ID) INNER JOIN Loai l ON dh.Loai_ID=l.ID) INNER JOIN DuongKinhMat dk ON dh.DuongKichMat_ID=dk.ID)WHERE dh.TenDongHo LIKE '%' + @TuKhoa + '%'";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Add("@TuKhoa", SqlDbType.NVarChar,255).Value = tuKhoa;
            db.ExecuteQuery(sqlCmd);
            return db;        
        }

        

        public void Them(DongHo_DTO info)
        {
            string sql = "INSERT INTO DongHo VALUES(@ThuongHieu_ID,@Loai_ID,@DuongKichMat_ID,@GioiTinh,@TenDongHo,@DonGia,@GiaBan,@SoLuong)";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@ThuongHieu_ID", SqlDbType.Int).Value = info.ThuongHieu_ID;
            sqlCmd.Parameters.Add("@Loai_ID", SqlDbType.Int).Value = info.Loai_ID;
            sqlCmd.Parameters.Add("@DuongKichMat_ID", SqlDbType.Int).Value = info.DuongKinhMat_ID;
            sqlCmd.Parameters.Add("@GioiTinh", SqlDbType.Char, 1).Value = info.GioiTinh;
            sqlCmd.Parameters.Add("@TenDongHo", SqlDbType.NVarChar,255).Value = info.TenDongHo;
            sqlCmd.Parameters.Add("@DonGia", SqlDbType.Int).Value = info.DonGia;
            sqlCmd.Parameters.Add("@GiaBan", SqlDbType.Int).Value = info.GiaBan;
            sqlCmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = info.SoLuong;
            db.ExecuteNoneQuery(sqlCmd);
        }

        public void CapNhat(DongHo_DTO info,string oldValue)
        {
            string sql = "UPDATE DongHo SET ThuongHieu_ID = @ThuongHieu_ID,Loai_ID=@Loai_ID,DuongKichMat_ID=@DuongKichMat_ID,GioiTinh=@GioiTinh,TenDongHo=@TenDongHo,DonGia=@DonGia,GiaBan=@GiaBan,SoLuong=@SoLuong WHERE ID = @IDCu";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
           
            sqlCmd.Parameters.Add("@ThuongHieu_ID", SqlDbType.Int).Value = info.ThuongHieu_ID;
            sqlCmd.Parameters.Add("@Loai_ID", SqlDbType.Int).Value = info.Loai_ID;
            sqlCmd.Parameters.Add("@DuongKichMat_ID", SqlDbType.Int).Value = info.DuongKinhMat_ID;
            sqlCmd.Parameters.Add("@GioiTinh", SqlDbType.Char, 1).Value = info.GioiTinh;
            sqlCmd.Parameters.Add("@TenDongHo", SqlDbType.NVarChar, 255).Value = info.TenDongHo;
            sqlCmd.Parameters.Add("@DonGia", SqlDbType.Int).Value = info.DonGia;
            sqlCmd.Parameters.Add("@GiaBan", SqlDbType.Int).Value = info.GiaBan;
            sqlCmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = info.SoLuong;
            sqlCmd.Parameters.Add("@IDCu", SqlDbType.Int).Value = oldValue;
            db.ExecuteNoneQuery(sqlCmd);
        }

        public void Xoa(DongHo_DTO info)
        {
            string sql = "DELETE FROM DongHo WHERE ID = @ID";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@ID", SqlDbType.Int).Value = info.ID1;
            db.ExecuteNoneQuery(sqlCmd);
        }
       


        public DataTable DanhSach(string dieuKien)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from DongHo " + dieuKien;
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

        public bool UpdSL(string ID, int SL)
        {
            cmd.CommandText = "Update DongHo set  SoLuong = " + SL + " Where ID = '" + ID + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = db.Connection;
            try
            {
                db.OpenConnect();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                db.CloseConn();
            }
            return false;
        }

       
    }
}
