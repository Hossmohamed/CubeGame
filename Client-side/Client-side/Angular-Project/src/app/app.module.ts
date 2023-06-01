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
import { NavigationtwoComponent } from './navigation-two/navigation-two.component';

import { FooterComponent } from './footer/footer.component';

import { RouterModule, Routes } from '@angular/router';
import { SlickCarouselModule } from 'ngx-slick-carousel';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { GameComponent } from './game/game.component';

import { FreegameComponent } from './freegame/freegame.component';
import { GameonsalesComponent } from './gameonsales/gameonsales.component';
import { MostPopularComponent } from './most-popular/most-popular.component';
import { MainSliderDirective } from './Directives/main-slider.directive';
import { MainSliderComponent } from './main-slider/main-slider.component';
import { ProductItemComponent } from './product-item/product-item.component';
import { TokenInterceptor } from 'src/interceptor/token.interceptor';
import { LoadingInterceptor } from './loading.interceptor';
import { MostPlayedComponent } from './most-played/most-played.component';
import { TopSellerComponent } from './top-seller/top-seller.component';
import { TopRatedComponent } from './top-rated/top-rated.component';
import { NewReleaseComponent } from './new-release/new-release.component';
import { ComingSoonComponent } from './coming-soon/coming-soon.component';
import { RecentlyUpdatedComponent } from './recently-updated/recently-updated.component';


let routes: Routes = [
  {path:"", component:DiscoverComponent },
  {path:"discover", component:DiscoverComponent },
  {path:"Browse", component:BrowseComponent },
  {path:"Browse/:id", component:GameComponent},
  {path:"Signup", component:SignUpComponent },
  {path:"Login", component:LoginComponent },
  {path:"Distribution", component:DistributionComponent },
  {path:"coverGame", component:GameComponent },


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
    NavigationtwoComponent,
    ProductItemComponent,
    FooterComponent,
    FreegameComponent,
    GameonsalesComponent,
    MostPopularComponent,
    MainSliderDirective,
    MainSliderComponent,
    MostPlayedComponent,
    TopSellerComponent,
    TopRatedComponent,
    NewReleaseComponent,
    ComingSoonComponent,
    RecentlyUpdatedComponent,
    

  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes),
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    SlickCarouselModule,
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
