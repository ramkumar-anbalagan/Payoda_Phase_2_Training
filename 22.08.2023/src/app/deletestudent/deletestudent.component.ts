import { Component } from '@angular/core';
import { StudentService } from '../Services/student.service';

@Component({
  selector: 'app-deletestudent',
  templateUrl: './deletestudent.component.html',
  styleUrls: ['./deletestudent.component.css']
})
export class DeletestudentComponent  {
  public students : any;
  id!:number;
  constructor(private studentService: StudentService,
    ) { }


   ngOnInit(): void {

   }

  public DeleteStudent():void
  {
    console.log(this.id);
    this.studentService.DeleteStudent(this.id)
    .subscribe(result =>
      {
        this.students=result
      alert(" Student Removed ");
      });
  }
}
