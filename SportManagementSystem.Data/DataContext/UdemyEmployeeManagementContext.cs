using SportManagementSystem.Data.DbModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SportManagementSystem.Data.DataContext
{
    public class UdemySportManagementSystemContext : IdentityDbContext
    {
    public UdemySportManagementSystemContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Users> DbUsers { get; set; }
        public DbSet<Activity> Activity { get; set; }
        public DbSet<ActivityType> ActivityType { get; set; }
        public DbSet<Announcement> Announcement { get; set; }
        public DbSet<Athletes> Athletes { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<DbRoles> DbRoles { get; set; }
        public DbSet<Treatment> Treatment { get; set; }
        public DbSet<DbUserRoles> DbUserRoles { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>()
            .Property(e => e.IsActive)
                .HasDefaultValue(true);

            builder.Entity<Employee>()
                .Property(e => e.IsAdmin)
                .HasDefaultValue(false);
            base.OnModelCreating(builder);
        }
    }
}
