import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  // { path: 'protests', loadChildren: () => import('./protests/protests.module').then(m => m.ProtestsModule) },
  { path: '', loadChildren: () => import('./repair-options/repair-options.module').then(m => m.RepairOptionsModule) },
  { path: 'organizers', loadChildren: () => import('./organizers/organizers.module').then(m => m.OrganizersModule) },
  { path: 'cities', loadChildren: () => import('./cities/cities.module').then(m => m.CitiesModule) },
  { path: 'repair-options', loadChildren: () => import('./repair-options/repair-options.module').then(m => m.RepairOptionsModule) },
  { path: 'cars', loadChildren: () => import('./cars/car.module').then(m => m.CarModule)}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
