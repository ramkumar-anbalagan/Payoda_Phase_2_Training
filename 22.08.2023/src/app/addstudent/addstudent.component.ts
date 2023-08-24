import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { StudentService } from '../Services/student.service';


@Component({
  selector: 'app-addstudent',
  templateUrl: './addstudent.component.html',
  styleUrls: ['./addstudent.component.css']
})
export class AddstudentComponent implements OnInit{

  public AddStudentForm! : FormGroup;

  constructor(private formBuilder:FormBuilder,
   private studentService:StudentService ) {}

   ngOnInit(): void {
     this.init();
   }

   private init() : void
   {
     this.AddStudentForm = this.formBuilder.group({
       rollno:[],
       studname:[],
       addr:[],
       phno:[]
     });
   }

   public AddNewStudent():void
   {
     this.studentService.AddStudent(this.AddStudentForm.value)
     .subscribe(result =>
       {
       alert(" Student Added ");
       });
   }

}
