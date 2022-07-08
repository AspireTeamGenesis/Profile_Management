import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { AuthenticationService } from '../service/authentication.service';
import { UserserviceService } from '../service/userservice.service';
import { animate, animateChild, query, style, transition, trigger } from '@angular/animations';



@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css'],
  animations: [

    trigger('ngIfAnimation', [
      transition(':enter, :leave', [
        query('@*', animateChild())
      ])

    ]),
    trigger('easeInOut', [

      transition('void => *', [
        style({
          opacity: 0
        }),
        animate("500ms ease-in", style({
          opacity: 1
        }))
      ]),
      transition('* => void', [
        style({
          opacity: 1
        }),
        animate("500ms ease-in", style({
          opacity: 0
        }))

      ])
    ])
  ]
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
    console.log(this.profileDetails.userId);
  }
  logout()
  {
    this.servicer.ClearToken();
  }
  isShowDivIf = false;
  toggleSidebar() {
    this.isShowDivIf = !this.isShowDivIf;
  }

}
