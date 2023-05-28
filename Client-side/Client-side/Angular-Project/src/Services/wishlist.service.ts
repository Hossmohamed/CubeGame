import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, catchError, map, tap, throwError } from 'rxjs';
export interface Product {
  id: number,
  productName: string,
  discount: number,
  price: number,
  priceAfterDiscount: number,
  image: string
}

@Injectable({
  providedIn: 'root'
})
export class WishlistService {
private base_url="https://localhost:7121/api/Wishlist/";
private wishlistItems: Product[] = [];
private wishlistItems$ = new BehaviorSubject<Product[]>(this.wishlistItems);

  constructor(private httpclint : HttpClient) { }
  //-------------------Get Wishlist------------------
  GetWishlist(): Observable<any[]> {
    return this.httpclint.get<any>(`${this.base_url}getAll`)
      .pipe(
        tap((response)=>{
        this.wishlistItems.push(response);
        this.wishlistItems$.next(this.wishlistItems);
        return response
          }),
          catchError((error) => {
            console.error('Error:', error);
            return throwError(error);
            }));
      }
      //-------------------Add To Wishlist------------------
      AddToWishlist(id: Number): Observable<any> {
      return this.httpclint.post<Product>(`${this.base_url}/{id}`, id)
      .pipe(
      tap((response) => {
      this.wishlistItems.push(response);
      this.wishlistItems$.next(this.wishlistItems);

      }),
      catchError((error) => {
        console.error('Error:', error);
        return throwError(error);
      }
      ));
    }
    //-------------------Delete From Wishlist------------------
    DeleteFromWishlist(id: Number): Observable<any> {
      return this.httpclint.delete<any>(`${this.base_url}RemoveFromwishlist/{id}`)
      .pipe(tap(() => {
        const index = this.wishlistItems.findIndex(item => item.id === id);
         if (index !== -1) {
         this.wishlistItems.splice(index, 1);
         this.wishlistItems$.next(this.wishlistItems);
         }
      })
      )
    }
    //---------------clear wishlist----------------
    ClearCart(): Observable<any>{
      return this.httpclint.delete<any>(`${this.base_url}clearwishlist`).pipe(
        tap(() => {
          this.wishlistItems = []
          this.wishlistItems$.next(this.wishlistItems);
        }))
    }
    }

