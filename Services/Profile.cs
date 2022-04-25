
class Profile
{
    PersonalDetails
    List<EducationalDetails>
    List<ProjectDetails>
    List<Skills>
    List<Achievements>
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
List<Awards>
List<Certifications>
}
class Filters
{
   

}

class Profile_Operations{

    public bool CreatePersonalDetails(PersonalDetails personaldetails){}
    public bool UpdatePersonalDetails(PersonalDetails personaldetails){}
    
    public bool CreateEducationalDetails(List<EducationalDetails> educationaldetails){}
    public List<EducationalDetails> ViewEducationalDetails(int profile_id){}
    public bool UpdateEducationalDetails(List<EducationalDetails> educationaldetails){}
    public bool DeleteEducationalDetails(int education_id){}
    

    public bool CreateProjectDetails(List<ProjectDetails> projects){}
    public List<ProjectDetails> ViewProjectDetails(int profile_id){}
    public bool UpdateProjectDetails(List<ProjectDetails> projectdetails){}
    public bool DeleteProjectDetails(int project_id){}
   

    public bool CreateSkills(List<Skills> skills){}
    public List<Skills> ViewSkills(int profile_id){}
    public bool UpdateSkills(List<Skills> skills){}
    public bool DeleteSkills(int skill_id){}
      

    public bool CreateAchievements(List<Achievements> achievements){}
    public List<Achivements> ViewAchievements(int profile_id){}
    public bool UpdateAchievements(List<Achievements> achievements){}
     
    public Profile ViewMyProfile(int profile_id){}

    public List<Profile> search(string Name, List<Filters> filters){}
    public bool Share(List<Mailaddress> mailaddress){}
    public bool Export(int profile_id){}
    public bool RequesttoUpdate(string mailaddress){}
    public List<Profile> ViewProfileHistory(int profile_id){}
    

}


