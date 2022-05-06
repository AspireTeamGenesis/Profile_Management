using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PROFILE.Models{
     public class Technology
    {
        [Key]
        public int TechnologyId{get; set;}
        [Required]
        [StringLength(80)]
        public string ? TechnologyName{get;set;}
        public bool IsActive { get; set; } = true;
        

        
    }
}