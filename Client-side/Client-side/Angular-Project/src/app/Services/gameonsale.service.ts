import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class GameonsaleService {

  constructor(private sale:HttpClient) { }
  private Base_URL ='https://localhost:7121/api/Onsale';
  GetAllmostpop()
  {
    return this.sale.get(this.Base_URL);
  }
}
