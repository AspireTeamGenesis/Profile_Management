import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Card11Component } from './card11/card11.component';
import { CardComponent } from './hr/card/card.component';
import { CreateusersComponent } from './hr/createusers/createusers.component';
import { HrhomeComponent } from './hr/hrhome/hrhome.component';
import { LoginComponent } from './hr/login/login.component';
import { SearchComponent } from './hr/search/search.component';

const routes: Routes = [
  {path:"hrhome",component:HrhomeComponent},
  {path:"search",component:SearchComponent},
  {path:"card",component:CardComponent},
  {path:"newcard",component:Card11Component},
  {path:"createuser",component:CreateusersComponent},
  {path:"",component:LoginComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
