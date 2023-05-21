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
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
