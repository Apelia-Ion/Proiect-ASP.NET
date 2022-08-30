import { Injectable } from '@angular/core';
import { iRecipe } from './interfaces/recipe';
import { RECIPES } from './mock-data/mock-recipes';

@Injectable({
  providedIn: 'root'
})
export class RecipesService {

  constructor() { }

  getRecipes(): iRecipe[] {
    return RECIPES;
  }
}
