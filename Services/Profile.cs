
class PersonalDetails{

}
class EducationalDetails{

}
class ProjectDetails{

}
class Skills{

}

class Achievements{

}
class Filters
{
   

}

class Profile{

    public bool CreatePersonalDetails(PersonalDetails personalDetails){}
    public bool UpdatePersonalDetails(PersonalDetails personalDetails){}
    
    public bool CreateEducationDetails(List<EducationalDetails> educationalDetails){}
    public List<EducationalDetails> ViewEducationDetails(int education_id){}
    public bool UpdateEducationDetails(List<EducationalDetails> educationalDetails){}
    public bool DeleteEducationDetails(int Education_id){}
    

    public bool CreateProjectDetails(List<ProjectDetails> projects){}
    public List<ProjectDetails> ViewProjectDetails(int project_id){}
    public bool UpdateProjectDetails(List<ProjectDetails> projects){}
    public bool DeleteProjectDetails(int Project_Id){}
   

    public bool CreateSkills(List<Skills> skills){}
    public List<Skills> ViewSkills(int skill_id){}
    public bool UpdateSkills(List<Skills> skills){}
    public bool DeleteSkills(int skill_id){}
      

    public bool CreateAchievements(List<Achievements> achievements){}
    public List<Achivements> ViewAchievements(int achievement_id){}
    public bool UpdateAchievements(List<Achievements> achievements){}



    public  List<Profile> Totalprofiles(string RoleId){}
    public  List<Profile> Approvedprofiles(string RoleId, string ProfileStatus){}
    //public  List<> Declinedprofiles(){}
    //public  List<> ViewWaitingforApprovalprofile(){}
    public  List<> Approvestatus(){}
    public bool Share(string mailaddress){}
    public bool Export(int user_id){}
    public bool RequesttoUpdate(){}
    
    public search(string Name, List<Filters> filters){}

}


