import { Component } from '@angular/core';
import { Route } from '@angular/router';
import { routes } from './app-routing.module';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'ProductStore';

  routes: Route[];

  constructor(){
    this.routes = routes;
  }
}
