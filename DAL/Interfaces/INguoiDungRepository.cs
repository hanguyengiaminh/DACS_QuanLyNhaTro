using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL.Interfaces
{
	public interface INguoiDungRepository
	{
		NguoiDung GetById(int id);
		NguoiDung GetByTenDangNhap(string tenDangNhap);
		IEnumerable<NguoiDung> GetAll();
		void Add(NguoiDung nguoiDung);
		void Update(NguoiDung nguoiDung);
		void Delete(int id);
		bool CheckTenDangNhapExists(string tenDangNhap);
		bool CheckEmailExists(string email);
		bool CheckSoDienThoaiExists(string soDienThoai);
		void UpdateMatKhau(int maNguoiDung, string matKhauMoi);
		void UpdateTrangThai(int maNguoiDung, bool trangThai);
		void UpdateSoLanDangNhapSai(int maNguoiDung, int soLan);
		void UpdateNgayKhoa(int maNguoiDung, DateTime? ngayKhoa, string lyDo);
	}
}
