using DTO.ViewModels;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
	public interface INguoiDungService
	{
		NguoiDung GetById(int id);
		NguoiDung GetByTenDangNhap(string tenDangNhap);
		IEnumerable<NguoiDung> GetAll();
		void Add(NguoiDung nguoiDung);
		void Update(NguoiDung nguoiDung);
		void Delete(int id);
		bool DangNhap(string tenDangNhap, string matKhau);
		void DoiMatKhau(int maNguoiDung, string matKhauCu, string matKhauMoi);
		void CapNhatThongTin(ThongTinTaiKhoanViewModel model);
		void KhoaTaiKhoan(int maNguoiDung, string lyDo);
		void MoKhoaTaiKhoan(int maNguoiDung);
		bool ValidateMatKhau(string matKhau);
		bool ValidateEmail(string email);
		bool ValidateSoDienThoai(string soDienThoai);
	}

}
