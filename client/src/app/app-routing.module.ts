import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CarListComponent } from './cars/car-list/car-list.component';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';
import { HomeComponent } from './home/home.component';
import { RepairsComponent } from './repairs/repairs.component';
import { AuthGuard } from './_guards/auth.guard';
import { AddVehicleComponent } from './cars/add-vehicle/add-vehicle.component';
import { VehicleEditComponent } from './cars/vehicle-edit/vehicle-edit.component';
import { PreventUnsavedChangesGuard } from './_guards/prevent-unsaved-changes.guard';
import { AddRepairComponent } from './repairs/add-repair/add-repair.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  { 
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      {path: 'vehicles', component: CarListComponent},
      {path: 'vehicles/edit/:id', component: VehicleEditComponent, canDeactivate: [PreventUnsavedChangesGuard]},
      {path: 'vehicles/add', component: AddVehicleComponent},
      {path: 'repairs', component: RepairsComponent},
      {path: 'vehicles/:id/repair/add', component: AddRepairComponent},
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
