import { Component } from '@angular/core';
import { StripecheckoutService } from 'src/Services/stripecheckout.service';

@Component({
  selector: 'app-stripecheckout',
  templateUrl: './stripecheckout.component.html',
  styleUrls: ['./stripecheckout.component.css']
})
export class StripecheckoutComponent {
  title = "angularstripeapp";
  handler:any = null;
  success:boolean = false;
  failure:boolean = false;

  constructor(private checkout:StripecheckoutService){}

  ngOnInit(){
    this.invokeStrip()
  }

  makePayment(amount : number){
    var handler = (<any>window).StripeCheckout.configure({
      key: 'pk_test_51N96sVGXyzvXCyS2EriepHJroYOAvBjU6oml1UzutT6w69dpyNvihVqGwXjO4mWavAS4UQdCtwaafrK6VdbJWgao00Md3Ors8T',
      locale: 'auto',
      token: function (stripeToken: any) {
        console.log(stripeToken)
        // alert('Token Created!!');

        paymentStripe(stripeToken)
      }
    });

    const paymentStripe = (stripeToken: any) => {
       this.checkout.makePayment(stripeToken).subscribe((data:any) => {
            console.log(data)

            if(data.data === "success"){
                  this.success = true;
            }
            else{
               this.failure = true;
            }
       })
    }

    handler.open({
      name: 'Demo Site',
      description: 'A Simple Snake Game',
      amount: amount * 100
    });
  }

  invokeStrip() {
    if(!window.document.getElementById('stripe-script')) {
      var s = window.document.createElement("script");
      s.id = "stripe-script";
      s.type = "text/javascript";
      s.src = "https://checkout.stripe.com/checkout.js";
      s.onload = () => {
        this.handler = (<any>window).StripeCheckout.configure({
          key: 'pk_test_51N96sVGXyzvXCyS2EriepHJroYOAvBjU6oml1UzutT6w69dpyNvihVqGwXjO4mWavAS4UQdCtwaafrK6VdbJWgao00Md3Ors8T',
          locale: 'auto',
          token: function (stripeToken: any) {
            console.log(stripeToken)
            alert('Payment Success!!');
          }
        });
      }

      window.document.body.appendChild(s);
    }
  }
}
