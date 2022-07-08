import { Component, Input, OnInit } from '@angular/core';
import { UserserviceService } from '../service/userservice.service';
import { FormGroup,FormBuilder, FormControl, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-skillcard',
  templateUrl: './skillcard.component.html',
  styleUrls: ['./skillcard.component.css']
})
export class SkillcardComponent implements OnInit {
  @Input() profileId:number
  totalLength:any;
  page:number=1;
  skillDetails:any;
  // profileId=2;
  constructor(private FB: FormBuilder,private service: UserserviceService,private http: HttpClient) { }

  ngOnInit(): void {
    this.getSkillByProfileId();
  }
  getSkillByProfileId()
  {
    console.log('child called')
    this.service.getSkillByProfileId(this.profileId).subscribe((data)=>{
      this.skillDetails=data;
       this.totalLength=this.skillDetails.length;
       console.warn(this.skillDetails);
     })
  }

  cancelSkill(skillid:any)
  {
    this.service.cancelSkill(skillid).subscribe(()=>this.getSkillByProfileId());
  }
}
