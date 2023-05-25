import { Directive , HostListener , ElementRef} from '@angular/core';

@Directive({
  selector: '[appRighttClick]'
})
export class RighttClickDirective {

  constructor(private el:ElementRef) {

   }
  btn:any = document.getElementById('btn')?.style.left;
  btn1:any = document.getElementById('btn')?.style.background;
 color:any = document.getElementById('toggle-btn1')?.style.color 
  // document.getElementById('toggle-btn2').style.color = 'white'


 
  @HostListener('click') change(){
  
    this.el.nativeElement.previousSibling.style.left = '120px'
    this.el.nativeElement.style.color = 'white'
    this.el.nativeElement.previousSibling.previousSibling.previousSibling.style.color = '#707070'




  }
  // rightClick(){
  //   this.btn ='120px !important';
  //   this.btn1 = "black"
  //   this.color =  '#707070'
    
  //   console.log('btn2 clicked');
  //     
  // }

}
