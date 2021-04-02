import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
 // templateUrl: './app.component.html',
 templateUrl: '<h1>{{title}}</h1>', 
 styleUrls: ['./app.component.css']
})
export class AppComponent {
 title = 'angular-test-project';
  //title = 'first test application';

  // Add
  addFunction = (a:number, b:number) =>
  {
    return a + b; 
  }

  //Positive Add
  //Improve the design of Implementations
  positiveAddFunction = (a:number, b:number) => {
    try
    {
      if(a>0 && b>0)
      {
        return this.addFunction(a,b);
      }
      return 0;
     }
   catch (err) {
      throw new Error("addFunction is not working")
  }
  }

// Substraction
subFunction = (a:number, b:number) =>
{
  return a - b; 
}

// Multiplication
mulFunction = (a:number, b:number) =>
{
  return a * b; 
}

// Allows refactoring
calc = (a:number, b:number, c:String) =>
{
    switch(c){
        case 'Add':
            return this.addFunction(a, b);
            break;
        case 'Subs':
            return this.subFunction(a, b);
            break; 
        case 'Mult':
            return this.mulFunction(a, b);
            break;
    }
    return
  }

  getNumberByString(a:string){
    if(a){
      return a;
    }
    else{
      throw new Error;
      
    }
  }

}

