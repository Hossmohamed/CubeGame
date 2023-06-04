import { Component, OnInit } from '@angular/core';
import { ProductBrowseService } from 'src/Services/product-browse.service';

import { SearchService } from 'src/Services/shared.service';
import { Product } from 'src/Services/wishlist.service';

@Component({
  selector: 'app-browse',
  templateUrl: './browse.component.html',
  styleUrls: ['./browse.component.css']
})
export class BrowseComponent implements OnInit {
  searchResults: any[] = [];
  AllProduct : any
  filteredProducts: any[] = [];
  constructor(public myService : ProductBrowseService,private searchService: SearchService){}
  ngOnInit(): void {
    this.myService.GetAllProduct().subscribe({
      next: (data) => {
      //  this.AllProduct = data;
        this.searchService.setAllProducts(data);
        this.filteredProducts = [...this.AllProduct]; // Initialize filteredProducts with all products
      },
      error: (err) => {
        console.log(err);
      }
    });

    this.searchService.searchResults$.subscribe((results: any[]) => {
      this.searchResults = results;
      this.filteredProducts = [...results]; // Update filteredProducts with search results
    });
  }
/////////////////////////////////////
// ngOnInit(): void {
//   this.myService.GetAllProduct().subscribe({
//     next: (data) => {
//       this.AllProduct = data;
//     },
//     error: (err) => {
//       console.log(err);
//     },
//   });

//   this.searchService.searchResults$.subscribe((results: any[]) => {
//     this.searchResults = results;
//   });

//   this.searchService.searchQuery$.subscribe((query: string) => {
//     if (query === '') {
//       // Restore the initial state, e.g., fetch all products again
//       this.myService.GetAllProduct().subscribe({
//         next: (data) => {
//           this.AllProduct = data;
//         },
//         error: (err) => {
//           console.log(err);
//         },
//       });
//     }
//   });
// }



}




// ngOnInit(): void {
//   this.myService.GetAllProduct().subscribe({
//     next: (data) => {
//       this.AllProduct = data;
//     },
//     error: (err) => {
//       console.log(err);
//     },
//   });

//   this.searchService.searchResults$.subscribe((results: Product[]) => {
//     this.searchResults = results;
//   });

//   this.searchService.searchQuery$.subscribe((query: string) => {
//     if (query === '') {
//       // Restore the initial state, e.g., fetch all products again
//       this.myService.GetAllProduct().subscribe({
//         next: (data) => {
//           this.AllProduct = data;
//         },
//         error: (err) => {
//           console.log(err);
//         },
//       });
//     }
//   });
// }



























///////////////////////////////////////////
// ngOnInit(): void {

//   this.myService.GetAllProduct().subscribe({

//     next:(data)=>{
//       // console.log(data)

//        this.AllProduct = data
//     },
//     error:(err)=>{console.log(err)}

//   });
//   this.searchService.searchResults$.subscribe((results: Product[]) => {
//     this.searchResults = results;
//   });
// }
