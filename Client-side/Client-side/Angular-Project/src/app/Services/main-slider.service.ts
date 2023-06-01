import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MainSliderService {

  constructor(private slider:HttpClient) { }
  private Base_URL ='https://localhost:7121/api/Mostpopular';
  GetAllmostpop(): Observable<any[]> {
    return this.slider.get<any[]>(this.Base_URL)
      .pipe(
        map((response: any[]) => response.slice(0, 5))
      );
  }
}
