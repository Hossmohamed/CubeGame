import { Component } from '@angular/core';
import {  ProductService } from 'src/Services/search.service';
import { SearchService } from 'src/Services/shared.service';
import { debounceTime } from 'rxjs/operators';
import { Product } from 'src/Services/wishlist.service';

@Component({
  selector: 'app-navigation-two',
  templateUrl: './navigation-two.component.html',
  styleUrls: ['./navigation-two.component.css']
})
export class NavigationtwoComponent {
  searchQuery: string = '';



  constructor(private searchService: SearchService, private productService: ProductService) {}
  search(): void {
    if (this.searchQuery.trim() !== '') {
     // Debounce the search requests for 300 milliseconds
      this.searchService.emitSearchQuery(this.searchQuery);
        this.searchService.searchQuery$.pipe(debounceTime(300)).subscribe((query: string) => {
          this.productService.searchProducts(query).subscribe(
            (results: Product[]) => {
              this.searchService.updateSearchResults(results);
            },
            (error) => {
              console.error('Error:', error);
            }
          );
        })
    } else {
      // Clear the search results and emit an empty search query
      this.searchService.updateSearchResults([]);
      this.searchService.emitSearchQuery('');
    }
  }

}




////////////////////////////////////
// this.productService.searchProducts(this.searchQuery).subscribe(
//   (data: Product[]) => {
//     this.searchService.updateSearchResults(data);
//     this.searchService.emitSearchQuery(this.searchQuery);
//   },
//   (error) => {
//     console.error('Error:', error);
//   }
// );



// search(): void {
//   // Debounce the search requests for 300 milliseconds
//   this.searchService.emitSearchQuery(this.searchQuery);
//   this.searchService.searchQuery$.pipe(debounceTime(300)).subscribe((query: string) => {
//     this.productService.searchProducts(query).subscribe(
//       (results: Product[]) => {
//         this.searchService.updateSearchResults(results);
//       },
//       (error) => {
//         console.error('Error:', error);
//       }
//     );
//   });
// }


//last update
// search(): void {
//   this.productService.searchProducts(this.searchQuery).subscribe(
  //     (data: Product[]) => {
    //       this.searchService.updateSearchResults(data);
//       this.searchService.emitSearchQuery(this.searchQuery);
//     },
//     (error) => {
//       console.error('Error:', error);
//     }
//   );
// };


// export class NavigationtwoComponent {
//   searchQuery: string = '';

//   constructor(private searchService: SearchService,private productService:ProductService){}
//   search() {
//     this.productService.searchProducts(this.searchQuery).subscribe(
//       (data: Product[]) => {
//         this.searchService.emitSearchQuery(data);
//       },
//       (error) => {
//         console.error('Error:', error);
//       }
//     );

// }}






// export class NavigationTwoComponent {
//   searchItem: string = ''; // Initialize searchItem property
//   searchResults: Product[] = [];
// constructor (private productService:ProductService){}

// search() {
//   console.log('Search Item:', this.searchItem);
//   this.productService.searchProducts(this.searchItem).subscribe(
//     (data: Product[]) => {
//       this.searchResults = data;
//     },
//     (error: any) => {
//       console.error('Error:', error);
//     }
//   );
// }
// }


