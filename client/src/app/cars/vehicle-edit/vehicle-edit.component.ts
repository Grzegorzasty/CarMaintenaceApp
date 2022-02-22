import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Vehicle } from 'src/app/_models/vehicle';
import { VehicleDetails } from 'src/app/_models/vehicle_detail';
import { VehiclesService } from 'src/app/_services/vehicles.service';

@Component({
  selector: 'app-vehicle-edit',
  templateUrl: './vehicle-edit.component.html',
  styleUrls: ['./vehicle-edit.component.css']
})
export class VehicleEditComponent implements OnInit {
  vehicleDetails: VehicleDetails;
  constructor(private vehicleService: VehiclesService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.loadVehicle();
  }

  loadVehicle(){
    this.vehicleService.getVehicleDetails(+this.route.snapshot.paramMap.get('id')).subscribe(veh => {this.vehicleDetails = veh;});
  }
}
