import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RepairOptionListComponent } from './repair-option-list/repair-option-list.component';
import { RepairOptionDetailComponent } from './repair-option-detail/repair-option-detail.component';

const routes: Routes = [
  { path: '', component: RepairOptionListComponent },
  { path: ':id', component: RepairOptionDetailComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class RepairOptionsRoutingModule { }
