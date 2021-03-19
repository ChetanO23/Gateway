import { ViewChild } from '@angular/core';
import { AfterViewInit, Component } from '@angular/core';
import { ChildComponent } from './child/child.component';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements AfterViewInit {
  @ViewChild(ChildComponent) child: ChildComponent;
  ngAfterViewInit() {
    console.log(this.child.whoAmI()); // message print output
    return this.child.whoAmI();
  }
  title = 'training-sample-project';
}