using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheSocialNet.Configs;
using TheSocialNet.Models.Users;
// ApplicationDbContext enable-migrations -contexttypename ApplicationDbContext
// Enable-Migrations -ProjectName TheSocialNet -ContextTypeName TheSocialNet.Data.ApplicationDbContext
// EntityFrameworkCore\Add-Migration Initial
namespace TheSocialNet.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new FriendConfiguration());
            builder.ApplyConfiguration(new MessageConfuiguration());
        }
    }
}
