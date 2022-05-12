using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.API
{
    public class Language
    {
        [Key]
        public int LanguageId{get;set;}
        public string LanguageName{get;set;}
        public bool Read{get;set;}
        public bool Write{get;set;}
        public bool Speak{get;set;}
        // public int PersonalDetailsId{get;set;}
        
        [InverseProperty("language")]
        public virtual ICollection<PersonalDetails>  personalDetails {get;set;}
        public DateTime? CreatedOn { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public string? UpdatedBy { get; set; }
        public bool IsActive { get; set; }

    }
}