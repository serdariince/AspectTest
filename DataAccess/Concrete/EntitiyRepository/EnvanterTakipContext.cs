using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntitiyRepository
{
    public class EnvanterTakipContext : DbContext
    {
        public DbSet<Kamera> Kameralar { get; set; }
        public DbSet<Tesis> Tesisler { get; set; }
        public DbSet<Ip> Ipler { get; set; }

        public DbSet<KayitProgrami> KayitProgramlari { get; set; }
/*        public EnvanterTakipContext(DbContextOptions<EnvanterTakipContext> options)
            : base(options)
        {
        }
*/


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=EnvanterTakip.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tesis>()
                .HasOne(x => x.KayitProgrami)
                .WithOne(c => c.Tesis)
                .HasForeignKey<KayitProgrami>(x => x.TesisId);
            modelBuilder.Entity<Ip>()
                .HasOne(x => x.Kamera)
                .WithOne(c => c.Ip)
                .HasForeignKey<Kamera>(x => x.IpId);
            modelBuilder.Entity<Kamera>()
                .HasOne(x => x.Tesis)
                .WithMany(c => c.Kameralar)
                .HasForeignKey(x => x.TesisId);
        }
    }
}