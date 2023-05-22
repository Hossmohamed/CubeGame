import { Directive , HostListener , ElementRef } from '@angular/core';

@Directive({
  selector: '[appSlider]'
})
export class SliderDirective {

  constructor(private el:ElementRef) { }


    
      src:any = this.el.nativeElement.src;
      prev:any = document.getElementById('preview')
      imageSlide = document.getElementsByTagName('img')
      flag = 0;
 

     play =  setInterval(()=>{
        if (this.flag > this.imageSlide.length - 1) {
          this.flag=0
         } 
          this.prev.src = this.imageSlide[this.flag].src ;
          for (let i = 0 ; i< this.imageSlide.length ; i++ ){
            this.imageSlide[i].classList.remove('active');

          }

          this.imageSlide[this.flag].classList.add('active')


         this.flag = this.flag + 1 
         
         console.log(this.flag)
  
       },2000)

    @HostListener('click')
     ImageChange() {
     this.prev.src = this.src;
     for (let i = 0 ; i< this.imageSlide.length ; i++ ){
      this.imageSlide[i].classList.remove('active');
      console.log(this.imageSlide[1])
     this.el.nativeElement.classList.add('active')
   }


 
   
  
  }



}
