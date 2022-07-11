import { HttpClient } from '@angular/common/http';
import { Component,EventEmitter, OnInit ,Output} from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Domain } from 'Models/domain';
import { College } from 'Models/college';
import { Designation } from 'Models/designation';
import { Technology } from 'Models/technology';
import { ProfileStatus } from 'Models/profilestatus';
import { UserserviceService } from 'src/app/service/userservice.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})

export class SearchComponent implements OnInit {
  designationValue: Designation[] = [];
  DesignationValue: number = 0;
  // College:any;
  collegeValue: College[] = [];
  CollegeValue: number = 0;
  // Domain:any;
  domainValue: Domain[] = [];
  DomainValue: number = 0;
  // Technology : any;
  technologyValue: Technology[] = [];
  TechnologyValue: number = 0;
  ExpMin: string;
  ExpMax: string;
  // ProfileStatus:any;
  profileStatusValue: ProfileStatus[] = [];
  ProfileStatusValue: number = 0;
  searchtext: string;

  
  name:any;
  dashboardCount:any;
  constructor(private FB: FormBuilder, private service: UserserviceService, private http: HttpClient) { }

  @Output()
  SearchTextChanged: EventEmitter<any> = new EventEmitter<any>();
  Onsearch() {
    this.SearchTextChanged.emit(this.searchtext);
  }
  
  ngOnInit(): void {
    this.getDesignation();
    this.getCollege();
    this.getDomain();
    this.getTechnology();
    this.getProfileStatus();
    // this.SearchTextChanged.emit(this.searchtext);

  }
  getProfileStatus() {
    this.service.getProfileStatus().subscribe(data => this.profileStatusValue = data);
  }
  getDesignation() {
    this.service.getDesignation().subscribe(data => this.designationValue = data);
  }
  getCollege() {
    this.service.getCollege().subscribe(data => this.collegeValue = data);
  }
  getDomain() {
    this.service.getDomain().subscribe(data => this.domainValue = data);
  }
  getTechnology() {
    this.service.getTechnology().subscribe(data => this.technologyValue = data);
  }
  OnApply() {
    console.log(this.DesignationValue);
    console.log(this.TechnologyValue);
    console.log(this.CollegeValue);
    console.log(this.DomainValue);
    console.log(this.ExpMax);
    console.log(this.ExpMin);
    // console.log(this.ProfileStatusValue);

    

  }
  


}
