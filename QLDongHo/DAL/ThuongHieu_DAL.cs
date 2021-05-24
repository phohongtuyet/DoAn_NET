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
    public class ThuongHieu_DAL
    {
        Connect db = new Connect();

        public DataTable DanhSach()
        {
            string sql = "SELECT * FROM ThuongHieu";
            SqlCommand sqlCmd = new SqlCommand(sql);
            db.ExecuteQuery(sqlCmd);
            return db;
        }

        public void Them(ThuongHieu_DTO info)
        {
            string sql = "INSERT INTO ThuongHieu VALUES(@TenThuongHieu)";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@TenThuongHieu", SqlDbType.VarChar, 255).Value = info.TenThuongHieu;
            db.ExecuteNoneQuery(sqlCmd);
        }

        public void CapNhat(ThuongHieu_DTO info,string oldValue)
        {
            string sql = "UPDATE ThuongHieu SET TenThuongHieu = @TenThuongHieu WHERE ID = @IDCu";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@TenThuongHieu", SqlDbType.NVarChar, 255).Value = info.TenThuongHieu;
            sqlCmd.Parameters.Add("@IDCu", SqlDbType.Int).Value = oldValue;
            db.ExecuteNoneQuery(sqlCmd);
        }

        public void Xoa(ThuongHieu_DTO info)
        {
            string sql = "DELETE FROM ThuongHieu WHERE ID = @ID";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@ID", SqlDbType.Int).Value = info.Id1;
            db.ExecuteNoneQuery(sqlCmd);
        }
    }
}
