using Microsoft.EntityFrameworkCore;

namespace PMS.API
{
    public class ProfileContext:DbContext
    {
        public ProfileContext()
        {
            
        }
        public ProfileContext(DbContextOptions<ProfileContext> options):base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=ProfileService;trusted_connection=true");
        }
        public DbSet<PersonalDetails> personalDetails{get;set;}
        public DbSet<Education> educations{get;set;}
        public DbSet<Language> languages{get;set;}
        public DbSet<BreakDuration> breakDurations{get;set;}
        public DbSet<Projects> projects{get;set;}
        public DbSet<Skills> skills{get;set;}
        public DbSet<SocialMedia> SocialMedias{get;set;}
    }
}