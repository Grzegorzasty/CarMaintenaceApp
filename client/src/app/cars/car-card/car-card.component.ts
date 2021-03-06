import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Vehicle } from 'src/app/_models/vehicle';
import { VehicleDetails } from 'src/app/_models/vehicle_details';

@Component({
  selector: 'app-car-card',
  templateUrl: './car-card.component.html',
  styleUrls: ['./car-card.component.css']
})
export class CarCardComponent implements OnInit {
  @Input() vehicle: Vehicle;

  constructor(public router: Router) { }

  ngOnInit(): void {
  }

}
