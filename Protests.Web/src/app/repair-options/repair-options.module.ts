import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RepairOptionsRoutingModule } from './repair-options-routing.module';
import { RepairOptionListComponent } from './repair-option-list/repair-option-list.component';
import { RepairOptionDetailComponent } from './repair-option-detail/repair-option-detail.component';


@NgModule({
  declarations: [RepairOptionListComponent, RepairOptionDetailComponent],
  imports: [
    CommonModule,
    RepairOptionsRoutingModule
  ]
})
export class RepairOptionsModule { }
