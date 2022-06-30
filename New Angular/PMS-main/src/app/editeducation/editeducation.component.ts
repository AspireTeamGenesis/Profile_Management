import { Component, OnInit } from '@angular/core';
import { UserserviceService } from '../service/userservice.service';
import { FormGroup,FormBuilder, FormControl, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { College } from 'Models/college';

@Component({
  selector: 'app-editeducation',
  templateUrl: './editeducation.component.html',
  styleUrls: ['./editeducation.component.css']
})
export class EditeducationComponent implements OnInit {
  selectedYear: number=0;
  years: number[] = [];
  constructor(private FB: FormBuilder,private service: UserserviceService,private http: HttpClient) {
    this.selectedYear = new Date().getFullYear();
  for (let year = this.selectedYear; year >= 2000; year--) {
    this.years.push(year);
  }
    }
    educationId=7;
    collegeValue:College[]=[];
  college:number=0;
  educationDetails:any;

  user:any = {
    educationId: this.educationId,
    profileId: 7,
    degree: '',
    course: '',
    collegeId:0,
    starting: 0,
    ending: 0,
    percentage: 0,
  }

  ngOnInit(): void {
    this.getCollege();
    this.getEducationDetails(this.user.educationId);
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
    }
    updateEducation()
    {
      const education = {
        educationId: this.educationId,
        profileId: 7,
        degree: this.user.degree,
        course: this.user.course,
        collegeId:this.user.collegeId,
        starting: this.user.starting,
        ending: this.user.ending,
        percentage: this.user.percentage,
      }
        console.log("update");
        console.log(education);
        this.service.updateEducation(education).subscribe();
    
      }

    }
