import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { DashboardService } from 'src/Services/dashboard.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit{

  // -------- Category ------------
  AllCategories : any
  AllProduct : any
  constructor(public myService : DashboardService , private router: Router){}
  ngOnInit(): void {

    this.myService.GetAllCategories().subscribe({
      next:(data)=>{

         this.AllCategories = data
      },
      error:(err)=>{console.log(err)}
    })


    this.myService.GetAllProducts().subscribe({
      next:(data)=>{

         this.AllProduct = data
      },
      error:(err)=>{console.log(err)}
    })

  }


  updatecategory(s : any) {
    this.router.navigate(['/update-category-dashboard', JSON.stringify(s)]);
  }

  deletecategory(id : any){
    this.myService.deleteCategory(id).subscribe({
      next:(u)=>{
       this.ngOnInit()
      }
    })
 }

// -------- Product ------------

updateproduct(s : any) {
  this.router.navigate(['/update-product-dashboard', JSON.stringify(s)]);
}

deleteproduct(id : any){
  this.myService.deleteProduct(id).subscribe({
    next:(u)=>{
     this.ngOnInit()
    }
  })
}

//  Show Tables
 show1 : Boolean = false
 show2 : Boolean = false
 show3 : Boolean = false

 showC(){

  this.show1 = true
  this.show2 = false
  this.show3 = false
 }

 showP(){
  this.show1 = false
  this.show2 = true
  this.show3 = false
 }

 showI(){
  this.show1 = false
  this.show2 = false
  this.show3 = true
 }
}

