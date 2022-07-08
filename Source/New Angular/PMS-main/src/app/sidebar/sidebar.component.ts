import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { AuthenticationService } from '../service/authentication.service';
import { UserserviceService } from '../service/userservice.service';


@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent implements OnInit {
  profileId:number=1;
  userId:number;
  profileDetails:any;
  constructor(private service:UserserviceService,private route: ActivatedRoute,private servicer:AuthenticationService) { }
  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.userId = params['userId'];
      console.log('User id : '+this.userId);
      this.getProfileByProfileId();
    })
    // this.getUserProfile(this.userId);
  }
  getUserProfile(){
    this.service.getUserProfile().subscribe( {
      next:(data)=>{this.profileDetails=data,
      console.log(this.profileDetails)}
      
    })
  }
  getProfileByProfileId()
  {
    console.log("View :"+this.profileId);
    this.service.getProfileByProfileId(this.profileId).subscribe( {
      next:(data:any)=>{this.profileDetails=data,console.warn(this.profileDetails)}
    })
    console.log("profile details");
    //console.log(this.profileDetails);
  }
  logout()
  {
    this.servicer.ClearToken();
  }

}
