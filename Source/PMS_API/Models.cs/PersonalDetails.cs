using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.API
{
    public class PersonalDetails
    {
        [Key]
        public int PersonalDetailsId{get;set;}
        public string Objective{get;set;}
        public string Name{get;set;}
        public DateTime? DateOfBirth{get;set;}
        public string Nationality{get;set;}
        public string MailAdress{get;set;}
        public long MobileNo{get;set;}
        public DateTime? DateOfJoinig{get;set;}
        public DateTime? CreatedOn { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }
        public int languageid {get;set;}
        public int breakDurationid{get;set;}
        public int socialmediaid{get;set;}
        public string? UpdatedBy { get; set; }
        

        [ForeignKey("languageid")]
        [InverseProperty("personalDetails")]
        public virtual Language? language { get; set; }
        [ForeignKey("breakDurationid")]
        [InverseProperty("personalDetails")]
        public virtual BreakDuration? breakDuration { get; set; }

        [ForeignKey("socialmediaid")]  
        [InverseProperty("personalDetails")]
        public virtual SocialMedia? socialmedia { get; set; }
        [InverseProperty("personalDetails")]
        public virtual ICollection<Education> education { get; set;}
        [InverseProperty("personalDetails")]
        public virtual ICollection<Projects> projects { get; set;}
        [InverseProperty("personalDetails")]
        public virtual ICollection<Skills> skills { get; set;}
        public bool IsActive{ get; set;}
       

    }
}