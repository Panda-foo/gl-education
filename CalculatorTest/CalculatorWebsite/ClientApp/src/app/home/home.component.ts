import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})

export class HomeComponent {
  public calculationRequest: CalculationRequest = {
    type: 0
  };

  public calculated: boolean = false;
  public calculation: number;

  public calculationTypes: CalculationType[] = [
    { value: 1, label: 'Addition' },
    { value: 2, label: 'Subtraction' },
    { value: 3, label: 'Multiplication' },
    { value: 4, label: 'Division' },
    { value: 5, label: 'Get Prime Number' }
  ];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getCalculation() {
    this.http.post<number>(this.baseUrl + 'calculator', this.calculationRequest).subscribe(result => {
      this.calculation = result;
      this.calculated = true;
    }, error => console.error(error));
  }
}

interface CalculationType {
  value: number;
  label: string;
}

export interface CalculationRequest {
  type: number,
  start?: number,
  amount?: number,
  by?: number,
  index?: number
}

