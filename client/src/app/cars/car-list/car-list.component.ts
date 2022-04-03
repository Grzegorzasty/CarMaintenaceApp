import { Component, OnInit } from '@angular/core';
import { take } from 'rxjs/operators';
import { User } from 'src/app/_models/user';
import * as Vehicle from 'src/app/_models/vehicle';
import { AccountService } from 'src/app/_services/account.service';
import { VehiclesService } from 'src/app/_services/vehicles.service';

@Component({
  selector: 'app-car-list',
  templateUrl: './car-list.component.html',
  styleUrls: ['./car-list.component.css']
})
export class CarListComponent implements OnInit {
  
  vehicles: Vehicle.Vehicle[];
  user: User;
  constructor(private accountService: AccountService, private vehiclesService: VehiclesService) 
  {
    this.accountService.currentUser$.pipe(take(1)).subscribe(user => this.user = user);
  }

  ngOnInit(): void
  {
    this.loadVehicles();
  }

  async loadVehicles()
  {
    this.vehicles = await this.vehiclesService.getVehicles(this.user.username);
  }
}
