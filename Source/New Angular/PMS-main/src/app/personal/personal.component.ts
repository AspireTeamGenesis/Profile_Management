import { Component, ViewChild, OnInit } from '@angular/core';
import { UserserviceService } from 'src/app/service/userservice.service';
import { HttpClient, HttpClientModule } from '@angular/common/http';


import { Language } from 'Models/language';
import { BreakDuration } from 'Models/breakduration';
import { SocialMedia } from 'Models/socialMedia';
import { PersonalDetails } from 'Models/personalDetails';
import { FormBuilder } from '@angular/forms';
@Component({
  selector: 'app-personal',
  templateUrl: './personal.component.html',
  styleUrls: ['./personal.component.css']
})
export class PersonalComponent implements OnInit {

  profileId :number;
  imageError: string="";
  cardImageBase64: string = "";
  isImageSaved: boolean = false;
  child: any;
  profileDetails:any;
  profileIdDetails:any;


  showMe: boolean = false;

  foot:boolean = true;
  error: string = ""
  


  constructor(private service: UserserviceService, private http: HttpClient) { }
  ngOnInit(): void {
    this.getUserProfile();
    this.getProfileIdByUserId();
  }

  getUserProfile(){
    this.service.getUserProfile().subscribe( {
      next:(data)=>{this.profileDetails=data,
      console.log(this.profileDetails),
      console.log(this.profileDetails.userid);
    }
      
      
    })
    
  }
  getProfileIdByUserId()
  {
    this.service.getProfileIdByUserId().subscribe({
        next:(data:any)=>{this.profileIdDetails=data,
        this.profileId=this.profileIdDetails.profileId,
        console.warn(this.profileId),
        console.log(this.profileIdDetails)
  }
    })
  }

  languageValue:Language[]=[];
  language:number=0;
  breakdurationValue:BreakDuration[]=[];
  breakduration:number=0;
  socialmediaValue:SocialMedia[]=[];
  socialmedia:number=0;
  
  // personalDetailsId : number = 2;
  Personal:any;
  personal:PersonalDetails[]=[];
  data : any;
  user:any = {
    personalDetailsId:0,
    profileId:0,
    base64header:'',
    image:null,
    objective: '',
    dateOfBirth: '',
    nationality: '',
    dateOfJoining:'',
    userId:0
  }
  languageDetails:any=
  {

  }

    // language:any{
    //   languageId: 0,
    //   languageName: '',
    //   read: '',
    //   write: '',
    //   speak: '',
    // }

    // breakDuration : {
    //   breakDuration_Id: 0,
    //   starting:'',
    //   ending: '',
    // },
    
    // socialmedia : {
    //   socialMedia_Id: 0,
    //   socialMedia_Name: '',
    //   socialMedia_Link: '',
    // }
  
  

  GetAllPersonalDetailsByProfileId(){
    this.service.getPersonalDetailByProfileId(this.profileId).subscribe((res)=>{
      this.user = res;
      console.log(this.data);
  })
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
  // getPersonalDetailsbyId(){
  //   this.userService.getPersonalDetails(this.personalDetailsId).subscribe((res)=>{
  //     this.user = res;
  //     this.user.designation = res.role;
  //     console.log(this.user);
  //   })
  // }


  //   // language: Language | null,
  //   // breakDuration: BreakDuration | null,
  //   // socialmedia: SocialMedia | null,
  //   // education: Education[] | null;
  //   // projects: Projects[] | null;
  //   // skills: Skills[] | null;
  //   // users: User | null,
  //   isActive: true,
  // }

  // personaldata()
  // {
  //   var personalDetails: any={
  //     "personalDetailsId": 0,
  //     "name": this.Name,
  //     "objective": this.Objective,
  //     "dateOfBirth": this.Dateofbirth,
  //     "nationality": this.Nationality,
  //     "mailAddress": this.Email,
  //     "dateOfJoining": this.Dateofjoining,
  //     "languageid": this.LanguageValue,
  //     "breakDurationid": this.BreakdurationValue,
  //     "socialmediaid": this.SocialmediaValue,
  //   };

  //   const headers={'content-type':'application/json'}
  //   console.log(this.personal)
  //   this.http.post<any>('https://localhost:7021/Profile/AddPersonal',this.personal,{headers:headers})
  //   .subscribe((data)=>{
  //     console.log(data)
  //   });
  

  // ngOnInit(): void {
  //   // this.http
  //   //   .get<any>(this.artsrc)
  //   //   .subscribe((data) => {
  //   //     this.data = data;
  //   //     this.totalLength = data.length;
  //   //     console.log(data);
  //   //   });
  // }

  // public data: PersonalDetails[] = [

  // ];

personalSubmit()
{
  this.user.profileId=this.profileIdDetails.profileId;
  this.user.userId=this.profileDetails.userid;
  console.log("User ProfileId");
  console.log(this.user.profileId);
  console.log(this.user.userId); 
  console.log(this.user);
  this.service.addPersonalDetail(this.user).subscribe({next:data=>this.user.push(data),
  error: (error: { error: { message: any; }; }) => {
    this.error = error.error.message;
  
  }
});
}

Update(){
  this.data = this.user;
  this.service.updatePersonalDetail(this.data).subscribe(data=>this.data.push(data));
}

  fileChangeEvent(fileInput:any){
     this.imageError="";

    if(fileInput.target.files && fileInput.target.files[0]){

      const max_size = 20971520;
      const allowed_type = ['image/jpeg', 'image/png'];
      if(fileInput.target.files[0].size > max_size){
         this.imageError = 'maximum file size allowed is '+ max_size / 1000 +'Mb';

        return false;
      }
      console.log(fileInput.target.files[0].type)

      if(!allowed_type.includes(fileInput.target.files[0].type)){
        this.imageError = 'Only images are allowed (either JPG or PNG)';
        return false;
      }

      const reader = new FileReader();
      reader.onload = (e:any) => {
        const image = new Image();
        image.src = e.target.result;
        image.onload = rs =>{

          const imgBase64Path = e.target.result;
          this.cardImageBase64 = imgBase64Path;
          this.cardImageBase64 = this.cardImageBase64.replace("data:image/png;base64,", "");
          this.cardImageBase64 = this.cardImageBase64.replace("data:image/jpg;base64,", "");
          this.cardImageBase64 = this.cardImageBase64.replace("data:image/jpeg;base64,", "");
          this.user.base64header = this.cardImageBase64;
          this.isImageSaved = true;
        }
      };


      reader.readAsDataURL(fileInput.target.files[0]);
    } return false;
    
  }

}
