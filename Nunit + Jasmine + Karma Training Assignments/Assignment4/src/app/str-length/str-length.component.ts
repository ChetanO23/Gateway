import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-str-length',
  templateUrl: './str-length.component.html',
  styleUrls: ['./str-length.component.css']
})
export class StrLengthComponent  {

  constructor(private auth:AuthService) { }

  // string length
  stringLength(){
    return this.auth.stringLen("chetan");
  }
  

}
