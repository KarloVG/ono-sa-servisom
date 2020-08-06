import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CitiesRoutingModule } from './cities-routing.module';
import { CityDetailComponent } from './city-detail/city-detail.component';
import { CityListComponent } from './city-list/city-list.component';


@NgModule({
  declarations: [CityDetailComponent, CityListComponent],
  imports: [
    CommonModule,
    CitiesRoutingModule
  ]
})
export class CitiesModule { }
