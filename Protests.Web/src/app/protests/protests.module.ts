import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ProtestsRoutingModule } from './protests-routing.module';
import { ProtestListComponent } from './protest-list/protest-list.component';
import { ProtestDetailComponent } from './protest-detail/protest-detail.component';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [ProtestListComponent, ProtestDetailComponent],
  imports: [
    CommonModule,
    ProtestsRoutingModule,
    HttpClientModule
  ]
})
export class ProtestsModule { }
