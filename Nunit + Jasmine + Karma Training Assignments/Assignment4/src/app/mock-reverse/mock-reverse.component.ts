import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-mock-reverse',
  templateUrl: './mock-reverse.component.html',
  styleUrls: ['./mock-reverse.component.css']
})
export class MockReverseComponent  {

  constructor(private auth:AuthService) { }

  // string reverse
  stringReverse(){
    return this.auth.reverseString('Chetan More');
  }
 
}
