import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { DashboardService } from 'src/Services/dashboard.service';

@Component({
  selector: 'app-product-image',
  templateUrl: './product-image.component.html',
  styleUrls: ['./product-image.component.css']
})
export class ProductImageComponent implements OnInit {
  res : any
  url = './assets/img/banner1.png'
  file : any
  AllProduct : any
  selectedProductId!: number;

  constructor(public myService : DashboardService ,  private route: Router){}
  ngOnInit(): void {
  this.myService.GetAllProductsWithoutImages().subscribe({
    next:(data)=>{

       this.AllProduct = data
    },
    error:(err)=>{console.log(err)}
  })
}

AddImage = new FormGroup({

  ProductI : new FormControl("" , [Validators.required]),

});

onSubmitdata(){
  if(this.AddImage.valid){
      let formData = new FormData();
      formData.append('file' , this.file);
      this.myService.AddImage(this.selectedProductId , formData).subscribe({
        next:(d)=>{
          this.url = d.imageURL
        }
      })

    // message

    this.route.navigate(['dashboard'])
  }
}

onFileSelected(event: any) {
  // const file: File = event.target.files[0];
  this.file = event.target.files[0];
  this.url = URL.createObjectURL(this.file);
  };
}


