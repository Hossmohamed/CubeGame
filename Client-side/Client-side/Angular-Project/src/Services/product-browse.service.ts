import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProductBrowseService {

  constructor(private myClient : HttpClient) { }

  private Base_URL = "https://localhost:7121/api/Product"
  private imgs_URL = "https://localhost:7121/api/Product/ImagesProduct"


  GetAllProduct(){

    return this.myClient.get(this.Base_URL)

  }

  GetProductByID(id:any){
    return this.myClient.get(`${this.Base_URL}/${id}`);
  }

  GetProductImageByID(id:any){
    return this.myClient.get(`${this.imgs_URL}?Productid=${id}`);
  }
}
