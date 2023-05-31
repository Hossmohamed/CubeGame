import { Component } from '@angular/core';
import { Product, ProductService } from 'src/Services/search.service';
import { SearchService } from 'src/Services/shared.service';

@Component({
  selector: 'app-navigation-two',
  templateUrl: './navigation-two.component.html',
  styleUrls: ['./navigation-two.component.css']
})
export class NavigationtwoComponent {
  searchQuery: string = '';
  searchResults: Product[] = [];

  constructor(private searchService: SearchService, private productService: ProductService) {}

  search(): void {
    this.productService.searchProducts(this.searchQuery).subscribe(
      (data: Product[]) => {
        //this.searchService.emitSearchQuery(this.searchQuery);
        this.searchService.updateSearchResults(data);
        console.log('Search Item:', this.searchQuery);
           this.productService.searchProducts(this.searchQuery).subscribe(
           (data: Product[]) => {
            this.searchResults = data;
      },
      (error) => {
        console.error('Error:', error);
      }
    );
  })
}}





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


