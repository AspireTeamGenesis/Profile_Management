using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.API
{
    public class Skills
    {
        [Key]
        public int Skill_Id{get;set;}
        public string Domain{get;set;}
        public string Technology{get;set;}
        public int PersonalDetailsId{get;set;}
        
        [ForeignKey("PersonalDetailsId")]
        [InverseProperty("skills")]
        public virtual PersonalDetails? personalDetails{get;set;}
        public DateTime? CreatedOn { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public string? UpdatedBy { get; set; }
        public bool IsActive { get; set; }
    }
}