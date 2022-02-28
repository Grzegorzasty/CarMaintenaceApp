import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, ValidatorFn, Validators } from '@angular/forms';
import { Router } from '@angular/router';
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
  addVehicleForm: FormGroup;
  validationErrors: string;

  constructor(private accountService: AccountService, private vehicleService: VehiclesService, private fb: FormBuilder, private router: Router)
  {
    this.accountService.currentUser$.pipe(take(1)).subscribe(user => this.user = user);
  }

  ngOnInit(): void {
    this.initializeForm();
  }

  initializeForm(){
    this.addVehicleForm = this.fb.group({
      type: ['car'],
      manufacturer: ['', Validators.required],
      model: ['', Validators.required],
      yearOfProduction: ['', Validators.required],
      vinNumber: ['', [Validators.minLength(17), Validators.maxLength(17)]],
      purchasePrize: [''],
      description: ['', Validators.maxLength(200)],
      appUserId: ['']
    })
  }

  async addvehicle(){
    this.addVehicleForm.value.appUserId = this.user.id;
    console.log(this.addVehicleForm.value);
    await this.vehicleService.addvehicle(this.addVehicleForm.value); 
    this.router.navigateByUrl('/vehicles');
  }
}
