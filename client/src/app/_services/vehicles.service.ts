import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { NewVehicle } from '../_models/newvehicle';
import { Vehicle } from '../_models/vehicle';
import { VehicleDetails } from '../_models/vehicle_details';


@Injectable({
  providedIn: 'root'
})
export class VehiclesService {
  
  baseUrl = environment.apiurl;
  
  constructor(private http: HttpClient) {}

  async getVehicles(username: string)
  {
     return await this.http.get<Vehicle[]>(this.baseUrl + 'vehicles/' + username).toPromise();    
  }
  async getVehicleDetails(id: number)
  {
    return await this.http.get<VehicleDetails>(this.baseUrl + 'vehicles/edit/' + id).toPromise();
  }
  async addvehicle(model: NewVehicle)
  {
    return await this.http.post<NewVehicle>(this.baseUrl + 'vehicles/add', model)
    .subscribe(
      (val) => {
          console.log(val);
      });

  }
  updateVehicle(vehicle: VehicleDetails){
    return this.http.put(this.baseUrl + 'vehicles', vehicle); 
  }
  
  deleteVehicle(id: number)
  {
    return this.http.delete(this.baseUrl + 'vehicles/delete/' + id);
  }
}
