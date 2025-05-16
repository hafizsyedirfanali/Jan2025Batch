import { Component } from '@angular/core';
import { SecondComponent } from "../components/second/second.component";
import { FirstComponent } from "../components/first/first.component";
import { ThirdComponent } from "../components/third/third.component";
import { FourthComponent } from "../components/fourth/fourth.component";

@Component({
  selector: 'app-body',
  imports: [SecondComponent, FirstComponent, ThirdComponent, FourthComponent],
  templateUrl: './body.component.html',
  styleUrl: './body.component.css'
})
export class BodyComponent {

}
