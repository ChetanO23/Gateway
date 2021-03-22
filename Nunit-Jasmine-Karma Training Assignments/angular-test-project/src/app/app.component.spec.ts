import { TestBed } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { AppComponent } from './app.component';

//test suits (group of tests)
describe('AppComponent', () => {
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [
        RouterTestingModule
      ],
      declarations: [
        AppComponent
      ],
    }).compileComponents();
  });

  it('should create the app', () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    expect(app).toBeTruthy(); // success
  });

  it(`should have as title 'angular-test-project'`, () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    expect(app.title).toEqual('angular-test-project'); // success
  });

  it('should render title', () => {
    const fixture = TestBed.createComponent(AppComponent);
    fixture.detectChanges();
    const compiled = fixture.nativeElement;
    expect(compiled.querySelector('.content span').textContent).toContain('angular-test-project app is running!'); // success
  });
  // add
  it('should have add result', () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    const result = app.addFunction(2,3)
    expect(result).toEqual(5);  // success
  });

  // Positive Add
  it('should have positive add result', () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    const result = app.positiveAddFunction(-2,-3)
    const result1 = app.positiveAddFunction(2,3)
    expect(result).toEqual(-5);  // fail
    expect(result1).toEqual(5); // success
  });

  it('should return add result by args', () => {
    //Arrange
    const a = 2;
    const b = 5;

    //Act
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    const result = app.addFunction(a,b);
    
    //Assert 
    expect(result).toEqual(7); //success 
  });

  it('should return add result by negative args', () => {
    //Arrange
    const a = -8;
    const b = -5;

    //Act
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    const result = app.addFunction(a,b);
    
    //Assert 
    expect(result).toEqual(-13); //success 
  });

  it('should return positive add function result by negative args', () => {
    //Arrange
    const a = -8;
    const b = -5;
    const a1 = 9;
    const b1 = 6;

    //Act
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    const result = app.positiveAddFunction(a,b);
    const result1 = app.positiveAddFunction(a1,b1);
    
    //Assert 
    expect(result).toEqual(0); // fail
    expect(result1).toEqual(15); // success 
  });

  // substraction
  it('should have sub result', () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    const result = app.subFunction(5,3)
    expect(result).toEqual(2);  // success
  });

  // multiplication
  it('should have mul result', () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    const result = app.mulFunction(2,3)
    expect(result).toEqual(6);  // success
  });

});
