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
    this.route.params.subscribe(params => {
      this.userId = params['userId'];
      console.log('User id : '+this.userId);
    })
    // this.getUserProfile(this.userId);
  }
  getUserProfile(userId:number){
    this.service.getUserDetails(userId).subscribe( {
      next:(data)=>this.profileDetails=data
    })
  }
  logout()
  {
    this.servicer.ClearToken();
  }

}
