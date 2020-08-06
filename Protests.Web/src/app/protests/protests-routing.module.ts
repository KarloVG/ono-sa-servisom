import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProtestListComponent } from './protest-list/protest-list.component';
import { ProtestDetailComponent } from './protest-detail/protest-detail.component';

const routes: Routes = [
  { path: '', component: ProtestListComponent },
  { path: ':id', component: ProtestDetailComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProtestsRoutingModule { }
