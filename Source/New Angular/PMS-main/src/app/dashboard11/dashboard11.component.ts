import { Component, OnInit } from '@angular/core';
import { UserserviceService } from '../service/userservice.service';

@Component({
  selector: 'app-dashboard11',
  templateUrl: './dashboard11.component.html',
  styleUrls: ['./dashboard11.component.css']
})
// export class Dashboard11Component implements OnInit {
//   dashboard:any;
//   constructor(private service:DashboardService) { }

//   ngOnInit() : void{
//     this.dashboardcount();
//   }
//   dashboardcount()
//   {
//     this.service.dashboardcount().subscribe((data) => {
//       this.dashboard = data;
//       console.log(this.dashboard);
//     })
//   }


// }
// import { Component, OnInit } from '@angular/core';



export class Dashboard11Component implements OnInit {
  dashboard:any;
  designationValue:any;
  domainValue:any;
  technologyValue:any;
  collegeValue:any;
  profileValue:any;
  filterValue:any;
  experience: number[] = [];
  // username:any;


  constructor(private service: UserserviceService) {
    for (let exp = 1 ; exp < 20; exp++) {
      this.experience.push(exp);
    }
   }

  filter:any={
    designationId:0,
    domainId:0,
    technologyId:0,
    collegeId:0,
    maxExp:0,
    minExp:0,
    profileStatusId:0,
    username:''
  }

  ngOnInit(): void {
    this.dashboardcount();
    this.getDesignation();
    this.getDomain();
    this.getTechnology();
    this.getCollege();
    this.getProfileStatus();
  }
  dashboardcount()
  {
    this.service.dashboardcount().subscribe((data) => {
      this.dashboard = data;
      console.log(this.dashboard);
    })
  }

  getDesignation()
  {
    this.service.getDesignation().subscribe((data:any)=>
    {
      this.designationValue=data;
      console.warn(this.designationValue);
    });

  }

  getDomain()
  {
    this.service.getDomain().subscribe((data:any)=>
    {
      this.domainValue=data;
      console.warn(this.domainValue);
    });

  }

  getTechnology()
  {
    this.service.getTechnology().subscribe((data:any)=>
    {
      this.technologyValue=data;
      console.warn(this.technologyValue);
    });

  }

  getCollege()
  {
    this.service.getCollege().subscribe((data:any)=>
    {
      this.collegeValue=data;
      console.warn(this.collegeValue);
    });

  }

  getProfileStatus()
  {
    this.service.getProfileStatus().subscribe((data:any)=>
    {
      this.profileValue=data;
      console.warn(this.profileValue);
    });

  }

  getProfileByFilters()
  {
    console.warn(this.filter);
    this.service.getProfileByFilters(this.filter).subscribe((data:any)=>
    {
      this.filterValue=data;
      console.warn(this.filterValue);
    });
  }

  // getProfileBySearch()
  // {
  //   console.warn(this.username);
  //   this.service.getProfileBySearch(this.username).subscribe();
  // }



}

