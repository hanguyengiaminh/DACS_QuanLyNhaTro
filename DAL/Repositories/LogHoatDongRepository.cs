using DAL.Interfaces;
using System;

namespace DAL.Repositories
{
    public class LogHoatDongRepository : ILogHoatDongRepository
    {
        private readonly string connectionString;

        public LogHoatDongRepository()
        {
            connectionString = DBConnection.connectionString;
        }

        public void GhiLog(string hanhDong, string bang, int? maBanGhi, object duLieuCu, object duLieuMoi)
        {
            // TODO: Implement logging logic
        }
    }
} 