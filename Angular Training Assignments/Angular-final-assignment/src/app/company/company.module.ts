import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {RouterModule} from '@angular/router'
import { AddCompanyComponent } from './add-company/add-company.component';
import { EditCompanyComponent } from './edit-company/edit-company.component';
import { ListCompanyComponent } from './list-company/list-company.component';
import { DashboardCompanyComponent } from './dashboard-company/dashboard-company.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [AddCompanyComponent, EditCompanyComponent, ListCompanyComponent, DashboardCompanyComponent],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule
  ],

  exports: [
    AddCompanyComponent,
    EditCompanyComponent,
    ListCompanyComponent,
    DashboardCompanyComponent
  ]
})
export class CompanyModule { }
