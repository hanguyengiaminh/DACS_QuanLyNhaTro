using BLL.Interfaces;
using DAL.Interfaces;
using DTO.Constants;
using DTO.ViewModels;
using DTO;
using BLL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BLL.Services
{
	public class NguoiDungService : INguoiDungService
	{
		private readonly INguoiDungRepository _nguoiDungRepository;
		private readonly ILogHoatDongRepository _logRepository;

		public NguoiDungService(
			INguoiDungRepository nguoiDungRepository,
			ILogHoatDongRepository logRepository)
		{
			_nguoiDungRepository = nguoiDungRepository;
			_logRepository = logRepository;
		}

		public NguoiDung GetById(int id)
		{
			return _nguoiDungRepository.GetById(id);
		}

		public NguoiDung GetByTenDangNhap(string tenDangNhap)
		{
			return _nguoiDungRepository.GetByTenDangNhap(tenDangNhap);
		}

		public IEnumerable<NguoiDung> GetAll()
		{
			return _nguoiDungRepository.GetAll();
		}

		public void Add(NguoiDung nguoiDung)
		{
			// Validate
			if (!ValidateEmail(nguoiDung.Email))
				throw new BusinessException("Email không hợp lệ");
			if (!ValidateSoDienThoai(nguoiDung.SoDienThoai))
				throw new BusinessException("Số điện thoại không hợp lệ");
			if (!ValidateMatKhau(nguoiDung.MatKhau))
				throw new BusinessException("Mật khẩu không hợp lệ");

			// Check unique
			if (_nguoiDungRepository.CheckTenDangNhapExists(nguoiDung.TenDangNhap))
				throw new BusinessException("Tên đăng nhập đã tồn tại");
			if (_nguoiDungRepository.CheckEmailExists(nguoiDung.Email))
				throw new BusinessException("Email đã tồn tại");
			if (_nguoiDungRepository.CheckSoDienThoaiExists(nguoiDung.SoDienThoai))
				throw new BusinessException("Số điện thoại đã tồn tại");

			// Add
			nguoiDung.MatKhau = HashPassword(nguoiDung.MatKhau);
			nguoiDung.NgayTao = DateTime.Now;
			_nguoiDungRepository.Add(nguoiDung);

			// Log
			_logRepository.GhiLog("Thêm", "NguoiDung", nguoiDung.MaNguoiDung, null, nguoiDung);
		}

		public void Update(NguoiDung nguoiDung)
		{
			var existing = _nguoiDungRepository.GetById(nguoiDung.MaNguoiDung);
			if (existing == null)
				throw new BusinessException("Không tìm thấy người dùng");

			// Validate
			if (!ValidateEmail(nguoiDung.Email))
				throw new BusinessException("Email không hợp lệ");
			if (!ValidateSoDienThoai(nguoiDung.SoDienThoai))
				throw new BusinessException("Số điện thoại không hợp lệ");

			// Check unique
			if (nguoiDung.Email != existing.Email &&
				_nguoiDungRepository.CheckEmailExists(nguoiDung.Email))
				throw new BusinessException("Email đã tồn tại");
			if (nguoiDung.SoDienThoai != existing.SoDienThoai &&
				_nguoiDungRepository.CheckSoDienThoaiExists(nguoiDung.SoDienThoai))
				throw new BusinessException("Số điện thoại đã tồn tại");

			// Update
			nguoiDung.NgayCapNhat = DateTime.Now;
			_nguoiDungRepository.Update(nguoiDung);

			// Log
			_logRepository.GhiLog("Sửa", "NguoiDung", nguoiDung.MaNguoiDung, existing, nguoiDung);
		}

		public void Delete(int id)
		{
			var nguoiDung = _nguoiDungRepository.GetById(id);
			if (nguoiDung == null)
				throw new BusinessException("Không tìm thấy người dùng");

			_nguoiDungRepository.Delete(id);

			// Log
			_logRepository.GhiLog("Xóa", "NguoiDung", id, nguoiDung, null);
		}

		public bool DangNhap(string tenDangNhap, string matKhau)
		{
			var nguoiDung = _nguoiDungRepository.GetByTenDangNhap(tenDangNhap);
			if (nguoiDung == null)
				return false;

			if (!nguoiDung.TrangThai)
				throw new BusinessException("Tài khoản đã bị khóa");

			if (nguoiDung.NgayKhoa.HasValue)
				throw new BusinessException("Tài khoản đã bị khóa do đăng nhập sai nhiều lần");

			if (nguoiDung.MatKhau != HashPassword(matKhau))
			{
				nguoiDung.SoLanDangNhapSai++;
				if (nguoiDung.SoLanDangNhapSai >= Constants.MAX_LOGIN_ATTEMPTS)
				{
					nguoiDung.NgayKhoa = DateTime.Now;
					nguoiDung.LyDoKhoa = "Đăng nhập sai quá số lần cho phép";
				}
				_nguoiDungRepository.Update(nguoiDung);
				return false;
			}

			nguoiDung.SoLanDangNhapSai = 0;
			_nguoiDungRepository.Update(nguoiDung);
			return true;
		}

		public void DoiMatKhau(int maNguoiDung, string matKhauCu, string matKhauMoi)
		{
			var nguoiDung = _nguoiDungRepository.GetById(maNguoiDung);
			if (nguoiDung == null)
				throw new BusinessException("Không tìm thấy người dùng");

			if (nguoiDung.MatKhau != HashPassword(matKhauCu))
				throw new BusinessException("Mật khẩu cũ không đúng");

			if (!ValidateMatKhau(matKhauMoi))
				throw new BusinessException("Mật khẩu mới không hợp lệ");

			_nguoiDungRepository.UpdateMatKhau(maNguoiDung, HashPassword(matKhauMoi));

			// Log
			_logRepository.GhiLog("Đổi mật khẩu", "NguoiDung", maNguoiDung, null, null);
		}

		public void CapNhatThongTin(ThongTinTaiKhoanViewModel model)
		{
			var nguoiDung = _nguoiDungRepository.GetById(model.MaNguoiDung);
			if (nguoiDung == null)
				throw new BusinessException("Không tìm thấy người dùng");

			// Validate
			if (!ValidateEmail(model.Email))
				throw new BusinessException("Email không hợp lệ");
			if (!ValidateSoDienThoai(model.SoDienThoai))
				throw new BusinessException("Số điện thoại không hợp lệ");

			// Check unique
			if (model.Email != nguoiDung.Email &&
				_nguoiDungRepository.CheckEmailExists(model.Email))
				throw new BusinessException("Email đã tồn tại");
			if (model.SoDienThoai != nguoiDung.SoDienThoai &&
				_nguoiDungRepository.CheckSoDienThoaiExists(model.SoDienThoai))
				throw new BusinessException("Số điện thoại đã tồn tại");

			// Update
			nguoiDung.HoTen = model.HoTen;
			nguoiDung.Email = model.Email;
			nguoiDung.SoDienThoai = model.SoDienThoai;
			nguoiDung.Avatar = model.Avatar;
			nguoiDung.NgayCapNhat = DateTime.Now;

			_nguoiDungRepository.Update(nguoiDung);

			// Log
			_logRepository.GhiLog("Cập nhật thông tin", "NguoiDung", model.MaNguoiDung, null, nguoiDung);
		}

		public void KhoaTaiKhoan(int maNguoiDung, string lyDo)
		{
			var nguoiDung = _nguoiDungRepository.GetById(maNguoiDung);
			if (nguoiDung == null)
				throw new BusinessException("Không tìm thấy người dùng");

			nguoiDung.TrangThai = false;
			nguoiDung.LyDoKhoa = lyDo;
			nguoiDung.NgayCapNhat = DateTime.Now;

			_nguoiDungRepository.Update(nguoiDung);

			// Log
			_logRepository.GhiLog("Khóa tài khoản", "NguoiDung", maNguoiDung, null, nguoiDung);
		}

		public void MoKhoaTaiKhoan(int maNguoiDung)
		{
			var nguoiDung = _nguoiDungRepository.GetById(maNguoiDung);
			if (nguoiDung == null)
				throw new BusinessException("Không tìm thấy người dùng");

			nguoiDung.TrangThai = true;
			nguoiDung.LyDoKhoa = null;
			nguoiDung.NgayKhoa = null;
			nguoiDung.SoLanDangNhapSai = 0;
			nguoiDung.NgayCapNhat = DateTime.Now;

			_nguoiDungRepository.Update(nguoiDung);

			// Log
			_logRepository.GhiLog("Mở khóa tài khoản", "NguoiDung", maNguoiDung, null, nguoiDung);
		}

		public bool ValidateMatKhau(string matKhau)
		{
			if (string.IsNullOrEmpty(matKhau))
				return false;

			// Ít nhất 8 ký tự
			if (matKhau.Length < 8)
				return false;

			// Ít nhất 1 chữ hoa
			if (!matKhau.Any(char.IsUpper))
				return false;

			// Ít nhất 1 chữ thường
			if (!matKhau.Any(char.IsLower))
				return false;

			// Ít nhất 1 số
			if (!matKhau.Any(char.IsDigit))
				return false;

			// Ít nhất 1 ký tự đặc biệt
			if (!matKhau.Any(c => !char.IsLetterOrDigit(c)))
				return false;

			return true;
		}

		public bool ValidateEmail(string email)
		{
			if (string.IsNullOrEmpty(email))
				return false;

			try
			{
				var addr = new System.Net.Mail.MailAddress(email);
				return addr.Address == email;
			}
			catch
			{
				return false;
			}
		}

		public bool ValidateSoDienThoai(string soDienThoai)
		{
			if (string.IsNullOrEmpty(soDienThoai))
				return false;

			// Chỉ chứa số và có độ dài 10-11 ký tự
			return soDienThoai.All(char.IsDigit) &&
				   soDienThoai.Length >= 10 &&
				   soDienThoai.Length <= 11;
		}

		private string HashPassword(string password)
		{
			using (SHA256 sha256Hash = SHA256.Create())
			{
				// Convert the input string to a byte array and compute the hash.
				byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

				// Create a new StringBuilder to collect the bytes
				// and create a string.
				StringBuilder sBuilder = new StringBuilder();

				// Loop through each byte of the hashed data
				// and format each one as a hexadecimal string.
				for (int i = 0; i < data.Length; i++)
				{
					sBuilder.Append(data[i].ToString("x2"));
				}

				// Return the hexadecimal string.
				return sBuilder.ToString();
			}
		}
	}
}
