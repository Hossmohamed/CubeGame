import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MostPlayedService {

  constructor(private myClient:HttpClient) { }
  private Base_URL = "https://localhost:7121/api/Product/GetAllMostPlayed";
  GetAllMostPlayed(): Observable<any[]> {
    return this.myClient.get<any[]>(this.Base_URL)
      .pipe(
        map((response: any[]) => response.slice(0, 5))
      );
  }}