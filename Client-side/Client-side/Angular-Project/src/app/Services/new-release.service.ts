import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class NewReleaseService {

  constructor(private myClient:HttpClient) { }
  private base_URL = "https://localhost:7121/api/Newrelease";

  GetAllNewRelease(): Observable<any[]> {
    return this.myClient.get<any[]>(this.base_URL)
      .pipe(
        map((response: any[]) => response.slice(0, 5))
      );
  }
}
