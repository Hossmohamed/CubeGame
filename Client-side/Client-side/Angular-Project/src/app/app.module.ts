import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
// import { SwiperModule } from 'swiper/angular';


import { AppComponent } from './app.component';
import { StoreComponent } from './store/store.component';
import { DistributionComponent } from './distribution/distribution.component';
import { DiscoverComponent } from './discover/discover.component';
import { BrowseComponent } from './browse/browse.component';
import { GamesComponent } from './games/games.component';
import Swiper from 'swiper/types/swiper-class';
import { SliderDirective } from './Directives/slider.directive';

@NgModule({
  declarations: [
    AppComponent,
    StoreComponent,
    DistributionComponent,
    DiscoverComponent,
    BrowseComponent,
    GamesComponent,
    SliderDirective,
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
