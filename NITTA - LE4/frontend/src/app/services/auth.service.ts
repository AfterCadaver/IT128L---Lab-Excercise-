import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  isLoggedIn: boolean = false;
  public redirectUrl: string = "";

  constructor(private http: HttpClient) {

   }

   login (username: string, password: string){
    return this.http.post<string>("https://localhost:7248/api/login/login", {username, password});
   }
}
