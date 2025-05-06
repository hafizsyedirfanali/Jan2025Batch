import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

interface Student {
  id: number;
  name: string;
  age: number
  gender: string
}

@Component({
  selector: 'app-interpolation',
  imports: [CommonModule],
  templateUrl: './interpolation.component.html',
  styleUrl: './interpolation.component.css'
})
export class InterpolationComponent {
  //typeScript style
  //typescript is a type safe language, so we need to define the type of the variable
//string name = "Angular"; //c# style
//string[] hobbies = ["Reading", "Traveling", "Cooking"]; //c# style
//var name = "Angular"; //javascript style
name : string = "Angular Teacher";
age : number = 10;
gender : string ="male";
mobileNo : string = "1234567890";
address : string = "123 Main St, City, Country";
  isActive : boolean = false;
  hobbies : string[] = ["Reading", "Traveling", "Cooking"];
student : Student = {
  id:1,
    name: "John Doe",
    age: 20, 
    gender : 'male'
}
students : Student[] = [
  {
    id:1,
    name: "John Doe1",
    age: 20, 
    gender : 'male'
},
{
  id:2,
  name: "John Doe2",
  age: 20, 
  gender : 'male'
},
{
  id:3,
  name: "John Doe3",
  age: 20, 
  gender : 'male'
}

]


}
