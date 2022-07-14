import { Component, Input, OnInit } from '@angular/core';
import { UserserviceService } from '../service/userservice.service';
import { FormGroup,FormBuilder, FormControl, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
@Component({
  selector: 'app-filtercard',
  templateUrl: './filtercard.component.html',
  styleUrls: ['./filtercard.component.css']
})
export class FiltercardComponent implements OnInit {

  @Input() 
  public filterDetails:any
  totalLength:any;
  profileId:number;
  page:number=1;
  educationDetails:any;
  profileIdDetails:any;
  arraylength:any;
  // profileId=7;
  // hello:100;
  constructor(private FB: FormBuilder,private service: UserserviceService,private http: HttpClient, private route : Router) { }
  
  ngOnInit(): void {
    this.getProfileIdByUserId(); 
    console.log(this.filterDetails);  
    console.error(this.filterDetails.length());  
    this.totalLength=this.filterDetails.length;
    console.log(this.totalLength);
    console.warn(this.profileId);
  }

  getProfileIdByUserId()
  {
    this.service.getProfileIdByUserId().subscribe({
        next:(data:any)=>{this.profileIdDetails=data,
        this.profileId=this.profileIdDetails.profileId,
        console.warn(this.profileId),
        console.log(this.profileIdDetails),
        this.getEducationByProfileId();  }
    })
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

  // navigate(){
  //   this.route.navigate(['/editeducation/this.educationDetails.educationId/this.profileId'])
  // }

  cancelEducation(educationid:number)
  {
    this.service.cancelEducation(educationid).subscribe(()=>this.getEducationByProfileId());
  }

}
