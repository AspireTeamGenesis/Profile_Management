using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PMS.API{
  
    public class Designation{
        [Key]
       
        public string Designation_Id;
        public string Designation_Name;
        public string? CreatedBy{get;set;}
        public DateTime CreatedOn{get;set;}
        public string? UpdatedBy{get;set;}
        public DateTime UpdatedOn{get;set;}
       

    }
    }
