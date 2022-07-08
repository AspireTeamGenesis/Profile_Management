import { Component, OnInit } from '@angular/core';
import { UserserviceService } from '../service/userservice.service';
import { FormGroup,FormBuilder, FormControl, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { College } from 'Models/college';
import { ActivatedRoute, ParamMap } from '@angular/router';


@Component({
  selector: 'app-editeducation',
  templateUrl: './editeducation.component.html',
  styleUrls: ['./editeducation.component.css']
})
export class EditeducationComponent implements OnInit {
  selectedYear: number=0;
  years: number[] = [];
  constructor(private FB: FormBuilder, private service: UserserviceService, private http: HttpClient, private route: ActivatedRoute) {
    this.selectedYear = new Date().getFullYear();
  for (let year = this.selectedYear; year >= 2000; year--) {
    this.years.push(year);
  }
    }
    profileId:number=0;
    // educationId=0;
    collegeValue:any;
  college:number=0;
  educationDetails:any;
  educationid:number=0;

  user:any;
  
  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.educationid = params['educationid'];
      this.profileId=params['profileId']
      console.log('Education id : ' + this.educationid);
      console.log('Profile id : ' + this.profileId);
    })
    this.getCollege();
    console.log('Hello : '+this.educationid);
    this.getEducationDetails(this.educationid);
  }
  getCollege()
  {
    this.service.getCollege().subscribe((data:any)=>
    {
      this.collegeValue=data;
    });
  }
   getEducationDetails(educationId:number)
  {
    console.log(educationId);
    this.service.getEducationDetails(educationId).subscribe( (data)=>{
      this.user=data;
      console.log(this.user)});
      this.collegeValue=this.user.collegeid;
    }
    updateEducation()
    {
      const education = {
        educationId: this.educationid,
        profileId: 7,
        degree: this.user.degree,
        course: this.user.course,
        collegeId:this.user.collegeid,
        starting: this.user.starting,
        ending: this.user.ending,
        percentage: this.user.percentage,
      }
        console.log("update");
        console.log(education);
        this.service.updateEducation(education).subscribe();
    
      }

    }
