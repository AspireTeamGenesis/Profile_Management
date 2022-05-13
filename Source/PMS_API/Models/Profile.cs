using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS_API
{
    public class Profile
    {
        [Key]
        public int ProfileId{ get;set;}
        public virtual PersonalDetails? PersonalDetails{get;set;}

        [InverseProperty("personalDetails")]
        public virtual ICollection<Education>? education { get; set;}
        [InverseProperty("personalDetails")]
        public virtual ICollection<Projects>? projects { get; set;}
        [InverseProperty("personalDetails")]
        public virtual ICollection<Skills>? skills { get; set;}
        [InverseProperty("personalDetails")]
        public virtual ICollection<Achievements>? achievements { get; set;}
       
        
        // public string? ProfileStatus {get; set;}
        public bool IsActive{ get; set;}
       

    }
}