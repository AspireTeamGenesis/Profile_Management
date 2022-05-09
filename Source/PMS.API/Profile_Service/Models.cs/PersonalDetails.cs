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
        public DateTime DateOfBirth{get;set;}
        public string Nationality{get;set;}
        public string MailAdress{get;set;}
        public long MobileNo{get;set;}
        public DateTime DateOfJoinig{get;set;}
        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }
        public int languageid {get;set;}
        public int breakDurationid{get;set;}
        public int socialmediaid{get;set;}
        public string UpdatedBy { get; set; }

        [ForeignKey("Language_Id")][NotMapped]
        public virtual Language? language { get; set; }
         [ForeignKey("BreakDuration_Id")][NotMapped]
        public virtual BreakDuration? breakDuration { get; set; }

         [ForeignKey("SocialMedia_Id")][NotMapped]
        public virtual SocialMedia? socialmedia { get; set; }

        [ForeignKey("Education_Id")][NotMapped]
        public virtual Education? education { get; set; }

        [ForeignKey("Skill_Id")][NotMapped]
        public virtual Skills? sills { get; set; }

        [ForeignKey("Project_Id")][NotMapped]
        public virtual Projects? projectDetails { get; set; }

        public bool IsActive{ get; set;}
       

    }
}