import { Component, OnInit, Input} from '@angular/core';
import { Router } from '@angular/router';
import { MainSliderService } from '../../Services/main-slider.service';
import { AuthService } from 'src/Services/auth.service';
import { CartService } from 'src/Services/cart.service';

@Component({
  selector: 'app-main-slider',
  templateUrl: './main-slider.component.html',
  styleUrls: ['./main-slider.component.css']
})
export class MainSliderComponent implements OnInit {
  constructor(public myserv:MainSliderService,private myservice : CartService , private auth : AuthService,
    private route:Router){}
    @Input() oneProduct : any


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

  addToCart(id : any) {
    if(this.auth.IsLoggedIn()){
      this.myservice.AddTCart(id).subscribe(
        (response) => {
          console.log('Response:', response);
        },

        (error) => {
          console.error('Error:', error);
        }
        );}
    else{
      this.route.navigate(['Login'])
  }}
}
