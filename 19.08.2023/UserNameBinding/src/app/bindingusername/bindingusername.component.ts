import { Component } from '@angular/core';

@Component({
  selector: 'app-bindingusername',
  templateUrl: './bindingusername.component.html',
  styleUrls: ['./bindingusername.component.css']
})
export class BindingusernameComponent {

  username :string='';
  showname:string='Guest';

  onClick(){
    this.showname = this.username;

  }
}
