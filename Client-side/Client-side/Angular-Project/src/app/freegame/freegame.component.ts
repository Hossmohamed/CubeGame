import { Component, OnInit } from '@angular/core';
import { FreegameService } from '../Services/freegame.service';

@Component({
  selector: 'app-freegame',
  templateUrl: './freegame.component.html',
  styleUrls: ['./freegame.component.css']
})
export class FreegameComponent  implements OnInit {

  multislideConfig=
  {
    slidesToShow:5,
    slidesToScroll:1,
    dots:false,
    infinite:true,
    arrows:true,
    autoplay:true,
    autoplayspeed:1000
  }

  constructor(public myserv:FreegameService){}
  user:any;
  ngOnInit(): void {
    this.myserv.GetAllmostpop().subscribe({
      next:(data)=>{
        this.user=data;
      },
      error:(err)=>{console.log(err)}
    })

  }
}
