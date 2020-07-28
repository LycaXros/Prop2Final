import { Component, OnInit } from '@angular/core';
import { Step } from '../interfaces/Step';

@Component({
  selector: 'app-step',
  templateUrl: './step.component.html',
  styleUrls: ['./step.component.css']
})
export class StepComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  public stepList: StepC[] = [];
  private simpleStep:StepC= new StepC();

  addStep(){
    this.simpleStep.StepNumber = this.stepList.length + 1;
    this.stepList.push(this.simpleStep);
    this.simpleStep= new StepC();
  }
  removeStep(index:number){
    if(index > -1){
      this.stepList.splice(index, 1);
      this.stepList.forEach((e, i) => {
        e.StepNumber = i+1;
      });
    }
  }

}
class StepC implements Step{
  public StepId: number;
  public StepNumber: number;
  public Content: string;
  public RecipeId: number;
}
