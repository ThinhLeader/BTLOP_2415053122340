using Microsoft.EntityFrameworkCore;
using LeVanThinh_2415053122340.Models; 
namespace LeVanThinh_2415053122340.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<SinhVien> sv { get; set; }
        public DbSet<KhoaHoc> kh { get; set; }
        public DbSet<DangKi> dk { get; set; }
    }
}
