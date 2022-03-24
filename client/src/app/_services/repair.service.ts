import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { RepairDetailsComponent } from '../repairs/repair-details/repair-details.component';
import { NewRepair } from '../_models/new_repair';
import { Repair } from '../_models/repair';
import { RepairDetails } from '../_models/repair_details';
import { Vehicle } from '../_models/vehicle';

@Injectable({
  providedIn: 'root'
})
export class RepairService {
  
  baseUrl = environment.apiurl;
  
  constructor(private http: HttpClient) {}

  async addRepair(newRepair: NewRepair){
    return await this.http.post<NewRepair>(this.baseUrl + 'repair', newRepair).subscribe
    (
      (val) => {
          console.log(val);
      });
  }
  updateRepair(repair: RepairDetails){
    return this.http.put(this.baseUrl + 'repair', repair);
  }

  getRepairsByVehicleId(id: number){
    return this.http.get<Repair[]>(this.baseUrl + 'repair/vehicle/' + id);  
  }
  async getRepairDetailsById(id: number){
    return await this.http.get<RepairDetails>(this.baseUrl + 'repair/' + id).toPromise();
  }
}
