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
  @Input() profileId:number

  totalLength:any;
  page:number=1;
  achievementDetails:any;
  // profileId=2;
  constructor(private FB: FormBuilder,private service: UserserviceService,private http: HttpClient) { }
  
  ngOnInit(): void {
    this.getAchievementByProfileId();
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
