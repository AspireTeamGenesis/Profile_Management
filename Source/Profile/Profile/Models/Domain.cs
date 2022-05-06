using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PROFILE.Models{
     public class Domain
    {
        [Key]
        public int DomainId{get; set;}
        [Required]
        [StringLength(80)]
        public string ? DomainName{get;set;}
        public bool IsActive { get; set; } = true;
        

        
    }
}