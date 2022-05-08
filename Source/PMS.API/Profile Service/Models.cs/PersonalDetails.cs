using System.ComponentModel.DataAnnotations;

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

        public string UpdatedBy { get; set; }

    }
}