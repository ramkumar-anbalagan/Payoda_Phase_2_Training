import { Component } from '@angular/core';

@Component({
  selector: 'app-converter',
  templateUrl: './converter.component.html',
  styleUrls: ['./converter.component.css']
})
export class ConverterComponent {

  cel!:any;
  unit!:any;
  result!:any;

  convert(){
    if(this.unit=="cel"){
      this.result=((9/5)*this.cel)+32 +"°C";
    }
    else{
      this.result=(this.cel-32)*(5/9) +"°F";
    }

  }
}
