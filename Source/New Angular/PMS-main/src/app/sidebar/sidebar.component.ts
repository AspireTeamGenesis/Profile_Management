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

  userId:number;
  profileDetails:any;
  constructor(private service:UserserviceService,private route: ActivatedRoute,private servicer:AuthenticationService) { }
  ngOnInit(): void {
    this.getUserProfile();
  }
  getUserProfile(){
    this.service.getUserProfile().subscribe( {
      next:(data)=>{this.profileDetails=data,
      console.log(this.profileDetails)}
      
    })
  }
  logout()
  {
    this.servicer.ClearToken();
  }

}
