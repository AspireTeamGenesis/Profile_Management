using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.API
{
    public class BreakDuration
    {
        [Key]
        public int BreakDuration_Id{get;set;}
        public DateTime Starting_Month{get;set;}
        public DateTime Starting_Year{get;set;}
        public DateTime Ending_Month{get;set;}
        public DateTime Ending_Year{get;set;}
        public int PersonalDetailsId{get;set;}
        [ForeignKey("PersonalDetailsId")]
        //public virtual PersonalDetails personalDetails{get;set;}
        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }

        public string UpdatedBy { get; set; }
    }
}