import { Component, OnInit } from '@angular/core';
import { MainsliderService } from '../mainslider.service';

@Component({
  selector: 'app-mainslider',
  templateUrl: './mainslider.component.html',
  styleUrls: ['./mainslider.component.css']
})
export class MainsliderComponent implements OnInit {
  constructor(public myserv:MainsliderService){}
  user:any;
  currentIndex: number = 0;
  currentImage: any;

  startInterval() {
    setInterval(() => {
      this.currentIndex = (this.currentIndex + 1) % this.user.length;
      this.currentImage = this.user[this.currentIndex];
    }, 3000);
  }

  changeImage(image: string, index: number) {
    this.currentImage = image;
    this.currentIndex = index;
  }

  ngOnInit(): void {
    this.startInterval();
    this.myserv.GetAllmostpop().subscribe({
      next:(data)=>{
        this.user=data;
      },
      error:(err)=>{console.log(err)}
    })
  }

}
