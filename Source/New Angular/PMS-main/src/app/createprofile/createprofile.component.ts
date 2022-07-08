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
  profileId:number=6;
  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.userId = params['userid'];
      console.log('User id : '+this.userId);
    })
  }
  createProfile()
  {
    const profile={
      userId:this.userId,
      profileId:0,
      profileStatusId:2

    }
    this.service.createProfile(profile).subscribe();

  }

}
