import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from '../service/authentication.service';
//import { User } from 'Models/user';
import { UserserviceService } from '../service/userservice.service';
@Component({
  selector: 'app-hrchangepassword',
  templateUrl: './hrchangepassword.component.html',
  styleUrls: ['./hrchangepassword.component.css']
})
export class HrchangepasswordComponent implements OnInit {

  constructor(private service: UserserviceService,private http: HttpClient) { }
  user: any = {

    OldPassword: '',
    NewPassword: '',
    ConfirmPassword: '',

  }

  ngOnInit(): void {
  }
  onSubmit()
  {
    console.log(this.user);
    this.service.onSubmit(this.user).subscribe();
    console.log('on submit works') 
  }
  logout() {
    //this.service.ClearToken();
    console.log('logout works') 
  }

}