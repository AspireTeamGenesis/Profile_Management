import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { User} from 'Models/user';
import { Designation } from 'Models/designation';
import { Organisation } from 'Models/organisation';
import { AuthenticationService } from './authentication.service';


@Injectable({
  providedIn: 'root'
})
export class UserserviceService {

  // headers= new HttpHeaders({ 
  //     'Access-Control-Allow-Origin':'*',
  //     'Access-Control-Allow-Methods': '*',
  //     'Access-Control-Allow-Headers':'*'
  //   })

  baseURL = 'https://localhost:7071/'
  constructor(private http: HttpClient) { }

  private headers = new HttpHeaders({
    'Content-Type': 'application/json',
    'Authorization': `Bearer ${AuthenticationService.GetData("token")}`
  })

  private header = new HttpHeaders({
    'Content-Type': 'application/json',
  })
  // headers = new HttpHeaders({
  //   'Content-Type': 'application/json',
  // })
  // constructor(private http: HttpClient) { }

  getDesignation():Observable<Designation[]>
  {
    return this.http.get<Designation[]>('https://localhost:7021/Designation/ViewDesignations');
  }

  
  getOrganisation():Observable<Organisation[]>
  {
    return this.http.get<Organisation[]>('https://localhost:7021/Organisation/ViewOrganisations');
  }


  Login(user:any)
  {
       return this.http.post<any>(`https://localhost:7021/Login/AuthLogin/Login?Username=${user.UserName}&password=${user.Password}`, user, { headers: this.header })
  
  }
  // Login(user: any) {
  //   return this.http.post<any>(`https://localhost:7021/Login/AuthLogin/Login?Username=${user.UserName}&password=${user.Password}`, user, { headers: this.header })
  // }

  addEmployee(userValue:User):Observable<User>
  {
  const url='https://localhost:7021/User/AddUser';
  console.warn(userValue);
  return this.http.post<User>(url,userValue,{headers : this.headers});
  }

}
  
