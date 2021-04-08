import { TestBed } from '@angular/core/testing';

import { AuthService } from './auth.service';

describe('AuthService', () => {
  let service: AuthService;
  let auth: AuthService;
  let spy:any;
  

  // beforeEach(() => {
  //   TestBed.configureTestingModule({});
  //   service = TestBed.inject(AuthService);
  // });

  beforeEach(() =>{
    auth = new AuthService;
    
    });

  // it('should be created', () => {
  //   expect(service).toBeTruthy();
  // });

  // Authentication through serivce Positive test Case 
  it('Should used for Authentictaion in Positive Test Senario', () =>{
    spy = spyOn(auth, 'isAuthorized').and.returnValue(true);
      expect(auth.isAuthorized()).toBeTruthy();
      expect(auth.isAuthorized).toHaveBeenCalled(); // checks whether fuction 'isAuthorized()' has been called or not;
  });

  // Authentication through serivce Negative test Case
  it('Should used for Authentictaion in Negative Test Senario', () =>{
    spy = spyOn(auth, 'isAuthorized').and.returnValue(false);
      expect(auth.isAuthorized()).toBeFalsy();
      expect(auth.isAuthorized).toHaveBeenCalled();
  });

  // Test Case to check Length of String through Service in Positive Test Case
  it('Should check for Title in Positive Test Case Senario', ()=>{
    
    expect(auth.stringLen('Chetan More')).toEqual(10);
  });

  // Test Case to check Length of String through Service in Negative Test Case
  it('Should check for Title in Negative Test Case Senario', ()=>{
    
    expect(auth.stringLen('Chetan More')).not.toEqual(10);
  });

  // Test Case of Lower Case for String through Service in Positive Test Case
  it('Should check for Title in Positive Test Case Senario', ()=>{
    
    expect(auth.lowerTestCase('CHETAN MORE')).toEqual('chetan more');
  });

  // Test Case of Lower Case for String through Service in Negative Test Case
  it('Should check for Title in Negative Test Case Senario', ()=>{
    
    expect(auth.lowerTestCase('CHETAN MORE')).not.toEqual('chetan more');
  });

  // Test Case of Upper Case for String through Service in Positive Test Case
  it('Should check for Title in Positive Test Case Senario', ()=>{
    
    expect(auth.upperTestCase('chetan more')).toEqual('CHETAN MORE');
  });

  // Test Case of Upper Case for String through Service in Negative Test Case
  it('Should check for Title in Negative Test Case Senario', ()=>{
    
    expect(auth.upperTestCase('chetan more')).not.toEqual('CHETAN MORE');
  });

  // Test of Reverse string in Positive Test Case
  it('Should check for reverse string in Positive Test Case Senario for String:- "Chetan More"', ()=>{
    spy = spyOn(auth,'reverseString').and.returnValue("eroM natehC");
    expect(auth.reverseString('Chetan More')).toEqual("eroM natehC");
    expect(auth.reverseString).toHaveBeenCalled();
  });
 
  // Test of Reverse string in Negative Test Case
  it('Should check for reverse string in Negative Test Case Senario for String:- "Chetan More"', ()=>{
    expect(auth.reverseString('Chetan More')).not.toEqual("eroM natehC");
  });





});
