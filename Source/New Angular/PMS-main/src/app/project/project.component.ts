import { Component, OnInit } from '@angular/core';
import { UserserviceService } from '../service/userservice.service';
import { Project } from 'Models/project';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, ParamMap } from '@angular/router';


@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.css']
})
export class ProjectComponent implements OnInit {

  profileId:number=0;
  constructor( private service: UserserviceService, private http: HttpClient,private route: ActivatedRoute) { }
  //  year:any;
  selectedYear: number = 0;
  years: number[] = [];
  // projectId: number = 0;
  // profileId : number = 0;
  Project: any;
  project: Project[] = [];
  data: any;
  projectfield: any = {
    projectId: 0,
    profileId: this.profileId,
    projectName: '',
    projectDescription: '',
    startingMonth: '',
    startingYear: 0,
    endingMonth: '',
    endingYear: 0,
    designation: '',
    toolsUsed: '',

  }



  showMe: boolean = false;

  foot:boolean = true;
  ngOnInit() {
    this.route.params.subscribe(params => {
      this.profileId = params['profileId'];
      console.log('Project profile id : '+this.profileId);
    })

    // this.getProjectbyId();
    this.selectedYear = new Date().getFullYear();
    for (let year = this.selectedYear; year >= 2000; year--) {
      this.years.push(year);
    }
  }
  // getProjectbyId() {
  //   this.service.getProjectDetail(this.projectId).subscribe((res) => {
  //     this.projectfield = res;
  //     this.projectfield.designation = res.role;
  //     console.log(this.projectfield);
  //   })
  // }

  //   getallProjectdetails(){
  //     this.projectService.getallProjectDetailByProfile().subscribe((res)=>{
  //       this.data = res;
  //       console.log(this.data);
  //   })
  //  }

  GetAllProjectDetailsByProfileId() {
    this.service.getProjectDetailByProfileID(this.profileId).subscribe((res) => {
      this.projectfield = res;
      console.log(this.data);
    })
  }
  

  OnSubmit() {

    console.log("Project Field ");
    this.projectfield.profileId=this.profileId;
    console.log(this.projectfield);
    this.service.CreateProjects(this.projectfield).subscribe(data => this.projectfield.push(data));
  }

  Update() {
    this.data = this.projectfield;
    this.service.UpdateProjects(this.data).subscribe(data => this.data.push(data));
  }

  Delete() {
    this.data = this.projectfield;
    // this.projectService.DeleteProjects(this.data).subscribe(data=>this.data.push(data));
  }
  toogletag()

  {

    this.showMe=!this.showMe;

  }



  footer()

  {

    this.foot=!this.foot;

    if(this.foot==false){this.foot=true};

}
}
