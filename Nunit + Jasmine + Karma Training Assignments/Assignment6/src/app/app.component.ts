import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Assignment6';
}

getAllUsers = async() => {
  const data = [{Name:"Test", Id:1, Address:"xyz"},{Name:"Test", Id:1, Address:"xyz"}]
  return data
} 