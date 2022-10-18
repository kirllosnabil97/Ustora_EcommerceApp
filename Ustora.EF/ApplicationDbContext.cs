
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Ustora.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        //{
        //}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().ToTable("Users", "security");
            builder.Entity<IdentityRole>().ToTable("Roles", "security");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "security");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "security");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "security");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "security");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "security");
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Banners> Banners { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryOfClassfication> CategoryOfClassfications { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CmsPages> CmsPages { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Installment> Installments { get; set; }
        public DbSet<Mail> Mails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ShippingCart> ShippingCarts { get; set; }
        
    }
}