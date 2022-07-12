import { Component, OnInit, ViewChild } from '@angular/core';
import { UserserviceService } from '../service/userservice.service';
import { FormGroup,FormBuilder, FormControl, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { College } from 'Models/college';
import { EducationcardComponent } from '../educationcard/educationcard.component';
import { ActivatedRoute, ParamMap } from '@angular/router';


@Component({
  selector: 'app-education',
  templateUrl: './education.component.html',
  styleUrls: ['./education.component.css']
})
export class EducationComponent implements OnInit {

  @ViewChild(EducationComponent) child:EducationcardComponent
  selectedYear: number=0;
  years: number[] = [];

  constructor(private FB: FormBuilder,private service: UserserviceService,private http: HttpClient,private route: ActivatedRoute) {
    this.selectedYear = new Date().getFullYear();
  for (let year = this.selectedYear; year >= 2000; year--) {
    this.years.push(year);
  }
    }
    showMe: boolean = false;

    foot:boolean = true;

  collegeValue:any;
  college:number=0;
  educationDetails:any;
  profileId:number=0;
  profileDetails:any;
  profileIdDetails:any;

  // _college='';
  // college:any[]=[];
  // collegeDetails:any;
  
  user = {
    educationId: 0,
    profileId:0,
    degree: '',
    course: '',
    collegeId:0,
    starting: 0,
    ending: 0,
    percentage: 0,
  }
  ngOnInit(): void {
    this.getUserProfile;
    this.getCollege();
    this.getProfileIdByUserId();
    // this.getEducationDetails(this.user.educationId);

  }

  getUserProfile(){
    this.service.getUserProfile().subscribe( {
      next:(data)=>{this.profileDetails=data,
      console.log(this.profileDetails)}      
    })
    console.log(this.profileDetails.userid);
  }

  getProfileIdByUserId()
  {
    this.service.getProfileIdByUserId().subscribe({
        next:(data:any)=>{this.profileIdDetails=data,
        this.profileId=this.profileIdDetails.profileId,
        console.warn(this.profileId),
        console.log(this.profileIdDetails)
        }
  
    })
  }
  
  getCollege()
  {
    this.service.getCollege().subscribe((data:any)=>
    {
      this.collegeValue=data;
      console.warn(this.collegeValue);
    });

  }
  educationSubmit()
  {
    this.user.profileId=this.profileId;
    console.log("hi how");
    console.warn(this.user);
    this.service.addEducation(this.user).subscribe(()=>  {this.child.getEducationByProfileId();console.log('posted')});//data=>this.user.push(data)    
  }
  toogletag()

  {

    this.showMe=!this.showMe;

  }



  footer()

  {

    this.foot=!this.foot;

    if(this.foot==false){this.foot=true};

   

  }

}
