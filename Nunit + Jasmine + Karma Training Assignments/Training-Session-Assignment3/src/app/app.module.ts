import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormComponent } from './form/form.component';
import { InputComponent } from './input/input.component';
import { TableComponent } from './table/table.component';
import { CalculatorComponent } from './calculator/calculator.component';
import { CounterComponent } from './counter/counter.component';
import { CheckNumberComponent } from './check-number/check-number.component';

@NgModule({
  declarations: [
    AppComponent,
    FormComponent,
    InputComponent,
    TableComponent,
    CalculatorComponent,
    CounterComponent,
    CheckNumberComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
