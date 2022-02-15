import { asLiteral } from '@angular/compiler/src/render3/view/util';
import { Component } from '@angular/core';
import { TaschenrechnerService } from '../service/Taschenrechner.service';

@Component({
  selector: 'app-taschenrechner',
  templateUrl: './Taschenrechner.component.html',
})
export class TaschenrechnerComponent {
  public textValue = '';

  constructor(private taschenrechnerService: TaschenrechnerService) { }

  public Clear(): void {
    this.taschenrechnerService.getClear().subscribe((result: string) => { this.textValue = result.toString(); });
  }

  public Oper(value: string): void {
    this.taschenrechnerService.getOper(value).subscribe((result: string) => { this.textValue = result.toString(); });
  }

  public Calc(): void {
    this.taschenrechnerService.getEqual().subscribe((result: string) => { this.textValue = result.toString(); });
  }
}