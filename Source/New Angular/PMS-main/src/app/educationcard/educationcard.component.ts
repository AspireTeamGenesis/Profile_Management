import { Component, Input, OnInit } from '@angular/core';
import { UserserviceService } from '../service/userservice.service';
import { FormGroup,FormBuilder, FormControl, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-educationcard',
  templateUrl: './educationcard.component.html',
  styleUrls: ['./educationcard.component.css']
})
export class EducationcardComponent implements OnInit {
  @Input() 
  public profileId:number
  totalLength:any;
  page:number=1;
  educationDetails:any;
  // profileId=7;
  // hello:100;
  constructor(private FB: FormBuilder,private service: UserserviceService,private http: HttpClient, private route : Router) { }
  
  ngOnInit(): void {
    this.getEducationByProfileId();
    console.warn(this.profileId);
  }
  getEducationByProfileId()
  {
    console.log('child called')
    this.service.getEducationByProfileId(this.profileId).subscribe((data)=>{
      this.educationDetails=data;
       this.totalLength=this.educationDetails.length;
       console.warn(this.educationDetails);
     })
  }

  navigate(){
    this.route.navigate(['/editeducation/this.educationDetails.educationId/this.profileId'])
  }

  cancelEducation(educationid:number)
  {
    this.service.cancelEducation(educationid).subscribe(()=>this.getEducationByProfileId());
  }

}
