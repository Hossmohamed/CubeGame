import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MostpopularService {

  constructor(private pop:HttpClient) { }
  private Base_URL ='https://localhost:7121/api/Mostpopular';
  GetAllmostpop()
  {
    return this.pop.get(this.Base_URL);
  }
}
