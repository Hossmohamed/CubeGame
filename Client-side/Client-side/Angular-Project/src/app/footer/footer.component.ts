import { Component } from '@angular/core';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent {
  arrow  = "bi bi-chevron-compact-down";
  IM = 'assets/img/logo.png';
  

  toTop(){
    if(window.scrollY > 0){ 
      window.scrollTo(0,0);
      // this.btn = 'hidden';
      this.arrow = "bi bi-chevron-compact-down"
    }else{
      window.scrollTo(0,document.body.scrollHeight)
      this.arrow = "bi bi-chevron-compact-up";

    }



}
}
