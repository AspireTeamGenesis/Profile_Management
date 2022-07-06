import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CreateusersComponent } from './hr/createusers/createusers.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { TopbarComponent } from './topbar/topbar.component';
import { HrhomeComponent } from './hr/hrhome/hrhome.component';
import { HomeComponent } from './hr/home/home.component';
import { SearchComponent } from './hr/search/search.component';
import { LoginComponent } from './hr/login/login.component';
import { CardComponent } from './hr/card/card.component';
import { Card11Component } from './card11/card11.component';
import { HttpClientModule } from '@angular/common/http';
import {NgxPaginationModule} from 'ngx-pagination';
import { FormBuilder, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ChangepasswordComponent } from './changepassword/changepassword.component';
import { HrprofileComponent } from './hrprofile/hrprofile.component';
import { EducationComponent } from './education/education.component';
import { EdituserComponent } from './edituser/edituser.component';
import { EditeducationComponent } from './editeducation/editeducation.component';
import { EducationcardComponent } from './educationcard/educationcard.component';
import { AchievementComponent } from './achievement/achievement.component';
import { SkillsComponent } from './skills/skills.component';
import { ProjectComponent } from './project/project.component';
import { EducationtwoComponent } from './educationtwo/educationtwo.component';
import { SkillcardComponent } from './skillcard/skillcard.component';
import { ProjectcardComponent } from './projectcard/projectcard.component';
import { EditskillComponent } from './editskill/editskill.component';
import { AchievementcardComponent } from './achievementcard/achievementcard.component';
import { ProfilehomeComponent } from './profilehome/profilehome.component';
import { ViewprofileComponent } from './viewprofile/viewprofile.component';
import { EditprojectComponent } from './editproject/editproject.component';

@NgModule({
  declarations: [
    AppComponent,
    CreateusersComponent,
    SidebarComponent,
    TopbarComponent,
    HrhomeComponent,
    HomeComponent,
    SearchComponent,
    LoginComponent,
    CardComponent,
    Card11Component,
    ChangepasswordComponent,
    HrprofileComponent,
    EducationComponent,
    EdituserComponent,
    EditeducationComponent,
    EducationcardComponent,
    AchievementComponent,
    SkillsComponent,
    ProjectComponent,
    EducationtwoComponent,
    SkillcardComponent,
    ProjectcardComponent,
    EditskillComponent,
    AchievementcardComponent,
    ProfilehomeComponent,
    ViewprofileComponent,
    EditprojectComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    NgxPaginationModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
