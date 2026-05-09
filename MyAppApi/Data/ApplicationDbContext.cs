using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyAppApi.Models;

namespace MyAppApi.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // 우리가 추가한 테이블들
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<RolePagePermission> RolePagePermissions { get; set; }
        public DbSet<UserLog> UserLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}