import { Component } from '@angular/core';
import { StudentService } from '../Services/student.service';

@Component({
  selector: 'app-updatestudent',
  templateUrl: './updatestudent.component.html',
  styleUrls: ['./updatestudent.component.css']
})
export class UpdatestudentComponent {
  student:any = {rollno :'',studname :'', addr : '', phno : ''};



  constructor(private studentService: StudentService,
    ) { }

  ngOnInit(): void {
  }

  public UpdateStudentById(){
      return this.studentService.UpdateStudent(this.student.rollno ,this.student)
      .subscribe( result =>
        {
          alert(" Student Updated ");
        }
        );

  }

}
