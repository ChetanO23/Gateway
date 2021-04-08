import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LowerCaseComponent } from './lower-case.component';

describe('LowerCaseComponent', () => {
  let component: LowerCaseComponent;
  let fixture: ComponentFixture<LowerCaseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LowerCaseComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LowerCaseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  // it('should create', () => {
  //   expect(component).toBeTruthy();
  // });

  // Equal
  it('should used in to convert in lower case', () => {
    expect(component.lowerCase()).toEqual('chetan');
  });

  // Not Equal 
  it('should used in to convert in lower case', () => {
    expect(component.lowerCase()).not.toEqual('Chetan');
  });

});
