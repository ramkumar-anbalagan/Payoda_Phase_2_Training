import { Component } from '@angular/core';
import { TempService } from '../temp.service';

@Component({
  selector: 'app-mortage-output-form',
  templateUrl: './mortage-output-form.component.html',
  styleUrls: ['./mortage-output-form.component.css']
})
export class MortageOutputFormComponent {
  constructor(public temservice: TempService) {}
}
