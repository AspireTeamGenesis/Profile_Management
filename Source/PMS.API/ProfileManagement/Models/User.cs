using System.ComponentModel.DataAnnotations;

namespace ProfileManagement{
    public class User{
        
        public int Id{get;set;}
        
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public long MobileNo { get; set; }
        public string Organization { get; set; }
        public string Designation { get; set; }
        public string Reporting_Person { get; set; }
    }
}