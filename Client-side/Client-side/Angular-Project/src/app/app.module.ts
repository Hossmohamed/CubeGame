import { Component, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
//import { RouterModule, Routes} from '@angular/router'

import { AppComponent } from './app.component';
import { StoreComponent } from './store/store.component';
import { DistributionComponent } from './distribution/distribution.component';
import { DiscoverComponent } from './discover/discover.component';
import { BrowseComponent } from './browse/browse.component';
import { LoginComponent } from './login/login.component';

/*let routes:Routes = [
  {path:"", component:DiscoverComponent},
  {path:"Browse", component:BrowseComponent },
]*/

@NgModule({
  declarations: [
    AppComponent,
    StoreComponent,
    DistributionComponent,
    DiscoverComponent,
    BrowseComponent,
    LoginComponent,
  ],
  imports: [
    BrowserModule,
    //RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
