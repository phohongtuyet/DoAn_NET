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
    public class Loai_DAL
    {
        Connect db = new Connect();

        public DataTable DanhSach()
        {
            string sql = "SELECT * FROM Loai";
            SqlCommand sqlCmd = new SqlCommand(sql);
            db.ExecuteQuery(sqlCmd);
            return db;
        }

        public void Them(Loai_DTO info)
        {
            string sql = "INSERT INTO Loai VALUES(@TenLoai)";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@TenLoai", SqlDbType.NVarChar, 255).Value = info.TenLoai;
            db.ExecuteNoneQuery(sqlCmd);
        }

        public void CapNhat(Loai_DTO info,string oldValue)
        {
            string sql = "UPDATE Loai SET TenLoai = @TenLoai WHERE ID = @IDCu";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@TenLoai", SqlDbType.NVarChar, 255).Value = info.TenLoai;
            sqlCmd.Parameters.Add("@IDCu", SqlDbType.Int).Value = oldValue;
            db.ExecuteNoneQuery(sqlCmd);
        }

        public void Xoa(Loai_DTO info)
        {
            string sql = "DELETE FROM Loai WHERE ID = @ID";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@ID", SqlDbType.Int).Value = info.Id1;
            db.ExecuteNoneQuery(sqlCmd);
        }
    }
}
