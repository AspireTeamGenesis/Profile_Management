using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PROFILE.Models{
     public class ProfileStatus
    {
        [Key]
        public int ProfileStatusId{get; set;}
        [Required]
        [StringLength(80)]
        public string ? ProfileStatusName{get;set;}
        public bool IsActive { get; set; } = true;
        

        
    }
}