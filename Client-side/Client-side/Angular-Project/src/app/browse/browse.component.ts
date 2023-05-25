import { Component, OnInit } from '@angular/core';
import { ProductBrowseService } from 'src/Services/product-browse.service';

@Component({
  selector: 'app-browse',
  templateUrl: './browse.component.html',
  styleUrls: ['./browse.component.css']
})
export class BrowseComponent implements OnInit {

  AllProduct : any
  constructor(public myService : ProductBrowseService){}

  ngOnInit(): void {

    this.myService.GetAllProduct().subscribe({

      next:(data)=>{
        // console.log(data)

         this.AllProduct = data
      },
      error:(err)=>{console.log(err)}

    });
  }

}
