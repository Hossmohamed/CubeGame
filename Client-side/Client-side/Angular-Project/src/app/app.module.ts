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
import { WishlistComponent } from './wishlist/wishlist.component';
import { SlickCarouselModule } from 'ngx-slick-carousel';
<<<<<<< HEAD
import { DashboardComponent } from './dashboard/dashboard.component';
import { UpdateCategoryDashboardComponent } from './update-category-dashboard/update-category-dashboard.component';
import { AddCategoryDashboardComponent } from './add-category-dashboard/add-category-dashboard.component';
import { AddProductDashboardComponent } from './add-product-dashboard/add-product-dashboard.component';
import { ProductImageComponent } from './product-image/product-image.component';
import { UpdateProductDashboardComponent } from './update-product-dashboard/update-product-dashboard.component';
=======

>>>>>>> parent of 75946e2 (SomeEdits&Dashboard)
let routes: Routes = [
  {path:"", component:DiscoverComponent },
  {path:"discover", component:DiscoverComponent },
  {path:"Browse", component:BrowseComponent },
  {path:"Browse/:id", component:GameComponent},
  {path:"Signup", component:SignUpComponent },
  {path:"Login", component:LoginComponent },
  {path:"Distribution", component:DistributionComponent },
  {path:"coverGame", component:GameComponent },
<<<<<<< HEAD
  {path:"cart", component:CartComponent , canActivate:[AuthGuard]},

  // dashboard
  {path:"dashboard", component:DashboardComponent },

  {path:"update-category-dashboard/:data", component:UpdateCategoryDashboardComponent },
  {path:"add-category-dashboard", component:AddCategoryDashboardComponent },

  {path:"add-product-dashboard", component:AddProductDashboardComponent },
  {path:"product-image", component:ProductImageComponent },
=======
  {path:"cart", component:CartComponent , canActivate:[AuthGuard]}
>>>>>>> parent of 75946e2 (SomeEdits&Dashboard)
]
  @NgModule({
    declarations: [
    BrowseComponent,
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
<<<<<<< HEAD
    WishlistComponent,
    CartComponent,
    DashboardComponent,
    AddCategoryDashboardComponent,
    UpdateCategoryDashboardComponent,
    AddProductDashboardComponent,
    ProductImageComponent,
    UpdateProductDashboardComponent,
    SignUpComponent,
    DistributionComponent,
    DiscoverComponent,
    AppComponent

=======
>>>>>>> parent of 75946e2 (SomeEdits&Dashboard)
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
export class AppModule {

 }
