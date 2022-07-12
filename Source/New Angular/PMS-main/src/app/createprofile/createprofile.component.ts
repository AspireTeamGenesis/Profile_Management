import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { UserserviceService } from '../service/userservice.service';


@Component({
  selector: 'app-createprofile',
  templateUrl: './createprofile.component.html',
  styleUrls: ['./createprofile.component.css']
})
export class CreateprofileComponent implements OnInit {

  constructor(private service:UserserviceService,private route: ActivatedRoute) { }
  userId:number=0;
  profileDetails:any;
  profileId:number=0;
  ngOnInit(): void {
    this.getUserProfile();
  }

  getUserProfile(){
    this.service.getUserProfile().subscribe( {
      next:(data)=>{this.profileDetails=data,
      console.log(this.profileDetails)}      
    })
    console.log(this.profileDetails.userId);
  }
  createProfile()
  {
    const profile={
      userId:this.profileDetails.userid,
      profileId:0,
      profileStatusId:2

    }
    this.service.createProfile(profile).subscribe();

  }

}
