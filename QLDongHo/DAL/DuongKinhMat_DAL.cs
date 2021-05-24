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
    public class DuongKinhMat_DAL
    {
        Connect db = new Connect();

        public DataTable DanhSach()
        {
            string sql = "SELECT * FROM DuongKinhMat";
            SqlCommand sqlCmd = new SqlCommand(sql);
            db.ExecuteQuery(sqlCmd);
            return db;
        }

        public void Them(DuongKinhMat_DTO info)
        {
            string sql = "INSERT INTO DuongKinhMat VALUES(@SoKichThuocMat)";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@SoKichThuocMat", SqlDbType.SmallInt).Value = info.SoKichThuocMat1;
            db.ExecuteNoneQuery(sqlCmd);
        }

        public void CapNhat(DuongKinhMat_DTO info,string oldValue)
        {
            string sql = "UPDATE DuongKinhMat SET SoKichThuocMat = @SoKichThuocMat WHERE ID = @IDCu";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@SoKichThuocMat", SqlDbType.SmallInt).Value = info.SoKichThuocMat1;
            sqlCmd.Parameters.Add("@IDCu", SqlDbType.Int).Value = oldValue;
            db.ExecuteNoneQuery(sqlCmd);
        }

        public void Xoa(DuongKinhMat_DTO info)
        {
            string sql = "DELETE FROM DuongKinhMat WHERE ID = @ID";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@ID", SqlDbType.Int).Value = info.Id1;
            db.ExecuteNoneQuery(sqlCmd);
        }
    }
}
