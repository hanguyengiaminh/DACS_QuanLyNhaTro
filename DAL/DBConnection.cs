using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class DBConnection
	{
		// Chuỗi kết nối, bạn chỉ cần sửa ở đây khi đổi server hoặc database
		public static string connectionString = "Data Source=DESKTOP-2KOCFSE;Initial Catalog=QuanLyNhaTro;Integrated Security=True;TrustServerCertificate=True";

		public static SqlConnection GetConnection()
		{
			return new SqlConnection(connectionString);
		}
	}
}
