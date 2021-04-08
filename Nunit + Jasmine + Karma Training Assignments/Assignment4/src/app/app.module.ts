import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { LowerCaseComponent } from './lower-case/lower-case.component';
import { UpperCaseComponent } from './upper-case/upper-case.component';
import { MockReverseComponent } from './mock-reverse/mock-reverse.component';
import { StrLengthComponent } from './str-length/str-length.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    LowerCaseComponent,
    UpperCaseComponent,
    MockReverseComponent,
    StrLengthComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
