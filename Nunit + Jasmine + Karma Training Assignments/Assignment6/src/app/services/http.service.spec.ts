import { TestBed } from '@angular/core/testing';
import { of } from 'rxjs';
import { Company } from '../model/company';

import { HttpService } from './http.service';

describe('HttpService', () => {
  let service: HttpService;
  let httpClientSpy: {
    get: jasmine.Spy;
    post: jasmine.Spy;
    put: jasmine.Spy;
    delete: jasmine.Spy;
  };
  let company: any;

  beforeEach(() => {
    
    httpClientSpy = jasmine.createSpyObj('HttpClient', [
      'get',
      'post',
      'put',
      'delete',
    ]);
    service = new HttpService(<any>httpClientSpy);
    company = new Company(
      1,
      'gateway@gmail.com',
      'Gateway',
      1000,
      'Ahemdabad',
      true,
      3
    );
  });

  it('HttpService should be created', () => {
    expect(service).toBeTruthy();
  });

  it(`getAllCompanies() function should get list of companies`, (done) => {
    httpClientSpy.get.and.returnValue(of([company]));
    service.getAllCompanies().subscribe((data) => {
      expect(data).toBeTruthy();
      done();
    });
  });

  it(`getById() function should get company by it's Id`, (done) => {
    httpClientSpy.get.and.returnValue(of([company]));
    service.getById(1).subscribe((data) => {
      expect(data).toBeTruthy();
      done();
    });
  });

  it('create() function should create company', (done) => {
    httpClientSpy.post.and.returnValue(of([{}]));
    service.create(company).subscribe((data) => {
      expect(data).toBeTruthy();
      done();
    });
  });

  it(`update() function should update company`, (done) => {
    httpClientSpy.put.and.returnValue(of([company]));
    service.update(company).subscribe((data) => {
      expect(data).toBeTruthy();
      done();
    });
  });

  it(`delete() function should delete company`, (done) => {
    httpClientSpy.delete.and.returnValue(of([{}]));
    service.delete(1).subscribe((data) => {
      expect(data).toBeTruthy();
      done();
    });
  });
  
});