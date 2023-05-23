import { Directive, HostListener , ElementRef } from '@angular/core';

@Directive({
  selector: '[appArrowbutton]'
})
export class ArrowbuttonDirective {

  constructor(private el:ElementRef) { }

  uparrow = document.getElementById('top-arrow')
  downarrow = document.getElementById('down-arrow')


  @HostListener('click') 
  scroll(){

    console.log(this.el.nativeElement)

  }

}
