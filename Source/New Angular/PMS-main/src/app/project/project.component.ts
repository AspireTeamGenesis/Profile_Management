import { Component, OnInit } from '@angular/core';
import { UserserviceService } from '../service/userservice.service';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { FormBuilder,Validators,FormGroup } from '@angular/forms';
import { Toaster } from 'ngx-toast-notifications';


@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.css']
})
export class ProjectComponent implements OnInit {

  profileId:number=0;
  projectForm:FormGroup;
  formSubmitted: boolean = false;
  error=''
  constructor( private FB:FormBuilder ,private service: UserserviceService, private http: HttpClient,private route: ActivatedRoute, private toaster:Toaster) {
    this.projectForm=this.FB.group({});
   }
  //  year:any;
  selectedYear: number = 0;
  years: number[] = [];
  // projectId: number = 0;
  // profileId : number = 0;
  // Project: any;
  // project: Project[] = [];
  // data: any;
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
    this.projectForm=this.FB.group({
      ProjectName: ['', [Validators.required,Validators.minLength(3),Validators.maxLength(100)]],
      ProjectDescription: ['', [Validators.required,Validators.minLength(3),Validators.maxLength(500)]],
      StartingMonth: ['', [Validators.required,Validators.minLength(3),Validators.maxLength(9)]],
      StartingYear: ['', [Validators.required]],
      EndingMonth: ['', [Validators.required,Validators.minLength(3),Validators.maxLength(9)]],
      EndingYear: ['', [Validators.required]],
      RolePlayed: ['', [Validators.required,Validators.minLength(2),Validators.maxLength(100)]],
      ToolsUsed: ['', [Validators.required,Validators.minLength(3),Validators.maxLength(300)]],
    });

    this.getProfileIdByUserId()
    this.selectedYear = new Date().getFullYear();
    for (let year = this.selectedYear; year >= 2000; year--) {
      this.years.push(year);
    }
  }
  getProfileIdByUserId() {
    this.service.getProfileIdByUserId().subscribe({
      next: (data) => {
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
    this.service.CreateProjects(this.projectfield).subscribe({
      next: (data) => { },
      error: (error) => { this.error = error.error.message },
      complete: () => {
        this.toaster.open({ text: 'Project details added successfully', position: 'top-center', type: 'success' });
      }
    });
    setTimeout(
      () => {
        location.reload(); // the code to execute after the timeout
      },
      1000// the time to sleep to delay for
    );
  }
  toogletag() {

    this.showMe = !this.showMe;

  }
  footer() {

    this.foot = !this.foot;

    if (this.foot == false) { this.foot = true };

  }
}
