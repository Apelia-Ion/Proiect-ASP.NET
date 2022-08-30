import { Component, OnDestroy, OnInit } from '@angular/core';
import { iRecipe } from '../interfaces/recipe';
import { RECIPES } from '../mock-data/mock-recipes';
import { RecipesService } from '../recipes.service';

@Component({
  selector: 'app-recipes',
  templateUrl: './recipes.component.html',
  styleUrls: ['./recipes.component.css']
})
export class RecipesComponent implements OnInit, OnDestroy {

  

  recipes: iRecipe[] = [];
  selectedRecipe?: iRecipe;


  constructor(private recipeService:RecipesService) { }

  ngOnInit(): void {
    this.getRecipes();
  }
  onSelect(recipe: iRecipe): void {
    this.selectedRecipe = recipe;
  }

  getRecipes():void{
    this.recipes = this.recipeService.getRecipes();
  }
  ngOnDestroy(): void {    
  }

}
