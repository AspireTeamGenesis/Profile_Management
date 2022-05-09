using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.API
{
    public class Projects
    {
        [Key]
        public string Project_Id{get;set;}
        public string ProjectName{get;set;}
        public string project_Description{get;set;}
         public DateTime Project_Starting_Month{get;set;}
        public DateTime Project_Starting_Year{get;set;}
        public DateTime Project_Ending_Month{get;set;}
        public DateTime Project_Ending_Year{get;set;}
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