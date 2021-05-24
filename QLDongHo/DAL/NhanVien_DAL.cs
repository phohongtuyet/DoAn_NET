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
    public class NhanVien_DAL
    {
        Connect db = new Connect();

        public DataTable DanhSach()
        {
            string sql = "SELECT * FROM NhanVien";
            SqlCommand sqlCmd = new SqlCommand(sql);
            db.ExecuteQuery(sqlCmd);
            return db;
        }

        public void Them(NhanVien_DTO info)
        {
            string sql = "INSERT INTO NhanVien VALUES(@HoVaTen,@DienThoai,@DiaChi,@NgaySinh,@GioiTinh)";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@HoVaTen", SqlDbType.NVarChar, 100).Value = info.HoVaTen;
            sqlCmd.Parameters.Add("@DienThoai", SqlDbType.VarChar, 20).Value = info.DienThoai;
            sqlCmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 255).Value = info.DiaChi;
            sqlCmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = info.NgaySinh;
            sqlCmd.Parameters.Add("@GioiTinh", SqlDbType.VarChar, 1).Value = info.GioiTinh;
            db.ExecuteNoneQuery(sqlCmd);
        }

        public void CapNhat(NhanVien_DTO info,string oldValue)
        {
            string sql = "UPDATE NhanVien SET HoVaTen = @HoVaTen,DienThoai=@DienThoai,DiaChi=@DiaChi,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh WHERE ID = @IDCu";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@HoVaTen", SqlDbType.NVarChar, 100).Value = info.HoVaTen;
            sqlCmd.Parameters.Add("@DienThoai", SqlDbType.VarChar, 20).Value = info.DienThoai;
            sqlCmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 255).Value = info.DiaChi;
            sqlCmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = info.NgaySinh;
            sqlCmd.Parameters.Add("@GioiTinh", SqlDbType.VarChar, 1).Value = info.GioiTinh;
            sqlCmd.Parameters.Add("@IDCu", SqlDbType.Int).Value = oldValue;
            db.ExecuteNoneQuery(sqlCmd);
        }

        public void Xoa(NhanVien_DTO info)
        {
            string sql = "DELETE FROM NhanVien WHERE ID = @ID";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.Add("@ID", SqlDbType.Int).Value = info.Id1;
            db.ExecuteNoneQuery(sqlCmd);
        }
    }
}
