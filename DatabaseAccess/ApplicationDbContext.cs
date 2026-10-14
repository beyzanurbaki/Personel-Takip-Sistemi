using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ModelClasses;

namespace DatabaseAccess
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<spUrtUser> spurtuser { get; set; }
        public DbSet<spUrtUretimHareketiBar> spurturetimhareketibar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Bu çağrı, IdentityDbContext'ten gelen konfigürasyonları ekler

            // spUrtUretimHareketiBar için birincil anahtar belirtme
            modelBuilder.Entity<spUrtUretimHareketiBar>()
                .HasKey(b => b.nUserID); // Burada birincil anahtar belirtildi

            // Eğer bir ilişki kurmak istiyorsanız, ilişkiyi de tanımlayın
            modelBuilder.Entity<spUrtUretimHareketiBar>()
                    .HasOne(h => h.spurtuser) // Bir spUrtUretimHareketiBar'ın bir kullanıcısı var
                    .WithMany(u => u.UretimHareketiBars) // Bir kullanıcının birden fazla hareketi var
                    .HasForeignKey(h => h.nUserID); // spUrtUretimHareketiBar'daki nUserID, spUrtUser'deki anahtar
        
    }
    }
}
