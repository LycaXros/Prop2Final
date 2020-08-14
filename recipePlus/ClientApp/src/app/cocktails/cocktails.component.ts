import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-cocktails',
  templateUrl: './cocktails.component.html',
  styleUrls: ['./cocktails.component.css']
})
export class CocktailsComponent implements OnInit {
  public showButton:boolean = false;
  public categories: string[];
  public drinks: drinksByCat[];
  public selectedCategories: string;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.categories = [];
    this.http.get<any>("https://www.thecocktaildb.com/api/json/v1/1/list.php?c=list")
    .subscribe( 
      result => {
        console.log(result);
        result.drinks.forEach(element => {
          this.categories.push(element.strCategory);

        });
      }
      , error => console.error(error));
    
  }
  ShowSelected(){
    console.log(this.selectedCategories);
    this.http.get<any>("https://www.thecocktaildb.com/api/json/v1/1/filter.php?c="+this.selectedCategories)
    .subscribe(res => {
      console.log(this.drinks);
      this.drinks = res.drinks;
      console.log(this.drinks);
    }, error => console.error(error));
    //https://www.thecocktaildb.com/api/json/v1/1/filter.php?c=Ordinary_Drink
  }
  onChange(newValue:string){
    this.selectedCategories=newValue;
  }
}

interface drinksByCat{
  idDrink:string;
  strDrink:string;
  strDrinkThumb:string;
}