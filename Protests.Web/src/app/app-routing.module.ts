import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  { path: 'protests', loadChildren: () => import('./protests/protests.module').then(m => m.ProtestsModule) },
  { path: 'organizers', loadChildren: () => import('./organizers/organizers.module').then(m => m.OrganizersModule) },
  { path: 'cities', loadChildren: () => import('./cities/cities.module').then(m => m.CitiesModule) }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
