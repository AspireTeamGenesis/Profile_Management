import { Component, Input, OnInit } from '@angular/core';
import { UserserviceService } from '../service/userservice.service';
import { FormGroup,FormBuilder, FormControl, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-waitingprofile',
  templateUrl: './waitingprofile.component.html',
  styleUrls: ['./waitingprofile.component.css']
})
export class WaitingprofileComponent implements OnInit {

  profileIdDetails:any;

  totalLength:any;
  page:number=1;
  achievementDetails:any;
  profileId:number;
  waitingProfiles:any;
  constructor(private FB: FormBuilder,private service: UserserviceService,private http: HttpClient) { }
  
  ngOnInit(): void {
    this.getProfileByWaitingStatus();
  }
  getProfileByWaitingStatus()
  {
    this.service.getProfileByWaitingStatus().subscribe({
      next:(data:any)=>{this.waitingProfiles=data,
      console.log(this.waitingProfiles)
        }
  })
  }

}
