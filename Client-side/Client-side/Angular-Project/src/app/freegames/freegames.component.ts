import { Component, OnInit } from '@angular/core';
import { FreegamesService } from '../Services/freegames.service';


@Component({
  selector: 'app-freegames',
  templateUrl: './freegames.component.html',
  styleUrls: ['./freegames.component.css']
})
export class FreegamesComponent implements OnInit {

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

    constructor(public myserv:FreegamesService){}
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
