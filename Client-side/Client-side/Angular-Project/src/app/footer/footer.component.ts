import { Component } from '@angular/core';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent {

  toTop(){
    // window.scrollTo(0,0)
    console.log('hi');
  }

}
