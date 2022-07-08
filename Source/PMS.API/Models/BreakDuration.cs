using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
namespace PMS_API
{
    public class BreakDuration
    {
        [Key]
        public int BreakDuration_Id{get;set;}
        // [NotMapped]
        public DateTime StartingDuration{get;set;}
        // [NotMapped]
        // [NotMapped]
        public DateTime EndingDuration{get;set;}
        // [NotMapped]
        public int PersonalDetailsId{get;set;}
        [ForeignKey("PersonalDetailsId")]
        [InverseProperty("breakDuration")]
        public virtual PersonalDetails?  personalDetails {get;set;}
        public DateTime? CreatedOn { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int? UpdatedBy { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }
    }
}