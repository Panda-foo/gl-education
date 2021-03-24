import { Component, Input, Output, EventEmitter, SimpleChanges } from '@angular/core';
import { CalculationRequest } from '../home/home.component';

@Component({
  selector: 'app-calculation-inputs',
  templateUrl: './calculation-inputs.component.html',
  styleUrls: ['./calculation-inputs.component.css']
})

export class CalculationInputsComponent {
  @Input() calculationRequest: CalculationRequest;
  @Input() type: number;

  renderStart: boolean = false;
  renderAmount: boolean = false;
  renderBy: boolean = false;
  renderIndex: boolean = false;

  ngOnChanges(changes: SimpleChanges) {
    this.determineInputs(changes.type.currentValue);
  }

  determineInputs(type) {
    switch (type) {
      case 0:
        this.renderStart = false;
        this.renderAmount = false;
        this.renderBy = false;
        this.renderIndex = false;
        break;

      case 1:
      case 2:
        this.renderStart = true;
        this.renderAmount = true;
        this.renderBy = false;
        this.renderIndex = false;
        break;

      case 3:
      case 4:
        this.renderStart = true;
        this.renderAmount = false;
        this.renderBy = true;
        this.renderIndex = false;
        break;

      case 5:
        this.renderStart = false;
        this.renderAmount = false;
        this.renderBy = false;
        this.renderIndex = true;
    }
  }
}

