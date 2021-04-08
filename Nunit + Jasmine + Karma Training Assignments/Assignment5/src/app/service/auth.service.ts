import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
  
})
export class AuthService {
  
  // login - authentication
  isAuthorized(): boolean
  {
    return !localStorage.getItem('token');
  };
  
  // string length
  stringLen(a:string):any{
    if(a==''){
      return null;
    }
    else {
      return a.length;
    }
  };

  // lower case
  lowerTestCase(lcs:string):any{
    return lcs.toLowerCase();
  };

  // upper case
  upperTestCase(ucs:string):any{
    return ucs.toUpperCase();
  };

  // string reverse
  reverseString(inputString:string):any {
    return inputString.split('').reverse().join('');
  }

}
