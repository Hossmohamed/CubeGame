import { Component, OnInit } from '@angular/core';
import { MostpopularService } from '../Services/mostpopular.service';

@Component({
  selector: 'app-mostpopular',
  templateUrl: './mostpopular.component.html',
  styleUrls: ['./mostpopular.component.css']
})
export class MostpopularComponent implements OnInit{
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
  constructor(public myserv:MostpopularService){}
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
