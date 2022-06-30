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


const routes: Routes = [
  {path:"hrhome",component:HrhomeComponent},
  {path:"search",component:SearchComponent},
  {path:"card",component:CardComponent},
  {path:"newcard",component:Card11Component},
  {path:"createuser",component:CreateusersComponent},
  {path:"changepassword",component:ChangepasswordComponent},
  {path:"hrprofile",component:HrprofileComponent},
  {path:"hrprofile/:userId",component:HrprofileComponent},
  {path:"education",component:EducationComponent},
  {path:"editUser/:userId",component:EdituserComponent},
  {path:"editeducation",component:EditeducationComponent},
  {path:"",component:LoginComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
