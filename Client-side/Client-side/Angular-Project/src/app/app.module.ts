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

import { FormsModule, ReactiveFormsModule } from '@angular/forms'
import { HttpClientModule } from '@angular/common/http'

import { SlickCarouselModule } from 'ngx-slick-carousel';
import { MostPlayedComponent } from './most-played/most-played.component';
import { TopSellerComponent } from './top-seller/top-seller.component';
import { TopRatedComponent } from './top-rated/top-rated.component';
import { NewReleaseComponent } from './new-release/new-release.component';
import { ComingSoonComponent } from './coming-soon/coming-soon.component';
import { RecentlyUpdatedComponent } from './recently-updated/recently-updated.component';
import { FreegamesComponent } from './freegames/freegames.component';
import { GameonsaleComponent } from './gameonsale/gameonsale.component';
import { MostpopularComponent } from './mostpopular/mostpopular.component';
import { MainsliderComponent } from './mainslider/mainslider.component';
import { MainsliderDirective } from './Directives/mainslider.directive';

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
    FooterComponent,
    MostPlayedComponent,
    TopSellerComponent,
    TopRatedComponent,
    NewReleaseComponent,
    ComingSoonComponent,
    RecentlyUpdatedComponent,
    FreegamesComponent,
    GameonsaleComponent,
    MostpopularComponent,
    MainsliderComponent,
    MainsliderDirective,

  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes),
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    SlickCarouselModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
