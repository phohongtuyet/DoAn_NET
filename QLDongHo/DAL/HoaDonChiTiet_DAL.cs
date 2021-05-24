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
    public class HoaDonChiTiet_DAL
    {
        Connect db = new Connect();
        SqlCommand cmd = new SqlCommand();

        public DataTable DanhSach()
        {
            string sql = "SELECT ct.*, hd.MaHD HoaDon, d.TenDongHo DongHo,ct.SoLuong*ct.DonGia as ThanhTien FROM((HoaDon_ChiTiet ct INNER JOIN HoaDon hd ON ct.HoaDon_ID = hd.MaHD)INNER JOIN DongHo d ON ct.DongHo_ID = d.ID)"; 
            SqlCommand sqlCmd = new SqlCommand(sql);
            db.ExecuteQuery(sqlCmd);
            return db;
        }
        
        public DataTable DanhSach(string ma)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"select ct.HoaDon_ID 'Mã HĐ', dh.TenDongHo 'Đồng hồ', ct.SoLuong 'Số lượng', ct.DonGia 'Đơn giá', ct.SoLuong*ct.DonGia 'Thành tiền' from HoaDon_ChiTiet ct, DongHo dh where ct.DongHo_ID = dh.ID and HoaDon_ID = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 30;
            cmd.Connection = db.Connection;
           
            try
            {
                db.OpenConnect();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
               // sda.SelectCommand.CommandTimeout = 0;
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                db.CloseConn();
            }
            return dt;
        }

        public void Them(HoaDonChiTiet_DTO info)
        {
            string sql = "INSERT INTO HoaDon_ChiTiet VALUES(@HoaDon_ID,@DongHo_ID,@SoLuong,@DonGia,@ThanhTien)";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@HoaDon_ID", SqlDbType.VarChar,5).Value = info.HoaDon_ID1;
            sqlCmd.Parameters.Add("@DongHo_ID", SqlDbType.Int).Value = info.DongHo_ID;
            sqlCmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = info.SoLuong;
            sqlCmd.Parameters.Add("@DonGia", SqlDbType.Int).Value = info.DonGia1;
            sqlCmd.Parameters.Add("@ThanhTien", SqlDbType.Int).Value = info.ThanhTien;          
            db.ExecuteNoneQuery(sqlCmd);
        }

        public void CapNhat(HoaDonChiTiet_DTO info,string oldValue)
        {
            string sql = "UPDATE HoaDon_ChiTiet SET HoaDon_ID = @HoaDon_ID,DongHo_ID=@DongHo_ID,SoLuong=@SoLuong,ThanhTien=@ThanhTien WHERE ID = @IDCu";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@HoaDon_ID", SqlDbType.VarChar, 5).Value = info.HoaDon_ID1;
            sqlCmd.Parameters.Add("@DongHo_ID", SqlDbType.Int).Value = info.DongHo_ID;
            sqlCmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = info.SoLuong;
            sqlCmd.Parameters.Add("@DonGia", SqlDbType.Int).Value = info.DonGia1;
            sqlCmd.Parameters.Add("@ThanhTien", SqlDbType.Int).Value = info.ThanhTien;
            sqlCmd.Parameters.Add("@IDCu", SqlDbType.Int).Value = oldValue;
            db.ExecuteNoneQuery(sqlCmd);
        }

        public void Xoa(HoaDonChiTiet_DTO info)
        {
            string sql = "DELETE FROM HoaDon_ChiTiet WHERE ID = @ID";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@ID", SqlDbType.Int).Value = info.ID1;
            db.ExecuteNoneQuery(sqlCmd);
        }
       

        public bool themHDCT(DataTable dt)
        {
            
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string sql = "insert into HoaDon_ChiTiet values ('" + dt.Rows[i][0].ToString() + "','" + dt.Rows[i][1].ToString() + "'," + dt.Rows[i][2].ToString() + "," + dt.Rows[i][3].ToString() + ")";
                    SqlCommand sqlCmd = new SqlCommand(sql);
                    sqlCmd.CommandTimeout = 30;
                    db.ExecuteNoneQuery(sqlCmd);
                }
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
