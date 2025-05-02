import { Component } from '@angular/core';
import { HeaderComponent } from "./header/header.component";
import { BodyComponent } from "./body/body.component";
import { FooterComponent } from "./footer/footer.component";
import { LayoutComponent } from "./layout/layout.component";

@Component({
  selector: 'app-root',
  imports: [HeaderComponent, BodyComponent, FooterComponent, LayoutComponent],
  standalone:true,
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})

export class AppComponent {
  title = 'FirstProject';
}
