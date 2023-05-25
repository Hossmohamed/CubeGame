import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { StoreComponent } from './store/store.component';
import { DistributionComponent } from './distribution/distribution.component';
import { DiscoverComponent } from './discover/discover.component';
import { BrowseComponent } from './browse/browse.component';
import { SignUpComponent } from './sign-up/sign-up.component';
import { LoginComponent } from './login/login.component';
import { NavigationOneComponent } from './navigation-one/navigation-one.component';
import { NavigationTwoComponent } from './navigation-two/navigation-two.component';

import { FooterComponent } from './footer/footer.component';

import { RouterModule, Routes } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgToastModule } from 'ng-angular-popup';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { ProductItemComponent } from './product-item/product-item.component';
import { TokenInterceptor } from 'src/interceptor/token.interceptor';

let routes: Routes = [
  {path:"", component:DiscoverComponent },
  {path:"Browse", component:BrowseComponent },
  {path:"Signup", component:SignUpComponent },
  {path:"Login", component:LoginComponent },
  {path:"Distribution", component:DistributionComponent }
]

@NgModule({
  declarations: [
    AppComponent,
    StoreComponent,
    DistributionComponent,
    DiscoverComponent,
    BrowseComponent,
    SignUpComponent,
    LoginComponent,
    NavigationOneComponent,
    NavigationTwoComponent,
    ProductItemComponent,
    FooterComponent,
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule,
    NgToastModule,
    RouterModule.forRoot(routes)

  ],
  providers: [{
    provide : HTTP_INTERCEPTORS,
    useClass:TokenInterceptor,
    multi:true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
