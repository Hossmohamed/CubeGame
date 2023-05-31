import { Injectable } from '@angular/core';
import { BehaviorSubject, Subject } from 'rxjs';
import { Product } from './search.service';

@Injectable({
  providedIn: 'root'
})
export class SearchService {
  private searchQuerySubject = new BehaviorSubject<Product[]>([]);
  searchQuery$ = this.searchQuerySubject.asObservable();

  emitSearchQuery(query: Product[]) {
    this.searchQuerySubject.next(query);
  }
}
