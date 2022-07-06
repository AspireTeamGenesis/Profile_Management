import { Component, OnInit } from '@angular/core';
import { UserserviceService } from '../service/userservice.service';
import { FormGroup,FormBuilder, FormControl, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-educationcard',
  templateUrl: './educationcard.component.html',
  styleUrls: ['./educationcard.component.css']
})
export class EducationcardComponent implements OnInit {
  totalLength:any;
  page:number=1;
  educationDetails:any;
  profileId=7;
  hello:100;
  constructor(private FB: FormBuilder,private service: UserserviceService,private http: HttpClient) { }
  
  ngOnInit(): void {
    this.getEducationByProfileId();
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

  cancelEducation(educationid:number)
  {
    this.service.cancelEducation(educationid).subscribe(()=>this.getEducationByProfileId());

  }

}
