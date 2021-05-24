using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDongHo.DAL
{
    public class Connect:DataTable
    {
		public static SqlConnection sqlConn;
		private SqlDataAdapter sqlDataAdapter;
		private string _error;
		private static string connString = @"Data Source=.\SQLEXPRESS; Database=DoAnQLBDongHo ;Integrated Security=True;";
		//		private static string connString = @"Data Source=.\SQLEXPRESS; Initial Catalog=DoAnQLDongHo;User=sa; Password=123456;";

		public SqlConnection Connection
		{
			get { return sqlConn; }
		}
		public string Error
		{
			get { return _error; }
			set { _error = value; }
		}
		public bool OpenConnect()
		{
			try
			{
				if (sqlConn == null)
					sqlConn = new SqlConnection(connString);
				if (sqlConn.State == ConnectionState.Closed)
					sqlConn.Open();
				return true;
			}
			catch (SqlException e)
			{
				for (int i = 0; i < e.Errors.Count; i++)
				{
					MessageBox.Show("Không thể kết nối tới server!\n" + "Index #" + i + "\n" + "Message: " + e.Errors[i].Message + "\n" + "LineNumber: " + e.Errors[i].LineNumber.ToString() + "\n" + "Source: " + e.Errors[i].Source + "\n" + "Procedure: " + e.Errors[i].Procedure, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				sqlConn.Close();
				return false;
			}
		}
		public bool CloseConn()
		{
			try
			{
				if (sqlConn.State == ConnectionState.Open)
					sqlConn.Close();
			}
			catch (Exception ex)
			{
				_error = ex.Message;
				return false;
			}
			return true;
		}

		public void ExecuteQuery(SqlCommand sqlCmd)
		{
			if (OpenConnect())
			{
				try
				{
					sqlCmd.Connection = sqlConn;

					sqlDataAdapter = new SqlDataAdapter();
					sqlDataAdapter.SelectCommand = sqlCmd;

					this.Clear();
					sqlDataAdapter.Fill(this);
				}
				catch (SqlException e)
				{
					for (int i = 0; i < e.Errors.Count; i++)
					{
						MessageBox.Show("Không thể thực thi câu lệnh SQL này!\n" + "Index #" + i + "\n" + "Message: " + e.Errors[i].Message + "\n" + "LineNumber: " + e.Errors[i].LineNumber.ToString() + "\n" + "Source: " + e.Errors[i].Source + "\n" + "Procedure: " + e.Errors[i].Procedure, "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		public void ExecuteNoneQuery(SqlCommand sqlCmd)
		{
			if (OpenConnect())
			{
				SqlTransaction sqlTransaction = null;
				try
				{
					sqlTransaction = sqlConn.BeginTransaction();

					sqlCmd.Connection = sqlConn;
					sqlCmd.Transaction = sqlTransaction;
					sqlCmd.ExecuteNonQuery();

					this.AcceptChanges();
					sqlTransaction.Commit();
				}
				catch (SqlException e)
				{
					for (int i = 0; i < e.Errors.Count; i++)
					{
						MessageBox.Show("Không thể thực thi câu lệnh SQL này!\n" + "Index #" + i + "\n" + "Message: " + e.Errors[i].Message + "\n" + "LineNumber: " + e.Errors[i].LineNumber.ToString() + "\n" + "Source: " + e.Errors[i].Source + "\n" + "Procedure: " + e.Errors[i].Procedure, "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					if (sqlTransaction != null)
					{
						sqlTransaction.Rollback();
					}
				
				}
			}
		}

	}

}

