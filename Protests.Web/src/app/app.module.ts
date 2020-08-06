import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProtestsModule } from './protests/protests.module';
import { CitiesModule } from './cities/cities.module';
import { OrganizersModule } from './organizers/organizers.module';
import { RepairOptionsModule } from './repair-options/repair-options.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ProtestsModule,
    CitiesModule,
    OrganizersModule,
    RepairOptionsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
