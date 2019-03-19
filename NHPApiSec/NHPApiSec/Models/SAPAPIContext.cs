using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Microsoft.AspNet.Identity.EntityFramework;
using NHPApi.Models.Mapping;

namespace NHPApi.Models
{
    public partial class SAPAPIContext : IdentityDbContext<ApplicationUser, IdentityRole, string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>
    {
        static SAPAPIContext()
        {
            Database.SetInitializer<SAPAPIContext>(null);
        }

        public SAPAPIContext()
            : base("Name=SAPAPIContext")
        {
        }

        public DbSet<IdentityUserLogin> UserLogins { get; set; }
        public DbSet<IdentityUserClaim> UserClaims { get; set; }
        public DbSet<IdentityUserRole> UserRoles { get; set; }

        public DbSet<OCRD> OCRDs { get; set; }
        public DbSet<OITM> OITMs { get; set; }
        public DbSet<ORDR> ORDRs { get; set; }
        public DbSet<RDR1> RDR1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole>()
            .HasKey(r => new { r.UserId, r.RoleId })
            .ToTable("AspNetUserRoles");

            modelBuilder.Entity<IdentityUserLogin>()
                        .HasKey(l => new { l.LoginProvider, l.ProviderKey, l.UserId })
                        .ToTable("AspNetUserLogins");

            modelBuilder.Configurations.Add(new OCRDMap());
            modelBuilder.Configurations.Add(new OITMMap());
            modelBuilder.Configurations.Add(new ORDRMap());
            modelBuilder.Configurations.Add(new RDR1Map());
        }
    }
}
