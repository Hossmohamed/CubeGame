import { Component } from '@angular/core';

@Component({
  selector: 'app-store',
  templateUrl: './store.component.html',
  styleUrls: ['./store.component.css']
})
export class StoreComponent {

  constructor(){

  }
}
/*import { Directive, HostListener, ElementRef } from '@angular/core';

@Directive({
  selector: '[appslide]',
})

export class StoreComponent {

  constructor(private el: ElementRef){

  }

  @HostListener('click')
  imagechange(){
    var src:any =this.el.nativeElement.src;
    var prev:any = document.getElementById("preview");
    prev.src = src;
    var imgslide = document.getElementsByClassName("img-slide");
    for(let i=0; i < imgslide.length; i++)
    {
      imgslide[i].classList.remove("active-slide");
    }
    this.el.nativeElement.parentElement.classList.add("active-slide");
  }
}
*/
