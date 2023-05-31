import { Directive , HostListener , ElementRef } from '@angular/core';

@Directive({
  selector: '[appSlider]'
})
export class SliderDirective {

  constructor(private el:ElementRef) { }


    
      src:any = this.el.nativeElement.src;
      prev:any = document.getElementById('preview');
      imageSlide = document.getElementsByTagName('img');
      firstImage = document.getElementById('FImge');
      flag = 0;
      sliderImages = document.getElementById('slider-images')
 

    //  play =  setInterval(()=>{
    //     if (this.flag > this.imageSlide.length - 1) {
    //       this.flag=0
    //      } 
    //       this.prev.src = this.imageSlide[this.flag].src;
    //       for (let i = 0 ; i< this.imageSlide.length ; i++ ){
    //         this.imageSlide[i].classList.remove('active');


    //       }
    //       var x = window.matchMedia("(min-width: 991px)")
    //       if (x.matches) { 
    //         this.sliderImages?.scrollBy(0,30) ;
    //         let y:any = this.sliderImages?.scrollTop;
    //         if(y >= 155 ) {
    //               this.sliderImages?.scrollTo(0,0) ;

                   
    //                   // console.log(y);
      
    //             }
    //         // console.log(y)
            
    //       } else {
    //         this.sliderImages?.scrollBy(40,0) ;
    //         let x:any = this.sliderImages?.scrollLeft;
          

    //         // console.log(x)
    //       }
          

    //       this.imageSlide[this.flag].classList.add('active')


    //      this.flag = this.flag + 1 
         
       
  
    //    },2000)

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
