import { TestBed, fakeAsync, tick} from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { AppComponent } from './app.component';

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
    expect(app).toBeTruthy();
  });

  it(`should have as title 'Assignment6'`, () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.componentInstance;
    expect(app.title).toEqual('Assignment6');
  });

  it('should render title', () => {
    const fixture = TestBed.createComponent(AppComponent);
    fixture.detectChanges();
    const compiled = fixture.nativeElement;
    expect(compiled.querySelector('.content span').textContent).toContain('Assignment6 app is running!');
  });

  it('should return user data', async() => {
    
    // Act
    const result = await component.getAllusers();
    
    // Assert
    expect(result).toBeTruthy();
    expect(result.length).toBe(2);
  });

  it('should return user data', (done) => {
    
    // Act
    const result = component.getAllusers().then(value => {
      
    });
    
    // Assert
    expect(result).toBeTruthy();
    expect(result.length).toBe(2);
  });

  it('should return user data with fake async', fakeAsync(() => { (1)
    // Act
    const result = component.getAllusers().then(value => {
    
    tick(); (2)
    // Assert
    expect(result).toBeTruthy();
    expect(result.length).toBe(2);
 }));
});
