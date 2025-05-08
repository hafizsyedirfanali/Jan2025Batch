import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ChildComponent } from "../child/child.component";

interface Student {
  id: number;
  name: string;
  age: number
  gender: string
}

@Component({
  selector: 'app-interpolation',
  imports: [CommonModule, FormsModule, ChildComponent],
  templateUrl: './interpolation.component.html',
  styleUrl: './interpolation.component.css',
  changeDetection: ChangeDetectionStrategy.OnPush// // OnPush is used to optimize the performance of the component by reducing the number of change detection cycles
  // Default is used to check the change detection for every change in the component
  // changeDetection: ChangeDetectionStrategy.Default
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
  isActive : boolean = true;
  hobbies : string[] = ["Reading", "Traveling", "Cooking"];

switchCondition : "Yes"|"No"|"Invalid" = "Invalid";
iconPath:string = "https://cdn-icons-png.flaticon.com/512/25/25231.png";
altImage = "GitHub Logo";
newStudent : Student = {
  id:0,
  name: "Irfan",
  gender: "",
  age: 0,
};
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

// function clickJsFunction(){

// }

clickFunction():void {
  alert("Hello world");
}

addStudent():void {
  this.students.push(this.newStudent);
  this.newStudent = {
    id:0,
    name:"",
    age:0,
    gender:""
  }
}

}
