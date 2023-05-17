import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { StoreComponent } from './store/store.component';
import { DistributionComponent } from './distribution/distribution.component';
import { DiscoverComponent } from './discover/discover.component';
import { BrowseComponent } from './browse/browse.component';

@NgModule({
  declarations: [
    AppComponent,
    StoreComponent,
    DistributionComponent,
    DiscoverComponent,
    BrowseComponent,
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
