import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { VehicleDetails } from 'src/app/_models/vehicle_details';
import { VehiclesService } from 'src/app/_services/vehicles.service';

@Component({
  selector: 'app-vehicle-edit',
  templateUrl: './vehicle-edit.component.html',
  styleUrls: ['./vehicle-edit.component.css']
})
export class VehicleEditComponent implements OnInit {
  vehicleDetails: VehicleDetails;
  constructor(private vehicleService: VehiclesService, private route: ActivatedRoute, private fb: FormBuilder, private router: Router) {
   }

  ngOnInit(): void {
    this.loadVehicle();
  }

  async loadVehicle(){
    await this.vehicleService.getVehicleDetails(+this.route.snapshot.paramMap.get('id')).subscribe(veh => 
      {
        this.vehicleDetails = veh;
      })
  }
  updateVehicle(){
  }
}
