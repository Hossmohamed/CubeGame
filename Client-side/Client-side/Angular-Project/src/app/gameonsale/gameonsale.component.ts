import { Component, OnInit } from '@angular/core';
import { GameonsaleService } from '../Services/gameonsale.service';

@Component({
  selector: 'app-gameonsale',
  templateUrl: './gameonsale.component.html',
  styleUrls: ['./gameonsale.component.css']
})
export class GameonsaleComponent implements OnInit{

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

  constructor(public myserv:GameonsaleService){}
  user:any;
  ngOnInit(): void {
    this.myserv.GetAllmostpop().subscribe({
      next:(data)=>{
        this.user=data;
      },
      error:(err)=>{console.log(err)}
    });
  }

}
