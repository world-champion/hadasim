import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../Models/User';

@Injectable({
  providedIn: 'root'
})
export class UserServiceService {

  constructor(private http:HttpClient) { }
  apiUrl="https://localhost:7247/api/User"
  getUsers():Observable<User[]>{
    return this.http.get<User[]>("");
  }
  addUser(user:User):Observable<User>{
    
    return this.http.post<User>(`${this.apiUrl}`,user);
  }
}
