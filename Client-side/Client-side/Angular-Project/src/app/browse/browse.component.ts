import { Component, OnInit } from '@angular/core';
import { ProductBrowseService } from 'src/Services/product-browse.service';
import { Product, ProductService } from 'src/Services/search.service';
import { SearchService } from 'src/Services/shared.service';

@Component({
  selector: 'app-browse',
  templateUrl: './browse.component.html',
  styleUrls: ['./browse.component.css']
})
export class BrowseComponent implements OnInit {
  searchResults: Product[] = [];
  AllProduct : any
  searchQuery: string = '';
  constructor(public myService : ProductBrowseService,private searchService: SearchService,private productService: ProductService){}

  ngOnInit(): void {

    this.myService.GetAllProduct().subscribe({

      next:(data)=>{
        // console.log(data)

         this.AllProduct = data
      },
      error:(err)=>{console.log(err)}

    });
    this.searchService.searchResults$.subscribe((results: Product[]) => {
      this.searchResults = results;
    });
  }
  search(): void {
    this.productService.searchProducts(this.searchQuery).subscribe(
      (data: Product[]) => {
        this.searchResults = data;
        //this.searchService.emitSearchQuery(this.searchQuery);
        this.searchService.updateSearchResults(data);
        console.log('Search Item:', this.searchResults);
      //      this.productService.searchProducts(this.searchQuery).subscribe(
      //      (data: Product[]) => {
       },
      (error) => {
        console.error('Error:', error);
      }
    );
  }
}


