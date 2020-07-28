import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {  ActivatedRoute  } from '@angular/router';
import { Recipes } from '../interfaces/Recipes';

@Component({
  selector: 'app-recipes-detail',
  templateUrl: './recipes-detail.component.html',
  styleUrls: ['./recipes-detail.component.css']
})
export class RecipesDetailComponent implements OnInit {
  private recipeId:number;
  public Recipe:Recipes;
  constructor(
    private route: ActivatedRoute,
    private http: HttpClient, 
    @Inject('BASE_URL') private baseUrl: string) { }

  ngOnInit() {
    this.route.paramMap.subscribe((params) => {       
      this.recipeId = parseInt(params.get('id'));
    });
    this.loadRecipe();
  }
  loadRecipe(){
    
    this.http.get<Recipes>(this.baseUrl + 'api/Recipes/'+this.recipeId).subscribe(result => {
      this.Recipe = result;
      console.log(result)
    }, error => console.error(error));
  }
}
