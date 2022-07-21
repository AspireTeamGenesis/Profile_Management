import { Component, ViewChild, OnInit } from '@angular/core';
import { UserserviceService } from 'src/app/service/userservice.service';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { PersonalDetails } from 'Models/personalDetails';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { Toaster } from 'ngx-toast-notifications';
@Component({
  selector: 'app-personal',
  templateUrl: './personal.component.html',
  styleUrls: ['./personal.component.css']
})
export class PersonalComponent implements OnInit {

  profileId: number;
  imageError: string = "";
  cardImageBase64: string = "";
  isImageSaved: boolean = false;
  profileDetails: any;
  profileIdDetails: any;
  response: string = '';

  formSubmitted: boolean = false;
  showMe: boolean = false;
  personalForm: FormGroup;
  foot: boolean = true;
  error: string = "";
  user: any = {
    personalDetailsId: 0,
    profileId: 0,
    base64header: '',
    image: null,
    objective: '',
    dateOfBirth: '',
    nationality: '',
    dateOfJoining: '',
    userId: 0
  }
  constructor(private FB: FormBuilder, private service: UserserviceService, private http: HttpClient, private toaster: Toaster) {
    this.personalForm = this.FB.group({});
  }
  ngOnInit(): void {
    this.personalForm = this.FB.group({
      ProfilePhoto: ['', [Validators.required]],
      Objective: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(500)]],
      DateofBirth: ['', [Validators.required]],
      Nationality: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(40)]],
      DateofJoining: ['', [Validators.required]],
    });
    this.getUserProfile();
    this.getProfileIdByUserId();
  }
  getUserProfile() {
    this.service.getUserProfile().subscribe({
      next: (data) => {
        this.profileDetails = data,
          console.log(this.profileDetails),
          console.log(this.profileDetails.userid);
      }
    })
  }
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
  Personal: any;
  personal: PersonalDetails[] = [];
  data: any;
  languageArray: any = [];
  personalDetails: any;
  toogletag() {

    this.showMe = !this.showMe;

  }
  footer() {
    this.foot = !this.foot;
    if (this.foot == false) { this.foot = true };
  }
  personalSubmit() {

    this.user.profileId = this.profileId;
    this.user.userId = this.profileDetails.userid;
    console.log(this.user);
    this.service.addPersonalDetail(this.user).subscribe(
      {
        next: (data) => this.response = data.message,
        error: (error) => this.error = error.error,
        complete: () => {
          this.clearInputFields(),
            this.toaster.open({ text: 'Personal Details has been created Successfully', position: 'top-center', type: 'success' })
        }
      }
    );
    console.log(this.error);
    console.log(this.response);
  }
  clearInputFields()
   {
    this.formSubmitted = false;
    setTimeout(() => {
      this.response = '';
      this.personalForm.reset();
    }, 1000);

  }
  fileChangeEvent(fileInput: any) {
    this.imageError = "";
    if (fileInput.target.files && fileInput.target.files[0]) {
      const max_size = 20971520;
      const allowed_type = ['image/jpeg', 'image/png'];
      if (fileInput.target.files[0].size > max_size) {
        this.imageError = 'maximum file size allowed is ' + max_size / 1000 + 'Mb';
        return false;
      }
      console.log(fileInput.target.files[0].type)
      if (!allowed_type.includes(fileInput.target.files[0].type)) {
        this.imageError = 'Only images are allowed (either JPG or PNG)';
        return false;
      }
      const reader = new FileReader();
      reader.onload = (e: any) => {
        const image = new Image();
        image.src = e.target.result;
        image.onload = rs => {
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
