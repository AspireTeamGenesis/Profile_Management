import { Component, OnInit } from '@angular/core';
import { UserserviceService } from '../service/userservice.service';

@Component({
  selector: 'app-viewprofile',
  templateUrl: './viewprofile.component.html',
  styleUrls: ['./viewprofile.component.css']
})
export class ViewprofileComponent implements OnInit {

  constructor(private service:UserserviceService) { }
  profileId:2;
  profileDetails:any;
  ngOnInit(): void {
    this.getProfileByProfileId();
  }
  getProfileByProfileId()
  {
    this.service.getProfileByProfileId(this.profileId).subscribe( {
      next:(data:any)=>this.profileDetails=data
    })

  }


}
