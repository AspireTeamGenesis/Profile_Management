import { Component, OnInit } from '@angular/core';
import { UserserviceService } from '../service/userservice.service';
import { FormGroup,FormBuilder, FormControl, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-skills',
  templateUrl: './skills.component.html',
  styleUrls: ['./skills.component.css']
})
export class SkillsComponent implements OnInit {

  constructor(private FB: FormBuilder,private service: UserserviceService,private http: HttpClient) { }
  domainValue:any;
  technologyValue:any;

  skill:any={
    skillId:0,
    profileId:2,
    domainId:0,
    technologyId:0
  }

  ngOnInit(): void {
    this.getDomain();
    this.getTechnology();
    
  }
  getDomain()
  {
    this.service.getDomain().subscribe((data:any)=>
    {
      this.domainValue=data;
    });
  }
  getTechnology()
  {
    this.service.getTechnology().subscribe((data:any)=>
    {
      this.technologyValue=data;
    });
  }

  submitSkills()
  {
    console.log(this.skill);
    this.service.submitSkills(this.skill).subscribe();
  }

}
