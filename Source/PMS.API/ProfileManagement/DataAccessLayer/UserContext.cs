using Microsoft.EntityFrameworkCore;

namespace ProfileManagement{
    public class UserContext:DbContext{
        public UserContext(){}
        public UserContext(DbContextOptions<UserContext> options):base(options){

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseSqlServer("server=.;database=ProfileManagement;trusted_connection=true;");
}
        public DbSet<User> users{get;set;}
    }
}