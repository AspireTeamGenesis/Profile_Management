import { Component, OnInit } from '@angular/core';
import { UserserviceService } from '../service/userservice.service';
import { FormGroup,FormBuilder, FormControl, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, ParamMap } from '@angular/router';

@Component({
  selector: 'app-editskill',
  templateUrl: './editskill.component.html',
  styleUrls: ['./editskill.component.css']
})
export class EditskillComponent implements OnInit {

  constructor(private FB: FormBuilder,private service: UserserviceService,private http: HttpClient,private route: ActivatedRoute) { }
  domainValue:any;
  technologyValue:any;
  skillid:number=0;

  skill:any;

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.skillid = params['skillid'];
      console.log('Skill Id : ' + this.skillid);
    })
    this.getDomain();
    this.getTechnology();
    this.getSkillDetailsBySkillId(this.skillid);
    
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
  getSkillDetailsBySkillId(skillId:number)
  {
    console.log(skillId);
    this.service.getSkillDetailsBySkillId(skillId).subscribe( (data)=>{
      this.skill=data;
      console.log(this.skill)});
      this.domainValue=this.skill.domainid;
      this.technologyValue=this.skill.technologyid;
  }

  submitSkills()
  {
    console.log(this.skill);
    this.service.updateSkills(this.skill).subscribe();
  }

}
