import { Component, OnInit } from '@angular/core';
import { take } from 'rxjs/operators';
import { NewVehicle } from 'src/app/_models/newvehicle';
import { User } from 'src/app/_models/user';
import { AccountService } from 'src/app/_services/account.service';
import { VehiclesService } from 'src/app/_services/vehicles.service';

@Component({
  selector: 'app-add-vehicle',
  templateUrl: './add-vehicle.component.html',
  styleUrls: ['./add-vehicle.component.css']
})
export class AddVehicleComponent implements OnInit {
  model: NewVehicle;
  user: User;

  constructor(private accountService: AccountService, private vehicleService: VehiclesService)
  {
    this.model = {
      Type: '',
      Manufacturer: '',
      Model: '',
      YearOfProduction: undefined,
      VinNumber: '',
      PurchasePrize: undefined,
      Description: '',
      AppUserId: undefined
    };
    this.accountService.currentUser$.pipe(take(1)).subscribe(user => this.user = user);
  }

  ngOnInit(): void {
  }

  addvehicle(){
    console.log(this.model);
    this.model.AppUserId = this.user.id;
    return this.vehicleService.addvehicle(this.model); 
  }
}
