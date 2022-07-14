import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { FormGroup,FormBuilder, FormControl, Validators } from '@angular/forms';
import { Designation } from 'Models/designation';
import { Organisation } from 'Models/organisation';
import { User} from 'Models/user';
import { UserserviceService } from 'src/app/service/userservice.service';
@Component({
  selector: 'app-createusers',
  templateUrl: './createusers.component.html',
  styleUrls: ['./createusers.component.css']
})
export class CreateusersComponent implements OnInit {
  createusers:any;
  Mobilenumber:any;
  Gender:any;
  Organisation:any;
  Designation:any;
  userValue:User[]=[];
  organisationValue:Organisation[]=[];
  designationValue:Designation[]=[];
  UserId:number=0;
  Name:string='';
  Email:string= '';
  UserName: string='';
  Password: string='';
  GenderValue: number=0;
  CountryCodeValue: string='';
  MobileNumber:string='';
  OrganisationValue:number= 0;
  DesignationValue:number= 0;
  ReportingPersonUsername:string='';
  //TO get the input from the user



  //  registerForm = this.FB.group({
  //     Name: ['', [Validators.required, Validators.pattern('[a-zA-Z]*')]],
  //     Email: ['', [Validators.required, Validators.pattern(/^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/)]],
  //     UserName: ['', [Validators.required, Validators.pattern('[a-zA-Z]*')]],
  //     Password: ['', [Validators.required, Validators.pattern('')]],
  //     GenderValue: ['', [Validators.required, Validators.pattern('[a-zA-Z]*')]],
  //     CountryCodeValue:['',[Validators.required,Validators.pattern('[0-9][+]*')]],
  //     MobileNumber:['',[Validators.required,Validators.pattern('[0-9]*')]],
  //     organisationValue: ['', [Validators.required, Validators.pattern('[a-zA-Z]*')]],
  //     DesignationValue: ['', [Validators.required, Validators.pattern('[a-zA-Z]*')]],
  //     ReportingPerson: ['', [Validators.required, Validators.pattern('[a-zA-Z]*')]],
  // });

  constructor(private FB: FormBuilder,private service:UserserviceService,private http: HttpClient) { }
  
 
  

  ngOnInit(): void {
    this.getOrganisation();
    this.getDesignation();
  }
  getDesignation()
  {
    this.service.getDesignation().subscribe(data => this.designationValue=data);
    console.log(this.designationValue);
    // console.log(data);
  }
  getOrganisation()
  {
    this.service.getOrganisation().subscribe(data => this.organisationValue=data);
    console.log(this.organisationValue);
  }

  userdata(){
    var userDetails:any={
      "userId":0,
     "name": this.Name,
     "email": this.Email,
     "userName": this.UserName,
     "password": this.Password,
    "countryCodeId": this.CountryCodeValue,
     "mobileNumber": this.MobileNumber,
     "genderId":this.GenderValue,
     "organisationId":this.OrganisationValue,
    //  "organisationId":2,
     "designationId":this.DesignationValue,
     "reportingPersonUsername":this.ReportingPersonUsername,
    };
 

     console.log(userDetails);
    this.service.addEmployee(userDetails).subscribe(data=>this.userValue.push(data));//data=>this.user.push(data)
    console.error(this.userValue);
   }


    
}
