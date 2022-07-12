import { Component, OnInit } from '@angular/core';
import { UserserviceService } from '../service/userservice.service';

@Component({
  selector: 'app-viewprofile',
  templateUrl: './viewprofile.component.html',
  styleUrls: ['./viewprofile.component.css']
})
export class ViewprofileComponent implements OnInit {

  constructor(private service:UserserviceService) { }
  profileId:number=0;
   profileIdDetails:any;
  profileDetails:any;
  userDetails:any;

  showMe:boolean = false;
  showMe1:boolean = false;
  showMe2:boolean = false;
  showMe3:boolean = false;
  showMe4:boolean = false;
  ngOnInit(): void {
    this.getUserDetails();
    this.getProfileIdByUserId();
    // console.log("happy");
    // console.log(this.profileId);
    
   
  }
  toggletag(){
    this.showMe=!this.showMe;
  }
  toggletag1(){
    this.showMe1=!this.showMe1;
  }
  toggletag2(){
    this.showMe2=!this.showMe2;
  }
  toggletag3(){
    this.showMe3=!this.showMe3;
  }
  toggletag4(){
    this.showMe4=!this.showMe4;
  }

  getProfileIdByUserId()
  {
    this.service.getProfileIdByUserId().subscribe({
        next:(data:any)=>{this.profileIdDetails=data,
        this.profileId=this.profileIdDetails.profileId,
        console.warn(this.profileId),
        console.log(this.profileIdDetails),
    this.getProfileByProfileId();
  }
    })
  }
  getProfileByProfileId()
  {
    // this.profileId=this.profileIdDetails.profileid;
    console.error("View :"+this.profileId);
    this.service.getProfileByProfileId(this.profileId).subscribe( {
      next:(data:any)=>{this.profileDetails=data,console.warn(this.profileDetails)}
    })
    console.log("profile details");
    console.log(this.profileDetails);
  }
  getUserDetails()
  {
    this.service.getUserProfile().subscribe( {
      next:(data:any)=>{this.userDetails=data,console.warn(this.userDetails)}
    })
  }
  


}



// import { Component, OnInit } from '@angular/core';
// import { UserserviceService } from '../service/userservice.service';
// import { ActivatedRoute, ParamMap } from '@angular/router';


// @Component({
//   selector: 'app-viewprofile',
//   templateUrl: './viewprofile.component.html',
//   styleUrls: ['./viewprofile.component.css']
// })
// export class ViewprofileComponent implements OnInit {

//   constructor(private service:UserserviceService,private route: ActivatedRoute) { }
//   profileId:number=0;
//   profileDetails:any;
//   userDetails:any;
//   showMe:boolean = false;
//   showMe1:boolean = false;
//   showMe2:boolean = false;
//   showMe3:boolean = false;
//   showMe4:boolean = false;
//   ngOnInit(): void {
//     this.route.params.subscribe(params => {
//       this.profileId = params['profileId'];
//       console.log('View profile id : '+this.profileId);
//     })
//     this.getProfileByProfileId();
//     this.getUserDetails();
   
//   }
//   toggletag(){
//     this.showMe=!this.showMe;
//   }
//   toggletag1(){
//     this.showMe1=!this.showMe1;
//   }
//   toggletag2(){
//     this.showMe2=!this.showMe2;
//   }
//   toggletag3(){
//     this.showMe3=!this.showMe3;
//   }
//   toggletag4(){
//     this.showMe4=!this.showMe4;
//   }
//   getProfileByProfileId()
//   {
//     console.log("View :"+this.profileId);
//     this.service.getProfileByProfileId(this.profileId).subscribe( {
//       next:(data:any)=>{this.profileDetails=data,console.warn(this.profileDetails)}
//     })
//     console.log("profile details");
//     console.log(this.profileDetails);
//   }
//   getUserDetails()
//   {
//     this.service.getUserProfile().subscribe( {
//       next:(data:any)=>{this.userDetails=data,console.warn(this.userDetails)}
//     })
//   }


// }
