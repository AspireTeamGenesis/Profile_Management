using Microsoft.EntityFrameworkCore;
using PROFILE.Models;

namespace PROFILE.DataAccessLayer{
public class MasterContext : DbContext
{
   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
        optionsBuilder.UseSqlServer(@"Server=ASPIREREN024\SQLEXPRESS;Database=PMS;Trusted_Connection=True;");
    }
     public DbSet<College> ?Colleges {get; set;} 
     public DbSet<Designation> ?Designations {get; set;} 
      public DbSet<Domain> ?Domains {get; set;} 
       public DbSet<Technology> ?Technologies {get; set;}
      public DbSet<ProfileStatus> ?ProfileStatuss {get; set;}  
}
}