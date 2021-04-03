import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormComponent } from './form.component';

describe('FormComponent', () => {
  let component: FormComponent;
  let fixture: ComponentFixture<FormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

   // Form should be invalid
   it('form should be invalid', () => {
    component.userForm.controls['email'].setValue('');
    component.userForm.controls['username'].setValue('');
    expect(component.userForm.valid).toBeFalsy();
  })

  // Form should be valid
  it('form should be valid', () => {
    component.userForm.controls['email'].setValue('xyz@gmail.com');
    component.userForm.controls['username'].setValue('xyz');
    expect(component.userForm.valid).toBeTruthy();
  })

});
