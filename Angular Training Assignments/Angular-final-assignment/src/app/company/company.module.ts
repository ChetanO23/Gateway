import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AddCompanyComponent } from './add-company/add-company.component';
import { EditCompanyComponent } from './edit-company/edit-company.component';
import { ListCompanyComponent } from './list-company/list-company.component';
import { DashboardCompanyComponent } from './dashboard-company/dashboard-company.component';



@NgModule({
  declarations: [AddCompanyComponent, EditCompanyComponent, ListCompanyComponent, DashboardCompanyComponent],
  imports: [
    CommonModule
  ]
})
export class CompanyModule { }
