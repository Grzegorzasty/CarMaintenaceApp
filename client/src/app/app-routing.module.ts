import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BikeDetailComponent } from './bikes/bike-detail/bike-detail.component';
import { BikeListComponent } from './bikes/bike-list/bike-list.component';
import { CarDetailComponent } from './cars/car-detail/car-detail.component';
import { CarListComponent } from './cars/car-list/car-list.component';
import { HomeComponent } from './home/home.component';
import { ListsComponent } from './lists/lists.component';
import { RepairsComponent } from './repairs/repairs.component';
import { AuthGuard } from './_guards/auth.guard';

const routes: Routes = [
  {path: '', component: HomeComponent},
  { 
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      {path: 'cars', component: CarListComponent, canActivate: [AuthGuard]},
      {path: 'cars/:id', component: CarDetailComponent},
      {path: 'bikes', component: BikeListComponent},
      {path: 'bikes/:id', component: BikeDetailComponent},
      {path: 'lists', component: ListsComponent},
      {path: 'repairs', component: RepairsComponent},
    ]
  },
  {path: '**', component: HomeComponent, pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
