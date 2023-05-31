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

import { LoadingInterceptor } from './loading.interceptor';
import { SpinnerComponent } from './spinner/spinner.component';

import { SliderDirective } from './Directives/slider.directive';
import { GameComponent } from './game/game.component';
import { ArrowbuttonDirective } from './Directives/arrowbutton.directive';
import { ArrowTopDirective } from './Directives/arrow-top.directive';
import { LeftClickDirective } from './Directives/left-click.directive';
import { RighttClickDirective } from './Directives/rightt-click.directive';
import { CartComponent } from './cart/cart.component';
import { AuthGuard } from 'src/guards/auth.guard';


import { ComingSoonComponent } from './coming-soon/coming-soon.component';
import { FreeGamesComponent } from './free-games/free-games.component';
import { GamesOnsaleComponent } from './games-onsale/games-onsale.component';
import { MostPlayedComponent } from './most-played/most-played.component';
import { MostPopularComponent } from './most-popular/most-popular.component';
import { NewReleaseComponent } from './new-release/new-release.component';
import { RecentlyUpdatedComponent } from './recently-updated/recently-updated.component';
import { TopSellerComponent } from './top-seller/top-seller.component';
import { TopRatedComponent } from './top-rated/top-rated.component';
import { MainSliderComponent } from './main-slider/main-slider.component';
import { MainSliderDirective } from './Directives/main-slider.directive';

import { SlickCarouselModule } from 'ngx-slick-carousel';
import { CheckoutComponent } from './checkout/checkout.component';

let routes: Routes = [
  {path:"", component:DiscoverComponent },
  {path:"Browse", component:BrowseComponent },
  {path:"Signup", component:SignUpComponent },
  {path:"Login", component:LoginComponent },
  {path:"Checkout", component:CheckoutComponent },
  {path:"Distribution", component:DistributionComponent },
  {path:"coverGame", component:GameComponent },
  {path:"cart", component:CartComponent , canActivate:[AuthGuard]}
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
    SliderDirective,
    GameComponent,
    ArrowbuttonDirective,
    ArrowTopDirective,
    LeftClickDirective,
    RighttClickDirective,
    ComingSoonComponent,
    FreeGamesComponent,
    GamesOnsaleComponent,
    MostPlayedComponent,
    MostPopularComponent,
    NewReleaseComponent,
    RecentlyUpdatedComponent,
    TopSellerComponent,
    TopRatedComponent,
    MainSliderComponent,
    MainSliderDirective,
    SpinnerComponent,
    CheckoutComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule,
    NgToastModule,
    SlickCarouselModule,
    RouterModule.forRoot(routes)
  ],
  providers: [{
    provide : HTTP_INTERCEPTORS,
    useClass:TokenInterceptor,
    multi:true
  },
  {
    provide : HTTP_INTERCEPTORS,
    useClass:LoadingInterceptor,
    multi:true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
