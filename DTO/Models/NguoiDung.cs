﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class NguoiDung
	{
		public int MaNguoiDung { get; set; }
		public string TenDangNhap { get; set; }
		public string MatKhau { get; set; }
		public string HoTen { get; set; }
		public string Email { get; set; }
		public string SoDienThoai { get; set; }
		public string VaiTro { get; set; }
		public string Avatar { get; set; }
		public string MatKhauCu { get; set; }
		public DateTime? NgayDoiMatKhau { get; set; }
		public int SoLanDangNhapSai { get; set; }
		public DateTime? NgayKhoa { get; set; }
		public string LyDoKhoa { get; set; }
		public bool TrangThai { get; set; }
		public DateTime NgayTao { get; set; }
		public DateTime? NgayCapNhat { get; set; }
	}
}
