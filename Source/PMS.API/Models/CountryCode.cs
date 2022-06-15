using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PMS_API{
     public class CountryCode
    {
        [Key]
        public int CountryCodeId{get; set;}
        public string  CountryCodeName{get;set;}
        [InverseProperty("countrycode")]
        public virtual ICollection<User>?  users{get;set;}
        public bool IsActive { get; set; } = true;
        

        
    }
}