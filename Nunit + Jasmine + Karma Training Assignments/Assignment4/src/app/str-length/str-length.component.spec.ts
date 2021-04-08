import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StrLengthComponent } from './str-length.component';

describe('StrLengthComponent', () => {
  let component: StrLengthComponent;
  let fixture: ComponentFixture<StrLengthComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StrLengthComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StrLengthComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  // it('should create', () => {
  //   expect(component).toBeTruthy();
  // });

  // Equal
  it('Should be length true', () => {
    expect(component.stringLength()).toEqual(6);
  });

  // Not Equal
  it('Should be length false', () => {
    expect(component.stringLength()).not.toEqual(6);
  });

  // Not Equal
  it('Should be length true', () => {
    expect(component.stringLength()).not.toEqual(5);
  });


});
