import { Component, OnInit } from '@angular/core';
import { ChefService } from '../chef.service';
import { iChef } from '../interfaces/chef';
import { MessageService } from '../message.service';

@Component({
  selector: 'app-chefs',
  templateUrl: './chefs.component.html',
  styleUrls: ['./chefs.component.css']
})
export class ChefsComponent implements OnInit {

  
  chefs: iChef[] = [];
  selectedChef?: iChef;


  constructor(private chefService:ChefService, private messageService: MessageService) { }

  ngOnInit(): void {
    this.getChefs();
  }
  // onSelect(recipe: iRecipe): void {
  //   this.selectedRecipe = recipe;
  //   this.messageService.add(`HeroesComponent: Selected hero id=${recipe.id}`);
  // }

  getChefs():void{
    this.chefService.getChefs().subscribe(chefs =>
      {this.chefs=chefs;})
  }
  ngOnDestroy(): void {    
  }
}
