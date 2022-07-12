import { Component, Input, OnInit } from '@angular/core';
import { UserserviceService } from '../service/userservice.service';
import { FormGroup,FormBuilder, FormControl, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-achievementcard',
  templateUrl: './achievementcard.component.html',
  styleUrls: ['./achievementcard.component.css']
})
export class AchievementcardComponent implements OnInit {
  // @Input() profileId:number
  profileIdDetails:any;

  totalLength:any;
  page:number=1;
  achievementDetails:any;
  profileId:number;
  constructor(private FB: FormBuilder,private service: UserserviceService,private http: HttpClient) { }
  
  ngOnInit(): void {
    this.getProfileIdByUserId();
  }
  getProfileIdByUserId()
  {
    this.service.getProfileIdByUserId().subscribe({
        next:(data:any)=>{this.profileIdDetails=data,
        this.profileId=this.profileIdDetails.profileId,
        console.warn(this.profileId),
        console.log(this.profileIdDetails),
        this.getAchievementByProfileId();
          }
    })
  }

  getAchievementByProfileId()
  {
    console.log('child called')
    this.service.getAchievementByProfileId(this.profileId).subscribe((data)=>{
      this.achievementDetails=data;
       this.totalLength=this.achievementDetails.length;
       console.warn(this.achievementDetails);
     })
  }

  cancelAchievement(achievementid:number)
  {
    this.service.cancelAchievement(achievementid).subscribe(()=>this.getAchievementByProfileId());

  }


}
