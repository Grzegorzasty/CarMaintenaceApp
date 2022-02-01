import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Vehicle } from '../_models/vehicle';


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
}
