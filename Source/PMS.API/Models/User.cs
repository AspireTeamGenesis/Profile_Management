using System.ComponentModel.DataAnnotations;

namespace PMS.API{
    public class User{
        [Key]
        public int Id{get;set;}
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public long MobileNo { get; set; }
        [Required]
        public string Organization { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public string Reporting_Person { get; set; }
        public bool IsActive{get;set;}
        //audit fields
        //createdby  createdon updatedby updatedon\
        public string? CreatedBy{get;set;}
        public DateTime CreatedOn{get;set;}
        public string? UpdatedBy{get;set;}
        public DateTime UpdatedOn{get;set;}

    }
}