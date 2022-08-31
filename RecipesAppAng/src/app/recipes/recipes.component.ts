import { Component, OnDestroy, OnInit } from '@angular/core';
import { iRecipe } from '../interfaces/recipe';
// import { RECIPES } from '../mock-data/mock-recipes';
import { RecipesService } from '../recipes.service';
import { MessageService } from '../message.service';

@Component({
  selector: 'app-recipes',
  templateUrl: './recipes.component.html',
  styleUrls: ['./recipes.component.css']
})
export class RecipesComponent implements OnInit, OnDestroy {

  

  recipes: iRecipe[] = [];
  selectedRecipe?: iRecipe;


  constructor(private recipeService:RecipesService, private messageService: MessageService) { }

  ngOnInit(): void {
    this.getRecipes();
  }
  // onSelect(recipe: iRecipe): void {
  //   this.selectedRecipe = recipe;
  //   this.messageService.add(`HeroesComponent: Selected hero id=${recipe.id}`);
  // }

  getRecipes():void{
    this.recipeService.getRecipes().subscribe(recipes =>
      {this.recipes=recipes;})
  }
  ngOnDestroy(): void {    
  }

}
