import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { MessageService } from './message.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';
import { iChef } from './interfaces/chef';

@Injectable({
  providedIn: 'root'
})
export class ChefService {
  private chefsUrl = 'https://localhost:44306/api/Chef';
  constructor(private http: HttpClient, private messageService: MessageService) { }

  getChefs(): Observable<iChef[]> {
    
    return this.http.get<iChef[]>(this.chefsUrl)
    .pipe(
      tap(_ => this.log('fetched chefs')),
      catchError(this.handleError<iChef[]>('getchefs', []))
    );
  }
  getChef(id: number): Observable<iChef> {
    const url = `${this.chefsUrl}/${id}`;
    return this.http.get<iChef>(url).pipe(
      tap(_ => this.log(`fetched chef id=${id}`)),
      catchError(this.handleError<iChef>(`getChef id=${id}`))
    );
  }

  private log(message: string) {
    this.messageService.add(`ChefService: ${message}`);
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

}
