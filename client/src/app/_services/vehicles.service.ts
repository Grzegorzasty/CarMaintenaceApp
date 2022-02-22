import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { NewVehicle } from '../_models/newvehicle';
import { Vehicle } from '../_models/vehicle';
import { VehicleDetails } from '../_models/vehicle_detail';


@Injectable({
  providedIn: 'root'
})
export class VehiclesService {
  
  baseUrl = environment.apiurl;
  
  constructor(private http: HttpClient) {}

  getVehicles(username: string)
  {
     return this.http.get<Vehicle[]>(this.baseUrl + 'vehicles/' + username);    
  }
  getVehicle(id: number)
  {
    return this.http.get<Vehicle>(this.baseUrl + 'vehicles/details/' + id);
  }
  getVehicleDetails(id: number)
  {
    return this.http.get<VehicleDetails>(this.baseUrl + 'vehicles/edit/' + id);
  }
  addvehicle(model: NewVehicle)
  {
    return this.http.post<NewVehicle>(this.baseUrl + 'vehicles/add', model)
    .subscribe(
      (val) => {
          console.log(val);
      });

  }
}
