import { Component, OnInit } from '@angular/core';
import { UserserviceService } from '../service/userservice.service';


@Component({
  selector: 'app-profilehome',
  templateUrl: './profilehome.component.html',
  styleUrls: ['./profilehome.component.css']
})
export class ProfilehomeComponent implements OnInit {
  dashboard:any;

  constructor(private service: UserserviceService) { }

  ngOnInit(): void {
    this.dashboardcount();
  }
  dashboardcount()
  {
    this.service.dashboardcount().subscribe((data) => {
      this.dashboard = data;
      console.log(this.dashboard);
    })
  }
}
