import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanDeactivate, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { VehicleEditComponent } from '../cars/vehicle-edit/vehicle-edit.component';

@Injectable({
  providedIn: 'root'
})
export class PreventUnsavedChangesGuard implements CanDeactivate<unknown> {
  canDeactivate(
    component: VehicleEditComponent): boolean {
      if(component.editVehicleForm.dirty)
      {
          return confirm('Are you sure you want to continue? Any unsaved changes will be lost!')
      }
    return true;
  }
  
}
