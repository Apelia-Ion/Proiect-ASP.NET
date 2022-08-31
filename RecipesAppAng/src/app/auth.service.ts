import { HttpClient, HttpClientJsonpModule, HttpHandler, HttpHeaderResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { map, Observable } from 'rxjs';
import { MessageService } from './message.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private authsUrl = 'https://localhost:44306/api/Authentication';
  httpOptions={
    headers : new HttpHeaders({'content-type':'application-Json'})
  }
  constructor(private http: HttpClient, private messageService: MessageService, private router: Router,
    private jwtService : JwtHelperService) { }

  register(userData: any): Observable<any> {
    return this.http.post<any>('${this.authsUrl}/sign-up', userData)
    .pipe(map(() => {
      this.router.navigate(['/login']);
    }));

  }

  login(userData: any): Observable<any> {
    return this.http.post<any>('${this.authsUrl}/login', userData)
    .pipe(map((response : any) => {
      if(response?.token){
        localStorage.setItem('token',response.token);
        this.router.navigate(['/home']);
      }
    }));
  }

  isLoggedIn(){
    const token = localStorage.getItem('token') || ''
    return this.jwtService.isTokenExpired(token);
  }

  logout(){
    localStorage.removeItem('token');
    this.router.navigate(['/login']);
  }

}
