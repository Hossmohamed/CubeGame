import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, Subject } from 'rxjs';
import { Product } from './search.service';

@Injectable({
  providedIn: 'root'
})

export class SearchService {
  private searchQuerySubject: BehaviorSubject<string> = new BehaviorSubject<string>('');
  private searchResultsSubject: BehaviorSubject<Product[]> = new BehaviorSubject<Product[]>([]);

  public searchQuery$: Observable<string> = this.searchQuerySubject.asObservable();
  public searchResults$: Observable<Product[]> = this.searchResultsSubject.asObservable();

  constructor() {}

  public emitSearchQuery(query: string): void {
    this.searchQuerySubject.next(query);
  }

  public updateSearchResults(results: Product[]): void {
    this.searchResultsSubject.next(results);
  }
}


// export class SearchService {
//   private searchQuerySubject = new BehaviorSubject<Product[]>([]);
//   searchQuery$ = this.searchQuerySubject.asObservable();

//   emitSearchQuery(query: Product[]) {
//     this.searchQuerySubject.next(query);
//   }
// }
