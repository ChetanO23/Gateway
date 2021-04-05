import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddCompanyComponent } from './company/add-company/add-company.component';
import { DashboardCompanyComponent } from './company/dashboard-company/dashboard-company.component';
import { EditCompanyComponent } from './company/edit-company/edit-company.component';
import { ListCompanyComponent } from './company/list-company/list-company.component';

const routes: Routes = [
  {
    path:'',    
    redirectTo: 'dashboard-company',    
    pathMatch: 'full',    
  },
  
  {
    path : 'dashboard-company',
    component : DashboardCompanyComponent
  },
  {
    path : 'add-company',
    component : AddCompanyComponent
  },
  {
    path : 'edit-company',
    component : EditCompanyComponent
  },
  {
    path : 'list-company',
    component : ListCompanyComponent
  },
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
