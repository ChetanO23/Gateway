import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TableComponent } from './table.component';

describe('TableComponent', () => {
  let component: TableComponent;
  let fixture: ComponentFixture<TableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TableComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  // Table should have proper data
  it('should have proper data', () => {
    component.users = [{
      name: 'xyz',
      email: 'xyz@gmail.com'
    }
  ]
  fixture.detectChanges();
  const element = fixture.debugElement.nativeElement.querySelector('tr').querySelector('td')
  expect(element.textContent).toContain('xyz');
  });
});
