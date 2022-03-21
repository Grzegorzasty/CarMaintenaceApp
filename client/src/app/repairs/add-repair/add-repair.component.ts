  import { ChangeDetectionStrategy } from '@angular/compiler/src/compiler_facade_interface';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { NewRepair } from 'src/app/_models/new_repair';
import { Vehicle } from 'src/app/_models/vehicle';
import { VehiclesService } from 'src/app/_services/vehicles.service';

@Component({
  selector: 'app-add-repair',
  templateUrl: './add-repair.component.html',
  styleUrls: ['./add-repair.component.css']
})
export class AddRepairComponent implements OnInit {
  model: NewRepair;
  addRepairForm: FormGroup;
  vehicle: Vehicle;
  validationErrors: string;
  keywords: string[];

  constructor(private vehicleService: VehiclesService, private fb: FormBuilder) { }

  ngOnInit(): void {
    this.initializeForm();
    this.keywords = [];
  }
  initializeForm(){
    this.addRepairForm = this.fb.group({
    dateOfReceipt: [''],
    laborPrice: [''],
    partsPrice: [''],
    // engineOilChange: [false],
    // gearboxOilChange: [false],
    // hydraulicOilChange: [false],
    // engineOilFilterChange: [false],
    // gearboxOilFilterChange: [false],
    // hydraulicOilFilterChange: [false],
    // airFilterChange: [false],
    // cabinFilterChange: [false],
    // fuelFilterChange: [false],
    // brakePadsChange: [false],
    // brakeDiscsChange: [false],
    // brakeFluidChange: [false],
    // engineCamChange: [false],
    // coolantChange: [false],
    keyWords: [''],
    description: [''],
    workshopName: [''],
    })
  }
  addRepair(){
    console.log(this.addRepairForm.value);
  }
   keyWordsFill(event){
     if(event.target.checked){
      this.keywords.push(event.target.name);
      console.log(this.keywords)
     }
     else{
      delete this.keywords[this.keywords.indexOf(event.target.name)]
      console.log(this.keywords)
     }
   }
}
