using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
	public class NguoiDungRepository : INguoiDungRepository
	{
		private readonly string connectionString;

		public NguoiDungRepository()
		{
			connectionString = DBConnection.connectionString;
		}

		public NguoiDung GetById(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (var command = new SqlCommand("SELECT * FROM NguoiDung WHERE MaNguoiDung = @MaNguoiDung", connection))
				{
					command.Parameters.AddWithValue("@MaNguoiDung", id);
					using (var reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							return MapNguoiDung(reader);
						}
					}
				}
			}
			return null;
		}

		public NguoiDung GetByTenDangNhap(string tenDangNhap)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (var command = new SqlCommand("SELECT * FROM NguoiDung WHERE TenDangNhap = @TenDangNhap", connection))
				{
					command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
					using (var reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							return MapNguoiDung(reader);
						}
					}
				}
			}
			return null;
		}

		public IEnumerable<NguoiDung> GetAll()
		{
			var nguoiDungs = new List<NguoiDung>();
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (var command = new SqlCommand("SELECT * FROM NguoiDung", connection))
				{
					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							nguoiDungs.Add(MapNguoiDung(reader));
						}
					}
				}
			}
			return nguoiDungs;
		}

		public void Add(NguoiDung nguoiDung)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (var command = new SqlCommand(@"
					INSERT INTO NguoiDung (TenDangNhap, MatKhau, HoTen, Email, SoDienThoai, VaiTro, 
					Avatar, MatKhauCu, NgayDoiMatKhau, SoLanDangNhapSai, NgayKhoa, LyDoKhoa, 
					TrangThai, NgayTao, NgayCapNhat)
					VALUES (@TenDangNhap, @MatKhau, @HoTen, @Email, @SoDienThoai, @VaiTro,
					@Avatar, @MatKhauCu, @NgayDoiMatKhau, @SoLanDangNhapSai, @NgayKhoa, @LyDoKhoa,
					@TrangThai, @NgayTao, @NgayCapNhat)", connection))
				{
					MapParameters(command, nguoiDung);
					command.ExecuteNonQuery();
				}
			}
		}

		public void Update(NguoiDung nguoiDung)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (var command = new SqlCommand(@"
					UPDATE NguoiDung 
					SET TenDangNhap = @TenDangNhap,
						MatKhau = @MatKhau,
						HoTen = @HoTen,
						Email = @Email,
						SoDienThoai = @SoDienThoai,
						VaiTro = @VaiTro,
						Avatar = @Avatar,
						MatKhauCu = @MatKhauCu,
						NgayDoiMatKhau = @NgayDoiMatKhau,
						SoLanDangNhapSai = @SoLanDangNhapSai,
						NgayKhoa = @NgayKhoa,
						LyDoKhoa = @LyDoKhoa,
						TrangThai = @TrangThai,
						NgayCapNhat = @NgayCapNhat
					WHERE MaNguoiDung = @MaNguoiDung", connection))
				{
					MapParameters(command, nguoiDung);
					command.Parameters.AddWithValue("@MaNguoiDung", nguoiDung.MaNguoiDung);
					command.ExecuteNonQuery();
				}
			}
		}

		public void Delete(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (var command = new SqlCommand("DELETE FROM NguoiDung WHERE MaNguoiDung = @MaNguoiDung", connection))
				{
					command.Parameters.AddWithValue("@MaNguoiDung", id);
					command.ExecuteNonQuery();
				}
			}
		}

		public bool CheckTenDangNhapExists(string tenDangNhap)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (var command = new SqlCommand("SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap = @TenDangNhap", connection))
				{
					command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
					return (int)command.ExecuteScalar() > 0;
				}
			}
		}

		public bool CheckEmailExists(string email)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (var command = new SqlCommand("SELECT COUNT(*) FROM NguoiDung WHERE Email = @Email", connection))
				{
					command.Parameters.AddWithValue("@Email", email);
					return (int)command.ExecuteScalar() > 0;
				}
			}
		}

		public bool CheckSoDienThoaiExists(string soDienThoai)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (var command = new SqlCommand("SELECT COUNT(*) FROM NguoiDung WHERE SoDienThoai = @SoDienThoai", connection))
				{
					command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
					return (int)command.ExecuteScalar() > 0;
				}
			}
		}

		public void UpdateMatKhau(int maNguoiDung, string matKhauMoi)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (var command = new SqlCommand(@"
					UPDATE NguoiDung 
					SET MatKhauCu = MatKhau,
						MatKhau = @MatKhauMoi,
						NgayDoiMatKhau = @NgayDoiMatKhau,
						NgayCapNhat = @NgayCapNhat
					WHERE MaNguoiDung = @MaNguoiDung", connection))
				{
					command.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);
					command.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);
					command.Parameters.AddWithValue("@NgayDoiMatKhau", DateTime.Now);
					command.Parameters.AddWithValue("@NgayCapNhat", DateTime.Now);
					command.ExecuteNonQuery();
				}
			}
		}

		public void UpdateTrangThai(int maNguoiDung, bool trangThai)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (var command = new SqlCommand(@"
					UPDATE NguoiDung 
					SET TrangThai = @TrangThai,
						NgayCapNhat = @NgayCapNhat
					WHERE MaNguoiDung = @MaNguoiDung", connection))
				{
					command.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);
					command.Parameters.AddWithValue("@TrangThai", trangThai);
					command.Parameters.AddWithValue("@NgayCapNhat", DateTime.Now);
					command.ExecuteNonQuery();
				}
			}
		}

		public void UpdateSoLanDangNhapSai(int maNguoiDung, int soLan)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (var command = new SqlCommand(@"
					UPDATE NguoiDung 
					SET SoLanDangNhapSai = @SoLan,
						NgayCapNhat = @NgayCapNhat
					WHERE MaNguoiDung = @MaNguoiDung", connection))
				{
					command.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);
					command.Parameters.AddWithValue("@SoLan", soLan);
					command.Parameters.AddWithValue("@NgayCapNhat", DateTime.Now);
					command.ExecuteNonQuery();
				}
			}
		}

		public void UpdateNgayKhoa(int maNguoiDung, DateTime? ngayKhoa, string lyDo)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (var command = new SqlCommand(@"
					UPDATE NguoiDung 
					SET NgayKhoa = @NgayKhoa,
						LyDoKhoa = @LyDoKhoa,
						NgayCapNhat = @NgayCapNhat
					WHERE MaNguoiDung = @MaNguoiDung", connection))
				{
					command.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);
					command.Parameters.AddWithValue("@NgayKhoa", (object)ngayKhoa ?? DBNull.Value);
					command.Parameters.AddWithValue("@LyDoKhoa", (object)lyDo ?? DBNull.Value);
					command.Parameters.AddWithValue("@NgayCapNhat", DateTime.Now);
					command.ExecuteNonQuery();
				}
			}
		}

		private NguoiDung MapNguoiDung(SqlDataReader reader)
		{
			return new NguoiDung
			{
				MaNguoiDung = reader.GetInt32(reader.GetOrdinal("MaNguoiDung")),
				TenDangNhap = reader.GetString(reader.GetOrdinal("TenDangNhap")),
				MatKhau = reader.GetString(reader.GetOrdinal("MatKhau")),
				HoTen = reader.GetString(reader.GetOrdinal("HoTen")),
				Email = reader.GetString(reader.GetOrdinal("Email")),
				SoDienThoai = reader.GetString(reader.GetOrdinal("SoDienThoai")),
				VaiTro = reader.GetString(reader.GetOrdinal("VaiTro")),
				Avatar = reader.IsDBNull(reader.GetOrdinal("Avatar")) ? null : reader.GetString(reader.GetOrdinal("Avatar")),
				MatKhauCu = reader.IsDBNull(reader.GetOrdinal("MatKhauCu")) ? null : reader.GetString(reader.GetOrdinal("MatKhauCu")),
				NgayDoiMatKhau = reader.IsDBNull(reader.GetOrdinal("NgayDoiMatKhau")) ? null : (DateTime?)reader.GetDateTime(reader.GetOrdinal("NgayDoiMatKhau")),
				SoLanDangNhapSai = reader.GetInt32(reader.GetOrdinal("SoLanDangNhapSai")),
				NgayKhoa = reader.IsDBNull(reader.GetOrdinal("NgayKhoa")) ? null : (DateTime?)reader.GetDateTime(reader.GetOrdinal("NgayKhoa")),
				LyDoKhoa = reader.IsDBNull(reader.GetOrdinal("LyDoKhoa")) ? null : reader.GetString(reader.GetOrdinal("LyDoKhoa")),
				TrangThai = reader.GetBoolean(reader.GetOrdinal("TrangThai")),
				NgayTao = reader.GetDateTime(reader.GetOrdinal("NgayTao")),
				NgayCapNhat = reader.IsDBNull(reader.GetOrdinal("NgayCapNhat")) ? null : (DateTime?)reader.GetDateTime(reader.GetOrdinal("NgayCapNhat"))
			};
		}

		private void MapParameters(SqlCommand command, NguoiDung nguoiDung)
		{
			command.Parameters.AddWithValue("@TenDangNhap", nguoiDung.TenDangNhap);
			command.Parameters.AddWithValue("@MatKhau", nguoiDung.MatKhau);
			command.Parameters.AddWithValue("@HoTen", nguoiDung.HoTen);
			command.Parameters.AddWithValue("@Email", nguoiDung.Email);
			command.Parameters.AddWithValue("@SoDienThoai", nguoiDung.SoDienThoai);
			command.Parameters.AddWithValue("@VaiTro", nguoiDung.VaiTro);
			command.Parameters.AddWithValue("@Avatar", (object)nguoiDung.Avatar ?? DBNull.Value);
			command.Parameters.AddWithValue("@MatKhauCu", (object)nguoiDung.MatKhauCu ?? DBNull.Value);
			command.Parameters.AddWithValue("@NgayDoiMatKhau", (object)nguoiDung.NgayDoiMatKhau ?? DBNull.Value);
			command.Parameters.AddWithValue("@SoLanDangNhapSai", nguoiDung.SoLanDangNhapSai);
			command.Parameters.AddWithValue("@NgayKhoa", (object)nguoiDung.NgayKhoa ?? DBNull.Value);
			command.Parameters.AddWithValue("@LyDoKhoa", (object)nguoiDung.LyDoKhoa ?? DBNull.Value);
			command.Parameters.AddWithValue("@TrangThai", nguoiDung.TrangThai);
			command.Parameters.AddWithValue("@NgayTao", nguoiDung.NgayTao);
			command.Parameters.AddWithValue("@NgayCapNhat", (object)nguoiDung.NgayCapNhat ?? DBNull.Value);
		}
	}
}
