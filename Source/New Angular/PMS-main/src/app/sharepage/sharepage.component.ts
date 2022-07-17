import { Component, OnInit } from '@angular/core';
import { Toaster } from 'ngx-toast-notifications';
@Component({
  selector: 'app-sharepage',
  templateUrl: './sharepage.component.html',
  styleUrls: ['./sharepage.component.css']
})
export class SharepageComponent implements OnInit {

  constructor(private toaster: Toaster) { }

  ngOnInit(): void {
  }
  share(){
    this.toaster.open({ text: 'Profile has been shared successfully via mail', position: 'top-center', type: 'success' })

}
}
