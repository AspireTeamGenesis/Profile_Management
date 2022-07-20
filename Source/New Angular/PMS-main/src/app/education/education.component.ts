import { Component, OnInit, ViewChild } from '@angular/core';
import { UserserviceService } from '../service/userservice.service';
import { FormGroup, FormBuilder, FormControl, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { College } from 'Models/college';
import { EducationcardComponent } from '../educationcard/educationcard.component';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { compileClassMetadata } from '@angular/compiler';
// import { Toast } from 'ngx-toast-notifications';


@Component({
  selector: 'app-education',
  templateUrl: './education.component.html',
  styleUrls: ['./education.component.css']
})
export class EducationComponent implements OnInit {

  @ViewChild(EducationComponent) child: EducationcardComponent
  selectedYear: number = 0;
  years: number[] = [];
  years1: number[] = [];
  educationForm:FormGroup;
  formSubmitted: boolean = false;
  I:number=0;

  constructor(private FB: FormBuilder, private service: UserserviceService, private http: HttpClient, private route: ActivatedRoute,) {
    this.selectedYear = new Date().getFullYear();
  for (let year = this.selectedYear; year >= 1990; year--) {
    this.I == year;
    this.years.push(year);
    
    
  }
  for (let year = this.I; year <= this.selectedYear; year++) {
    this.years1.push(year);
  }
    }

  showMe: boolean = false;

  foot: boolean = true;

  collegeValue: any;
  college: number = 0;
  educationDetails: any;
  profileId: number = 0;
  profileDetails: any;
  profileIdDetails: any;

  // _college='';
  // college:any[]=[];
  // collegeDetails:any;

  user = {
    educationId: 0,
    profileId: 0,
    degree: '',
    course: '',
    collegeId:0,
    starting:0,
    ending:0,
    percentage: 0,
  }
  ngOnInit(): void {
    this.getUserProfile();
    this.getCollege();
    this.getProfileIdByUserId();
    this.educationForm=this.FB.group({
      Degree: ['', [Validators.required,Validators.minLength(2),Validators.maxLength(38),Validators.pattern("^[A-Za-z ]+$")]],
      Course: ['', [Validators.required,Validators.minLength(2),Validators.maxLength(50),Validators.pattern("^[A-Za-z ]+$")]],
      College: ['', [Validators.required]],
      From: ['', [Validators.required]],
      To: ['', [Validators.required]],
      Percentage : ['', [Validators.required,Validators.minLength(1),Validators.maxLength(3),Validators.pattern("([1-9]|[1-9][0-9]|100)")]],

      });

  }

  getUserProfile() {
    this.service.getUserProfile().subscribe({
      next: (data) => {
        this.profileDetails = data,
          console.log(this.profileDetails)
      }
    })
    console.log(this.profileDetails.userid);
  }

  getProfileIdByUserId() {
    this.service.getProfileIdByUserId().subscribe({
      next: (data: any) => {
        this.profileIdDetails = data,
          this.profileId = this.profileIdDetails.profileId,
          console.warn(this.profileId),
          console.log(this.profileIdDetails)
      }

    })
  }

  getCollege() {
    this.service.getCollege().subscribe((data: any) => {
      this.collegeValue = data;
      console.warn(this.collegeValue);
    });

  }
  educationSubmit() {
    this.user.profileId = this.profileId;
    console.log("hi how");
    console.warn(this.user);
    this.service.addEducation(this.user).subscribe(()=>  {this.child.getEducationByProfileId();console.log('posted')});//data=>this.user.push(data)    
     setTimeout(
      () => {
        location.reload(); // the code to execute after the timeout
      },
      500// the time to sleep to delay for
     );
  }
  toogletag() {

    this.showMe = !this.showMe;

  }



  footer() {

    this.foot = !this.foot;

    if (this.foot == false) { this.foot = true };



  }

}
