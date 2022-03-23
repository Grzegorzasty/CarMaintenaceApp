import { Component, HostListener, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { VehicleDetails } from 'src/app/_models/vehicle_details';
import { VehiclesService } from 'src/app/_services/vehicles.service';

@Component({
  selector: 'app-vehicle-edit',
  templateUrl: './vehicle-edit.component.html',
  styleUrls: ['./vehicle-edit.component.css']
})
export class VehicleEditComponent implements OnInit {
  vehicleDetails: VehicleDetails;
  editVehicleForm: FormGroup;
  @HostListener('window:beforeunload', ['$event']) unloadNotification($event: any){
    if(this.editVehicleForm.dirty){
      $event.returnValue = true;
    }
  }
  constructor(private vehicleService: VehiclesService, private route: ActivatedRoute, private fb: FormBuilder, private router: Router, private toastr: ToastrService) {
   }

  async ngOnInit(): Promise<void> {
    await this.loadVehicle();
    this.initializeForm();
  }

  async loadVehicle(){
    this.vehicleDetails = await this.vehicleService.getVehicleDetails(+this.route.snapshot.paramMap.get('id'));
  }
  initializeForm(){
    this.editVehicleForm = this.fb.group({
        id: [this.vehicleDetails.id],
        type: [this.vehicleDetails.type],
        manufacturer: [this.vehicleDetails.manufacturer, Validators.required],
        model: [this.vehicleDetails.model, Validators.required],
        yearOfProduction: [this.vehicleDetails.yearOfProduction, Validators.required],
        vinNumber: [this.vehicleDetails.vinNumber, [Validators.minLength(17), Validators.maxLength(17)]],
        purchasePrize: [this.vehicleDetails.purchasePrize],
        description: [this.vehicleDetails.description, Validators.maxLength(200)],
      })
  }
  updateVehicle(){
    this.vehicleDetails = this.editVehicleForm.value;
    this.vehicleService.updateVehicle(this.vehicleDetails).subscribe(() => {
      this.toastr.success('Profile updated successfully');
      this.editVehicleForm.reset(this.editVehicleForm.value);
    })
  }
  deleteVehicle(){
    this.vehicleService.deleteVehicle(this.vehicleDetails.id).subscribe(() => {
      this.toastr.success('Vehicle deleted successfully');
      this.router.navigateByUrl('/vehicles');
    })
  }
}
