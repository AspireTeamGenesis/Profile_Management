using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PROFILE.Models{
     public class Designation
    {
        [Key]
        public int DesignationId{get; set;}
        [Required]
        [StringLength(80)]
        public string ? DesignationName{get;set;}
        public bool IsActive { get; set; } = true;
        

        
    }
}