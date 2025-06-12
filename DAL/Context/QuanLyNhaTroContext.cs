using System.Data.Entity;
using DTO;

namespace DAL.Context
{
    public class QuanLyNhaTroContext : DbContext
    {
        public QuanLyNhaTroContext() : base("name=QuanLyNhaTroConnection")
        {
        }

        public DbSet<NguoiDung> NguoiDungs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
} 