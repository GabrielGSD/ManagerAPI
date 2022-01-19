using Manager.Domain.Entities;
using Manager.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Manager.Infra.Context
{
    public class ManagerContext : DbContext
    {
        public ManagerContext()
        { }

        public ManagerContext(DbContextOptions<ManagerContext> options) : base(options)
        {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySQL("server=127.0.0.1;port=3306;database=usermanager;uid=root;Pwd=12345;");
        }

        public virtual DbSet<User> Users { get; set;}

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.ApplyConfiguration(new UserMap());
        }
  }
}