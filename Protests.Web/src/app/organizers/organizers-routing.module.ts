import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { OrganizerListComponent } from './organizer-list/organizer-list.component';
import { OrganizerDetailComponent } from './organizer-detail/organizer-detail.component';

const routes: Routes = [
  { path: '', component: OrganizerListComponent },
  { path: ':id', component: OrganizerDetailComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class OrganizersRoutingModule { }
