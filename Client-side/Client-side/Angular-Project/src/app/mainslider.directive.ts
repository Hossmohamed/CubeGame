import { Directive, HostListener, ElementRef} from '@angular/core';

@Directive({
  selector: '[appMainslider]'
})
export class MainsliderDirective {

  constructor(private el: ElementRef) { }
  @HostListener('click')
  imagechange(){
    var src:any =this.el.nativeElement.src;
    var prev:any = document.getElementById("preview");
    prev.src = src;

    var imgslide = document.getElementsByClassName("img-slide");
      var flag = 0;

     

    for(let i=0; i < imgslide.length; i++)
    {
      imgslide[i].classList.remove("active-slide");
    }
    this.el.nativeElement.parentElement.classList.add("active-slide");
  }


  // src:any = this.el.nativeElement.src;
  //     prev:any = document.getElementById('preview')
  //     imageSlide = document.getElementsByTagName('img')
  //     flag = 0;

  //    play =  setInterval(()=>{
  //       if (this.flag > this.imageSlide.length - 1) {
  //         this.flag=0
  //        }
  //         this.prev.src = this.imageSlide[this.flag].src ;
  //         for (let i = 0 ; i< this.imageSlide.length ; i++ ){
  //           this.imageSlide[i].classList.remove('active');
  //         }
  //         this.imageSlide[this.flag].classList.add('active')
  //        this.flag = this.flag + 1
  //      },2000)

  //   @HostListener('click')
  //    ImageChange() {
  //    this.prev.src = this.src;
  //    for (let i = 0 ; i< this.imageSlide.length ; i++ ){
  //     this.imageSlide[i].classList.remove('active');
  //     console.log(this.imageSlide[1])
  //    this.el.nativeElement.classList.add('active')}
}

