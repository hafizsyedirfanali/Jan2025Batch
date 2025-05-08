import { Component,Input } from '@angular/core';
interface Student {
  id: number;
  name: string;
  age: number
  gender: string
}
@Component({
  selector: 'app-child',
  imports: [],
  templateUrl: './child.component.html',
  styleUrl: './child.component.css'
})
export class ChildComponent { 
@Input() message : string = "";
@Input() students : Student[] = [];
}
