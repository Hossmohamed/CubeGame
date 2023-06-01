import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class FreegameService {

  constructor(private free:HttpClient) { }
  private Base_URL ='https://localhost:7121/api/Freegame';
  GetAllmostpop()
  {
    return this.free.get(this.Base_URL);
  }
}
