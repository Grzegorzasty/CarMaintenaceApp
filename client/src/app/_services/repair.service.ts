import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { NewRepair } from '../_models/new_repair';
import { RepairDetails } from '../_models/repair_details';

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
    return this.http.put(this.baseUrl + 'repair/edit', repair);
  }
}
