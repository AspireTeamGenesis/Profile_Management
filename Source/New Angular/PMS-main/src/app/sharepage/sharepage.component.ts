import { Component, OnInit } from '@angular/core';
import { Toaster } from 'ngx-toast-notifications';
import { FormBuilder,Validators,FormGroup } from '@angular/forms';
@Component({
  selector: 'app-sharepage',
  templateUrl: './sharepage.component.html',
  styleUrls: ['./sharepage.component.css']
})
export class SharepageComponent implements OnInit {
  shareForm:FormGroup;
  formSubmitted:boolean=false;

  constructor(private toaster: Toaster, private FB: FormBuilder) {
    this.shareForm=this.FB.group({});
   }

  ngOnInit(): void {
    this.shareForm=this.FB.group({
      To: ['', [Validators.required, Validators.pattern("([a-zA-Z0-9-_\.]{5,22})@(aspiresys.com)")]]
    })
  }
  share(){
    this.formSubmitted=true;
    this.toaster.open({ text: 'Profile has been shared successfully via mail', position: 'top-center', type: 'success' })

}
}
