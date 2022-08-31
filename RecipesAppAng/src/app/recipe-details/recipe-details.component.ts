import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { iRecipe } from '../interfaces/recipe';
import { RecipesService } from '../recipes.service';
import { Location } from '@angular/common';

@Component({
  selector: 'app-recipe-details',
  templateUrl: './recipe-details.component.html',
  styleUrls: ['./recipe-details.component.css']
})
export class RecipeDetailsComponent implements OnInit {

  recipe: iRecipe | undefined;

  constructor(
    private route: ActivatedRoute,
    private recipesService: RecipesService,
    private location: Location
  ) {}

  ngOnInit(): void {
    this.getHero();
  }

  getHero(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.recipesService.getRecipe(id)
      .subscribe(recipe => this.recipe = recipe);
  }

  goBack(): void {
    this.location.back();
  }

}
