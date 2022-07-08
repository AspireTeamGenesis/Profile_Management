import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Card11Component } from './card11/card11.component';
import { CardComponent } from './hr/card/card.component';
import { CreateusersComponent } from './hr/createusers/createusers.component';
import { HrhomeComponent } from './hr/hrhome/hrhome.component';
import { LoginComponent } from './hr/login/login.component';
import { SearchComponent } from './hr/search/search.component';
import { ChangepasswordComponent } from './changepassword/changepassword.component';
import { HrprofileComponent } from './hrprofile/hrprofile.component';
import { EducationComponent } from './education/education.component';
import { EdituserComponent } from './edituser/edituser.component';
import { EditeducationComponent } from './editeducation/editeducation.component';
import { AchievementComponent } from './achievement/achievement.component';
import { EducationtwoComponent } from './educationtwo/educationtwo.component';
import { SkillsComponent } from './skills/skills.component';
import { SkillcardComponent } from './skillcard/skillcard.component';
import { ProjectComponent } from './project/project.component';
import { ProjectcardComponent } from './projectcard/projectcard.component';
import { EditskillComponent } from './editskill/editskill.component';
import { ProfilehomeComponent } from './profilehome/profilehome.component';
import { ViewprofileComponent } from './viewprofile/viewprofile.component';
import { EditprojectComponent } from './editproject/editproject.component';
import { CreateprofileComponent } from './createprofile/createprofile.component';
import { PersonalComponent } from './personal/personal.component';


const routes: Routes = [
  {path:"hrhome",component:HrhomeComponent},
  {path:"search",component:SearchComponent},
  {path:"card",component:CardComponent},
  {path:"newcard",component:Card11Component},
  {path:"createuser",component:CreateusersComponent},
  {path:"changepassword",component:ChangepasswordComponent},
  {path:"hrprofile",component:HrprofileComponent},
  {path:"hrprofile/:userId",component:HrprofileComponent},
  {path:"education/:profileId",component:EducationComponent},
  {path:"editUser/:userId",component:EdituserComponent},
  {path:"editeducation/:educationid/:profileId",component:EditeducationComponent},
  {path:"achievement",component:AchievementComponent},
  {path:"educationtwo",component:EducationtwoComponent},
  {path:"skill/:profileId",component:SkillsComponent},
  {path:"skillcard",component:SkillcardComponent},
  {path:"achievement/:profileId",component:AchievementComponent},
  {path:"project/:profileId",component:ProjectComponent},
  {path:"projectcard",component:ProjectcardComponent},
  {path:"editproject/:projectid/:profileId",component:EditprojectComponent},
  {path:"editskill/:skillid/:profileId",component:EditskillComponent},
  {path:"profilehome",component:ProfilehomeComponent},
  {path:"viewprofile",component:ViewprofileComponent},
  {path:"createprofile/:userid",component:CreateprofileComponent},
  {path:"personal/:profileId",component:PersonalComponent},
  {path:"",component:LoginComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
