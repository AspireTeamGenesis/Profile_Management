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

  profileId: number = 0;
  constructor(private service: UserserviceService, private http: HttpClient, private route: ActivatedRoute) { }
  //  year:any;
  selectedYear: number = 0;
  years: number[] = [];
  // projectId: number = 0;
  // profileId : number = 0;
  Project: any;
  project: Project[] = [];
  data: any;
  profileIdDetails: any;
  projectfield: any = {
    projectId: 0,
    profileId: 0,
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

  foot: boolean = true;
  ngOnInit() {
    this.getProfileIdByUserId()
    this.selectedYear = new Date().getFullYear();
    for (let year = this.selectedYear; year >= 2000; year--) {
      this.years.push(year);
    }
  }
  // GetAllProjectDetailsByProfileId() {
  //   this.service.getProjectDetailByProfileID(this.profileId).subscribe((res) => {
  //     this.projectfield = res;
  //     console.log(this.data);
  //   })
  // }

  getProfileIdByUserId() {
    this.service.getProfileIdByUserId().subscribe({
      next: (data: any) => {
        this.profileIdDetails = data,
          this.profileId = this.profileIdDetails.profileId,
          console.warn(this.profileId),
          console.log(this.profileIdDetails)
      }
    })
  }


  OnSubmit() {

    console.log("Project Field ");
    this.projectfield.profileId = this.profileId;
    console.log(this.projectfield.profileId);
    console.log(this.projectfield);
    this.service.CreateProjects(this.projectfield).subscribe(data => this.projectfield.push(data));
  }

  // Update() {
  //   this.data = this.projectfield;
  //   this.service.UpdateProjects(this.data).subscribe(data => this.data.push(data));
  // }

  // Delete() {
  //   this.data = this.projectfield;
  // }
  toogletag() {

    this.showMe = !this.showMe;

  }



  footer() {

    this.foot = !this.foot;

    if (this.foot == false) { this.foot = true };

  }
}
