import { Component } from '@angular/core';
import { HeaderComponent } from "../header/header.component";
import { BodyComponent } from "../body/body.component";
import { FooterComponent } from "../footer/footer.component";

@Component({
  selector: 'app-layout',
  imports: [HeaderComponent, BodyComponent, FooterComponent],
  templateUrl: './layout.component.html',
  styleUrl: './layout.component.css'
})
export class LayoutComponent {

}
