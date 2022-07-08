import { Component, Input, OnInit} from '@angular/core';
import { UserserviceService } from '../service/userservice.service';
import { FormGroup,FormBuilder, FormControl, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-projectcard',
  templateUrl: './projectcard.component.html',
  styleUrls: ['./projectcard.component.css']
})
export class ProjectcardComponent implements OnInit {
  @Input() profileId:number
  totalLength:any;
  page:number=1;
  projectDetails:any;
  // profileId=2;
  constructor(private FB: FormBuilder,private service: UserserviceService,private http: HttpClient) { }
  
  ngOnInit(): void {
    this.getProjectDetailByProfileID();
  }
  getProjectDetailByProfileID()
  {
    console.log('child called')
    this.service.getProjectDetailByProfileID(this.profileId).subscribe((data)=>{
      this.projectDetails=data;
       this.totalLength=this.projectDetails.length;
       console.log("Hi Project");
       console.warn(this.projectDetails);
     })
     console.log(this.projectDetails);
  }
  // console.log(projectDetails);

  cancelProject(projectid:number)
  {
    this.service.cancelProject(projectid).subscribe(()=>this.getProjectDetailByProfileID());

  }

}
