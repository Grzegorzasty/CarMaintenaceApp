import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavComponent } from './nav/nav.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { CarListComponent } from './cars/car-list/car-list.component';
import { RepairsComponent } from './repairs/repairs.component';
import { SharedModule } from './_modules/shared.module';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';
import { ErrorInterceptor } from './_interceptors/error.interceptor';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component';
import { CarCardComponent } from './cars/car-card/car-card.component';
import { JwtInterceptor } from './_interceptors/jwt.interceptor';
import { AddVehicleComponent } from './cars/add-vehicle/add-vehicle.component';
import { TextInputComponent } from './_forms/text-input/text-input.component';
import { DateInputComponent } from './_forms/date-input/date-input.component';
import { VehicleEditComponent } from './cars/vehicle-edit/vehicle-edit.component';
import { NgxSpinnerModule } from 'ngx-spinner';
import { LoadingInterceptor } from './_interceptors/loading.interceptor';
import { AddRepairComponent } from './repairs/add-repair/add-repair.component';
import { RepairListComponent } from './repairs/repair-list/repair-list.component';
import { RepairCardComponent } from './repairs/repair-card/repair-card.component';
import { RepairEditComponent } from './repairs/repair-edit/repair-edit.component';
import { RepairDetailsComponent } from './repairs/repair-details/repair-details.component';
import { PhotoEditorComponent } from './repairs/photo-editor/photo-editor.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    HomeComponent,
    RegisterComponent,
    CarListComponent,
    RepairsComponent,
    TestErrorsComponent,
    NotFoundComponent,
    ServerErrorComponent,
    CarCardComponent,
    AddVehicleComponent,
    TextInputComponent,
    DateInputComponent,
    VehicleEditComponent,
    AddRepairComponent,
    RepairListComponent,
    RepairCardComponent,
    RepairEditComponent,
    RepairDetailsComponent,
    PhotoEditorComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    SharedModule,
    NgxSpinnerModule
  ],
  providers: [
    {provide: HTTP_INTERCEPTORS, useClass:ErrorInterceptor, multi: true},
    {provide: HTTP_INTERCEPTORS, useClass:JwtInterceptor, multi: true},
    {provide: HTTP_INTERCEPTORS, useClass:LoadingInterceptor, multi: true}
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
