using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.API
{
    public class Education
    {
        [Key]
        public int Education_Id{get;set;}
        public string Degree{get;set;}
        public string Course{get;set;}
        public DateTime Starting_Year{get;set;}
        public DateTime Ending_Year{get;set;}
        public float Percentage{get;set;}
        public int PersonalDetailsId{get;set;}
        [ForeignKey("PersonalDetailsId")]
        //public virtual PersonalDetails personalDetails{get;set;}
        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }

        public string UpdatedBy { get; set; }
         public bool IsActive { get; set; }
    }
}