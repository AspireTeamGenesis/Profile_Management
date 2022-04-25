
class Profile
{
    PersonalDetails
    List<EducationalDetails>
    List<ProjectDetails>
    List<Skills>
    Achievements
}
class PersonalDetails{
List<Breakduration>
List<Language>
List<Socialmedia>
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

class Profile_Operations{

    public bool CreatePersonalDetails(PersonalDetails personaldetails){}
    public bool UpdatePersonalDetails(PersonalDetails personaldetails){}
    
    public bool CreateEducationalDetails(List<EducationalDetails> educationaldetails){}
    public List<EducationalDetails> ViewEducationalDetails(string profile_id){}
    public EducationalDetails GetEducationDetails(string education_id){}
    public bool UpdateEducationalDetails(List<EducationalDetails> educationaldetails){}
    public bool DeleteEducationalDetails(string education_id){}
    

    public bool CreateProjectDetails(List<ProjectDetails> projectdetails){}
    public List<ProjectDetails> ViewProjectDetails(string profile_id){}
    public ProjectDetails GetProjectDetails(string project_id){}
    public bool UpdateProjectDetails(List<ProjectDetails> projectdetails){}
    public bool DeleteProjectDetails(string project_id){}
   

    public bool CreateSkills(List<Skills> skills){}
    public List<Skills> ViewSkills(string profile_id){}
    public Skills GetSkillDetails(string skill_id){}
    public bool UpdateSkills(List<Skills> skills){}
    public bool DeleteSkills(string skill_id){}
      

    public bool CreateAchievements(List<Achievements> achievements){}
    public List<Achievements> ViewAchievements(string profile_id){}
    public bool UpdateAchievements(List<Achievements> achievements){}
     
    public Profile ViewMyProfile(string profile_id){}

    public List<Profile> search(string Name, Filters filters){}
    public bool Share(List<Mailaddress> mailaddress,string profile_id){}
    public bool Export(string profile_id){}
    public bool RequesttoUpdate(string mailaddress,string profile_id){}
    public List<Profile> ViewProfileHistories(string profile_id){}
    public Profile ViewProfileHistory(string profile_history_id){}

}


