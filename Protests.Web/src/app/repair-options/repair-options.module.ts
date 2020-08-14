import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RepairOptionsRoutingModule } from './repair-options-routing.module';
import { RepairOptionListComponent } from './repair-option-list/repair-option-list.component';
import { RepairOptionDetailComponent } from './repair-option-detail/repair-option-detail.component';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [RepairOptionListComponent, RepairOptionDetailComponent],
  imports: [
    CommonModule,
HttpClientModule,
    RepairOptionsRoutingModule
  ]
})
export class RepairOptionsModule { }
