import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Recipes } from '../interfaces/Recipes';

@Component({
  selector: 'app-recipes',
  templateUrl: './recipes.component.html',
  styleUrls: ['./recipes.component.css']
})
export class RecipesComponent implements OnInit {
  private baseurl:string;
  private httpClient:HttpClient;
  public recipes: Recipes[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseurl = baseUrl;
    this.httpClient = http;
  }

  ngOnInit() {
    this.fetchData();
  }

  public fetchData(){

    this.httpClient.get<Recipes[]>(this.baseurl + 'api/Recipes').subscribe(result => {
      this.recipes = result;
      console.log(result)
    }, error => console.error(error));
  }

}

