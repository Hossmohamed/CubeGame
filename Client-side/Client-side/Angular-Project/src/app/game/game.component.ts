import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ProductBrowseService } from 'src/Services/product-browse.service';

@Component({
  selector: 'app-game',
  templateUrl: './game.component.html',
  styleUrls: ['./game.component.css']
})

export class GameComponent implements OnInit{

  ID:any;
  ImgID:any;
  product:any;
  img:any;
  // src:any="../../assets/img/1.png";
  // arr:string[] = ["../../assets/img/bg.png",
  // "../../assets/img/2.png",
  // "../../assets/img/4.png",
  // "../../assets/img/1.png",
  // "../../assets/img/3.png"];
  // counter = 0;
  // play = setInterval(()=>{
  //    this.counter++;
  //   if(this.counter>this.arr.length-1){
  //     this.counter = 1;
  //   }
  //    this.src=this.arr[this.counter]



  // },5000)
 
 
 
 
  constructor(myRoute:ActivatedRoute,public myServices:ProductBrowseService){

    this.ID = myRoute.snapshot.params["id"];

  }
  ngOnInit(): void {
    this.myServices.GetProductByID(this.ID).subscribe({
      next:(data)=>{
        
        this.product = data;
      },
      error:(err)=>{console.log(err)}
    });

    // this.myServices.GetProductImageByID(this.ImgID).subscribe({
    //   next:(data)=>{
    //     // console.log(data)
    //     this.img = data;
    //   },
    //   error:(err)=>{console.log(err)}
    // })
  }

}
