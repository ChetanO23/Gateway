import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-upper-case',
  templateUrl: './upper-case.component.html',
  styleUrls: ['./upper-case.component.css']
})
export class UpperCaseComponent  {

  constructor(private auth:AuthService) { }

 // upper case
 upperCase(){
   return this.auth.upperTestCase('chetan');
 }

}
