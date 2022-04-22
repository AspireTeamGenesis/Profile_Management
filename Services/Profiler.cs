class UserDetails{

}
class PersonalDetails{

}
class EducationalDetails{

}
class ProjectDetails{

}
class Skills{

}
class Break_duration{

}
class Language{

}
class Social_media{

}
class Achievements{

}

class PersonalDetails_History{

}
class EducationalDetails_History{

}
class ProjectDetails_History{

}
class Skills_History{

}
class Break_duration_History{

}
class Language_History{

}
class Social_media_History{

}
class Achievements_History{

}

class ProfileHistory
{

}
class Totalprofiles{

}
class Profiler{
    
    public bool CreateUser(UserDetails user){}
    public bool UpdateUser(UserDetails user){}
    //Creator
    public bool Login(string username,string password){}
    public bool Change_password(string current_password,string New_password,string Confirm_password){}

    public bool create(PersonalDetails personalDetails,Break_duration duration,Language language,Social_media media){}
    public bool update(PersonalDetails personalDetails,Break_duration duration,Language language,Social_media media){}
    public bool DeletePersonalDetails(int personal_id,int duration_id,int language_id,int social_media_id){}
    public bool SaveDraft(PersonalDetails personalDetails,Break_duration duration,Language language,Social_media media){}
    
    public bool create(EducationalDetails educationalDetails){}
    public bool edit(EducationalDetails educationalDetails){}
    public bool update(EducationalDetails educationalDetails){}
    public bool DeleteEducationDetails(int Education_id){}
    public bool SaveDraft(EducationalDetails educationalDetails){}

    public bool create(ProjectDetails projects){}
    public bool edit(ProjectDetails projects){}
    public bool update(ProjectDetails projects){}
    public bool DeleteProject(int Project_Id){}
    public bool SaveDraft(ProjectDetails projects){}

    public bool create(Skills skills){}
    public bool edit(Skills skills){}
    public bool update(Skills skills){}
    public bool DeleteSkills(int skill_id){}
    public bool SaveDraft(Skills skills){}  

    public bool create(Achievements achievements){}
    public bool edit(Achievements achievements){}
    public bool update(Achievements achievements){}
    public bool DeleteAchievements(int achievement_Id){}
    public bool SaveDraft(Achievements achievements){}
    public void View(int user_id){}
    

    //Searcher
      
    public  List<> Totalprofiles(){}
    public  List<> Approvedprofiles(){}
    public  List<> Declinedprofiles(){}
    public  List<> ViewWaitingforApprovalprofile(){}
    public  List<> Approvestatus(){}
    public bool Share(string mailaddress){}
    public bool Export(int user_id){}
    public bool RequesttoUpdate(){}
    public List<PersonalDetails_History,EducationalDetails_History,ProjectDetails_History,Skills_History,Break_duration_History,Language_History,Social_media_History,Achievements_History> ProfileHistory(int user_id){}
    public bool signout(){}
}


