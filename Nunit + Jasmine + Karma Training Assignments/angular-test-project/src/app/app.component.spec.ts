import { TestBed } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { AppComponent } from './app.component';
import { ComponentFixtureAutoDetect } from '@angular/core/testing';
//test suits (group of tests)
describe('AppComponent', () => {
let fixture: any, app: any;
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [
        RouterTestingModule
      ],
      declarations: [
        AppComponent
      ],
      providers: [
        { provide: ComponentFixtureAutoDetect, useValue: true }
      ],
    }).compileComponents();

    // Arrange
   // fixture = 
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

  it('should render title', () => {
    const fixture = TestBed.createComponent(AppComponent);
   // fixture.detectChanges();
    const compiled = fixture.nativeElement;
   const h1 = fixture.nativeElement.querySelector('h1');
    expect(h1.textContent).toContain(fixture.componentInstance.title); // success
  });
  // add
  it('should have add result', async () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    const result = await app.addFunction(2,3) // Added async method ->22-03-2021
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

  //afterEach(())
});
