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

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgToastModule } from 'ng-angular-popup';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { ProductItemComponent } from './product-item/product-item.component';
import { TokenInterceptor } from 'src/interceptor/token.interceptor';

import { SliderDirective } from './Directives/slider.directive';
import { GameComponent } from './game/game.component';
import { ArrowbuttonDirective } from './Directives/arrowbutton.directive';
import { ArrowTopDirective } from './Directives/arrow-top.directive';
import { LeftClickDirective } from './Directives/left-click.directive';
import { RighttClickDirective } from './Directives/rightt-click.directive';


<<<<<<< HEAD
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
import { WishlistComponent } from './wishlist/wishlist.component';
import { SlickCarouselModule } from 'ngx-slick-carousel';
=======
>>>>>>> parent of 05940b1 (Merge branch 'master' into dev-nancy)
let routes: Routes = [
  {path:"", component:DiscoverComponent },
  {path:"discover", component:DiscoverComponent },
  {path:"Browse", component:BrowseComponent },
  {path:"Browse/:id", component:GameComponent},
  {path:"Signup", component:SignUpComponent },
  {path:"Login", component:LoginComponent },
  {path:"Distribution", component:DistributionComponent },
<<<<<<< HEAD
  {path:"coverGame", component:GameComponent },
  {path:"cart", component:CartComponent , canActivate:[AuthGuard]},
  {path:"wishlist", component:WishlistComponent , canActivate:[AuthGuard]}
=======
  {path:"coverGame", component:GameComponent }

>>>>>>> parent of 05940b1 (Merge branch 'master' into dev-nancy)
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
    SliderDirective,
    GameComponent,
    ArrowbuttonDirective,
    ArrowTopDirective,
    LeftClickDirective,
    RighttClickDirective,
<<<<<<< HEAD
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
    WishlistComponent,
    CartComponent,

=======
>>>>>>> parent of 05940b1 (Merge branch 'master' into dev-nancy)
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
