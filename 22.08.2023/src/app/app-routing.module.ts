import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GetallstudentsComponent } from './getallstudents/getallstudents.component';
import { GetstudentbyrollnoComponent } from './getstudentbyrollno/getstudentbyrollno.component';
import { AddstudentComponent } from './addstudent/addstudent.component';
import { UpdatestudentComponent } from './updatestudent/updatestudent.component';
import { DeletestudentComponent } from './deletestudent/deletestudent.component';

const routes: Routes = [
  { path : "" , component:GetallstudentsComponent   },
  { path : "studentbyid" , component:GetstudentbyrollnoComponent   },
  { path : "addstudent" , component:AddstudentComponent   },
  { path : "updatestudent" , component:UpdatestudentComponent   },
  { path : "deletestudent" , component:DeletestudentComponent   },

];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
