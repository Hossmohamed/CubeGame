import { Component, OnInit } from '@angular/core';
import { GameonsalesService } from '../Services/gameonsales.service';

@Component({
  selector: 'app-gameonsales',
  templateUrl: './gameonsales.component.html',
  styleUrls: ['./gameonsales.component.css']
})
export class GameonsalesComponent implements OnInit {

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

  constructor(public myserv:GameonsalesService){}
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
