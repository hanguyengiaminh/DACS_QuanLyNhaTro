using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ViewModels
{
	public class ThongTinTaiKhoanViewModel
	{
		public int MaNguoiDung { get; set; }
		public string TenDangNhap { get; set; }
		public string HoTen { get; set; }
		public string Email { get; set; }
		public string SoDienThoai { get; set; }
		public string VaiTro { get; set; }
		public string Avatar { get; set; }
		public bool TrangThai { get; set; }
	}
}
