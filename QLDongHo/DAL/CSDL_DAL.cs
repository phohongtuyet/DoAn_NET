using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDongHo.DAL
{
    public class CSDL_DAL
    {
        Connect db = new Connect();
        SqlCommand cmd = new SqlCommand();
        static SqlConnection con;

        public void  SaoLuuDuLieu(string sDuongDan)
        {
            string sTen = "\\DoAnQLBDongHo(" + DateTime.Now.Day.ToString() + "_" +
            DateTime.Now.Month.ToString() + "_" +
            DateTime.Now.Year.ToString() + "_" +
            DateTime.Now.Hour.ToString() + "_" +
            DateTime.Now.Minute.ToString() + ").bak";
            string sql = "BACKUP DATABASE DoAnQLBDongHo TO DISK = N'" + sDuongDan + sTen + "'";
            SqlCommand sqlCmd = new SqlCommand(sql);
            db.ExecuteQuery(sqlCmd);    
            
        }

        public void PhucHoiDuLieu(string sDuongDan)
        {
            /*
            SqlCommand cmd1 = new SqlCommand("ALTER DATABASE [DoAnQLDongHo ] SET SINGLE_USER WITH ROLLBACK IMMEDIATE ;");        
            db.ExecuteQuery(cmd1);

            SqlCommand cmd2 = new SqlCommand("USE MASTER RESTORE DATABASE [DoAnQLDongHo] FROM DISK='" + sDuongDan + "' WITH RECOVERY;");
            db.ExecuteQuery(cmd2);

            SqlCommand cmd3 = new SqlCommand("ALTER DATABASE [DoAnQLDongHo] SET MULTI_USER;");
            db.ExecuteQuery(cmd3);

            con.Close();*/

            string sql = "Use Master ALTER DATABASE DoAnQLBDongHo SET OFFLINE WITH ROLLBACK IMMEDIATE; RESTORE DATABASE DoAnQLBDongHo FROM DISK ='" + sDuongDan + "' ;ALTER DATABASE DoAnQLBDongHo SET ONLINE WITH ROLLBACK IMMEDIATE;";
            SqlCommand sqlCmd = new SqlCommand(sql);
            db.ExecuteQuery(sqlCmd);
            //String sqlquery = "Use Master ALTER DATABASE DoAnQLBDongHo SET OFFLINE WITH ROLLBACK IMMEDIATE RESTORE DATABASE DoAnQsqlLBDongHo FROM DISK ='" + sDuongDan + "' ALTER DATABASE DoAnQLBDongHo SET ONLINE WITH ROLLBACK IMMEDIATE";
            //String sqlquery = "RESTORE DATABASE DoAnQLBDongHo FROM DISK ='" + sDuongDan + "' WITH REPLACE,RECOVERY";
            //SqlCommand Cmd = new SqlCommand(sqlquery);
           // db.ExecuteQuery(Cmd);

            //string sqlquery = "Use Master RESTORE DATABASE DoAnQLBDongHo FROM DISK =N'" + sDuongDan + "'WITH REPLACE";
           // SqlCommand Cmd = new SqlCommand(sqlquery);
            //db.ExecuteQuery(Cmd);


        }
    }
}

