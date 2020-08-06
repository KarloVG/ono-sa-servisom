import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { OrganizersRoutingModule } from './organizers-routing.module';
import { OrganizerListComponent } from './organizer-list/organizer-list.component';
import { OrganizerDetailComponent } from './organizer-detail/organizer-detail.component';


@NgModule({
  declarations: [OrganizerListComponent, OrganizerDetailComponent],
  imports: [
    CommonModule,
    OrganizersRoutingModule
  ]
})
export class OrganizersModule { }
