using Microsoft.EntityFrameworkCore;

namespace BankaIslemleriProjesi.Models
{
    public class IslemDbContext:DbContext
    {
        public IslemDbContext(DbContextOptions<IslemDbContext> options) : base(options)
        { }

        public DbSet<Islem> Islems { get; set; }

    }
}
