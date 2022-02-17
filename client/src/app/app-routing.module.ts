import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BikeDetailComponent } from './bikes/bike-detail/bike-detail.component';
import { BikeListComponent } from './bikes/bike-list/bike-list.component';
import { CarDetailComponent } from './cars/vehicle-detail/car-detail.component';
import { CarListComponent } from './cars/car-list/car-list.component';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';
import { HomeComponent } from './home/home.component';
import { ListsComponent } from './lists/lists.component';
import { RepairsComponent } from './repairs/repairs.component';
import { AuthGuard } from './_guards/auth.guard';
import { AddVehicleComponent } from './cars/add-vehicle/add-vehicle.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  { 
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      {path: 'vehicles', component: CarListComponent, canActivate: [AuthGuard]},
      {path: 'vehicles/details/:id', component: CarDetailComponent},
      {path: 'vehicles/add', component: AddVehicleComponent},
      {path: 'bikes', component: BikeListComponent},
      {path: 'bikes/:id', component: BikeDetailComponent},
      {path: 'lists', component: ListsComponent},
      {path: 'repairs', component: RepairsComponent},
    ]
  },
  {path: 'errors', component: TestErrorsComponent},
  {path: 'server-error', component: ServerErrorComponent},
  {path: 'not-found', component: NotFoundComponent},
  {path: '**', component: HomeComponent, pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
