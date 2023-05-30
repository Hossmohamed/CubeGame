import { Component, OnInit } from '@angular/core';
import { ProductBrowseService } from 'src/Services/product-browse.service';
import { Product } from 'src/Services/search.service';
import { SearchService } from 'src/Services/shared.service';

@Component({
  selector: 'app-browse',
  templateUrl: './browse.component.html',
  styleUrls: ['./browse.component.css']
})
export class BrowseComponent implements OnInit {
  searchResults: any[] = [];
  AllProduct : any
  constructor(public myService : ProductBrowseService,private searchService: SearchService){}

  ngOnInit(): void {

    this.myService.GetAllProduct().subscribe({

      next:(data)=>{
        // console.log(data)

         this.AllProduct = data
      },
      error:(err)=>{console.log(err)}

    });
    this.searchService.searchQuery$.subscribe((query) => {
      (results: Product[]) => {
        this.searchResults = results;
      }
  })

}}
