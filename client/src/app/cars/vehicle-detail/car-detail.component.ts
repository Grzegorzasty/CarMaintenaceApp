import { Component, OnChanges, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Vehicle } from 'src/app/_models/vehicle';
import { VehiclesService } from 'src/app/_services/vehicles.service';

@Component({
  selector: 'app-car-detail',
  templateUrl: './car-detail.component.html',
  styleUrls: ['./car-detail.component.css']
})
export class CarDetailComponent implements OnInit {
  vehicle: Vehicle;
  constructor(private vehicleService: VehiclesService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.loadVehicle();
  }

  loadVehicle(){
    this.vehicleService.getVehicle(+this.route.snapshot.paramMap.get('id')).subscribe(veh => {this.vehicle = veh;});
  }
}
