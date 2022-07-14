import { Component, Input, OnInit } from '@angular/core';
import { UserserviceService } from '../service/userservice.service';
import { FormGroup,FormBuilder, FormControl, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-declinedprofile',
  templateUrl: './declinedprofile.component.html',
  styleUrls: ['./declinedprofile.component.css']
})
export class DeclinedprofileComponent implements OnInit {

  profileIdDetails:any;

  totalLength:any;
  page:number=1;
  achievementDetails:any;
  profileId:number;
  declinedProfiles:any;
  constructor(private FB: FormBuilder,private service: UserserviceService,private http: HttpClient) { }
  
  ngOnInit(): void {
    this.getProfileByDeclinedStatus();
  }
  getProfileByDeclinedStatus()
  {
    this.service.getProfileByDeclinedStatus().subscribe({
      next:(data:any)=>{this.declinedProfiles=data,
      console.log(this.declinedProfiles)
        }
  })
  }


}
