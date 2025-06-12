using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
	public interface ILogHoatDongRepository
	{
		void GhiLog(string hanhDong, string bang, int? maBanGhi, object duLieuCu, object duLieuMoi);
	}
}
