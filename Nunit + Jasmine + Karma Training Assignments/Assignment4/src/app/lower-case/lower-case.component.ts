import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-lower-case',
  templateUrl: './lower-case.component.html',
  styleUrls: ['./lower-case.component.css']
})
export class LowerCaseComponent  {

  constructor(private auth: AuthService) { }

  // lower case
  lowerCase(){
    return this.auth.lowerTestCase('CHETAN');
  }

  

}
