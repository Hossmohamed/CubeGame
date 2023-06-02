import { Component, OnInit} from '@angular/core';
import { MainSliderService } from '../../Services/main-slider.service';

@Component({
  selector: 'app-main-slider',
  templateUrl: './main-slider.component.html',
  styleUrls: ['./main-slider.component.css']
})
export class MainSliderComponent implements OnInit {
  constructor(public myserv:MainSliderService){}


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
    this.myserv.GetAllMainSlider().subscribe({
      next:(data)=>{
        this.user=data;
      },
      error:(err)=>{console.log(err)}
    })
  }
}
