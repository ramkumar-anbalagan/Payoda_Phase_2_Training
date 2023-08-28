import { Component } from '@angular/core';
import { TempService } from '../temp.service';

@Component({
  selector: 'app-mortage-input-form',
  templateUrl: './mortage-input-form.component.html',
  styleUrls: ['./mortage-input-form.component.css']
})
export class MortageInputFormComponent {
  constructor(public temservice: TempService) {}
  purchasePrice: number = 0;
  downPayment: number = 0;
  repaymentTime: number = 0;
  interestRate: number = 0;

  calculateLoan(): void {
    this.temservice.loanAmount = this.purchasePrice - this.downPayment;
    const monthlyInterestRate = this.interestRate / 100 / 12;
    const totalPayments = this.repaymentTime * 12;
    this.temservice.monthlyPayment =
      (this.temservice.loanAmount *
        monthlyInterestRate *
        Math.pow(1 + monthlyInterestRate, totalPayments)) /
      (Math.pow(1 + monthlyInterestRate, totalPayments) - 1);
  }
}
