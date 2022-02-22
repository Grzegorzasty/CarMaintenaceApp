import { Component, OnChanges, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Vehicle } from 'src/app/_models/vehicle';
import { VehicleDetails } from 'src/app/_models/vehicle_detail';
import { VehiclesService } from 'src/app/_services/vehicles.service';

@Component({
  selector: 'app-car-detail',
  templateUrl: './car-detail.component.html',
  styleUrls: ['./car-detail.component.css']
})
export class CarDetailComponent implements OnInit {
  vehicle: VehicleDetails;
  constructor(private vehicleService: VehiclesService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.loadVehicleDetail();
  }

  loadVehicleDetail(){
    this.vehicleService.getVehicleDetails(+this.route.snapshot.paramMap.get('id')).subscribe(veh => {this.vehicle = veh;});
  }
}
