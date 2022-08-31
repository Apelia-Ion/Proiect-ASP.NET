import { Injectable } from '@angular/core';
import { iRecipe } from './interfaces/recipe';
// import { RECIPES } from './mock-data/mock-recipes';
import { Observable, of } from 'rxjs';
import { MessageService } from './message.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class RecipesService {

  private recipesUrl = 'https://localhost:44306/api/Recipe';

  constructor( private http: HttpClient, private messageService: MessageService) { }

  getRecipes(): Observable<iRecipe[]> {
    
    return this.http.get<iRecipe[]>(this.recipesUrl)
    .pipe(
      tap(_ => this.log('fetched recipes')),
      catchError(this.handleError<iRecipe[]>('getRecipes', []))
    );
  }

  // getRecipe(id: number): Observable<iRecipe> {
  //   // For now, assume that a hero with the specified `id` always exists.
  //   // Error handling will be added in the next step of the tutorial.
  //   const recipe = RECIPES.find(h => h.id === id)!;
  //   this.log(`RecipeService: fetched recipe id=${id}`);
  //   return of(recipe);
  // }

  getRecipe(id: number): Observable<iRecipe> {
    const url = `${this.recipesUrl}/${id}`;
    return this.http.get<iRecipe>(url).pipe(
      tap(_ => this.log(`fetched recipe id=${id}`)),
      catchError(this.handleError<iRecipe>(`getRecipe id=${id}`))
    );
  }

  private log(message: string) {
    this.messageService.add(`RecipeService: ${message}`);
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // TODO: better job of transforming error for user consumption
      this.log(`${operation} failed: ${error.message}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }

  // getRecipes(): Observable<iRecipe[]> {
  //   return of(RECIPES);
  // }
}
