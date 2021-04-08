import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MockReverseComponent } from './mock-reverse.component';

describe('MockReverseComponent', () => {
  let component: MockReverseComponent;
  let fixture: ComponentFixture<MockReverseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MockReverseComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MockReverseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  // Equal
  it('should used to reverse the string', () => {
    expect(component.stringReverse()).toEqual('eroM natehC');
  });
  
  // Not Equal
  it('should used to reverse the string', () => {
    expect(component.stringReverse()).not.toEqual('eroM natehC');
  });
  
});
