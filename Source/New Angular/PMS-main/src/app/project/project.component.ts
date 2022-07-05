import { Component, OnInit } from '@angular/core';
import { UserserviceService } from '../service/userservice.service';
import { Project } from 'Models/project';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.css']
})
export class ProjectComponent implements OnInit {

  profileId = 4;
  constructor( private service: UserserviceService, private http: HttpClient) { }
  //  year:any;
  selectedYear: number = 0;
  years: number[] = [];
  projectId: number = 3;
  // profileId : number = 4;
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
  ngOnInit() {

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

}
