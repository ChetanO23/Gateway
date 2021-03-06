import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule, routingcomponent } from './app-routing.module';
import { AppComponent } from './app.component';
import { ChildComponent } from './child/child.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { HomeComponent } from './home/home.component';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { InterceptorDemo } from './interceptor-demo';
//import { DepartmentComponent } from './department/department.component';
//import { EmployeeComponent } from './employee/employee.component';

@NgModule({
  declarations: [
    AppComponent,
    ChildComponent,
   // DepartmentComponent,
    //EmployeeComponent
    routingcomponent,
   PageNotFoundComponent,
   HomeComponent 
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [HTTP_INTERCEPTORS InterceptorDemo],
  bootstrap: [AppComponent]
})
export class AppModule { }
