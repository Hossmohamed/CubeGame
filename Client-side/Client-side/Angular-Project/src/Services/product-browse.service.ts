import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProductBrowseService {

  constructor(private myClient : HttpClient) { }

  private Base_URL = "https://localhost:7121/api/Product"
  private imgs_URL = "https://localhost:7121/api/Product/ImagesProduct?Productid=1"
  private URL = "https://localhost:7121/api/Category"
  private Base_URLL ="https://localhost:7121/api/Product/GetProductsByCategory"
  private URL_price = "https://localhost:7121/api/Product/GetProductsByPrice"
  private URL_platform = "https://localhost:7121/api/Product/GetProductsByPlatform"


  GetAllProduct(){

    return this.myClient.get(this.Base_URL)

  }
  GetAllProductPrice(){

    return this.myClient.get(this.Base_URL)

  }
  GetAllProductPlatform(){

    return this.myClient.get(this.Base_URL)

  }
  GetProductByID(id:any){
    return this.myClient.get(`${this.Base_URL}/${id}`);
  }

  GetProductImageByID(id:any){
    return this.myClient.get(`${this.imgs_URL}/${id}`);
  }

  GetAllcategoryname()
  {
    return this.myClient.get(this.URL);
  }

  GetProductByCategoryID(id:any)
  {
    return this.myClient.get(`${this.Base_URLL}/${id}`);
  }

  GetProductByPriceID(id:any)
  {
    return this.myClient.get(`${this.URL_price}/${id}`);
  }

  GetProductByPlatformID(id:any)
  {
    return this.myClient.get(`${this.URL_platform}/${id}`);
  }
}
