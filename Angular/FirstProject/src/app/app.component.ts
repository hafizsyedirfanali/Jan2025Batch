import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { FirstComponent } from './components/first/first.component';
import { SecondComponent } from "./components/second/second.component";
import { FourthComponent } from "./components/fourth/fourth.component";
import { ThirdComponent } from './components/third/third.component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, FirstComponent, SecondComponent,ThirdComponent, FourthComponent],
  standalone:true,
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})

export class AppComponent {
  title = 'FirstProject';
}
