  import { ChangeDetectionStrategy } from '@angular/compiler/src/compiler_facade_interface';
import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { CarCardComponent } from 'src/app/cars/car-card/car-card.component';
import { NewRepair } from 'src/app/_models/new_repair';
import { RepairService } from 'src/app/_services/repair.service';

@Component({
  selector: 'app-add-repair',
  templateUrl: './add-repair.component.html',
  styleUrls: ['./add-repair.component.css']
})
export class AddRepairComponent implements OnInit {
  vehicle: CarCardComponent;
  model: NewRepair;
  addRepairForm: FormGroup;
  validationErrors: string;
  checkBoxValues: string[];

  constructor(private repairService: RepairService, private fb: FormBuilder, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.initializeForm();
    this.checkBoxValues = [];
  }


  initializeForm(){
    this.addRepairForm = this.fb.group({
    dateOfReceipt: [''],
    laborPrice: ['', Validators.required],
    partsPrice: ['', Validators.required],
    keyWords: ['', Validators.maxLength(200)],
    description: ['', Validators.maxLength(200)],
    workshopName: ['', Validators.required],
    checkBoxValues: [''],
    vehicleId:[]
    })
  }
  async addRepair(){
    this.addRepairForm.value.checkBoxValues = this.checkBoxValues.toString();
    this.addRepairForm.value.vehicleId = +this.route.snapshot.paramMap.get('id')
    console.log(this.addRepairForm.value);
    await this.repairService.addRepair(this.addRepairForm.value); 

    // console.log(this.checkBoxValues.toString().split(',').filter((el) => {
    //   return el !== '';
    // }))
  }
   keyWordsValuesFill(event){
     if(event.target.checked){
      this.checkBoxValues.push(event.target.name);
     }
     else{
      delete this.checkBoxValues[this.checkBoxValues.indexOf(event.target.name)];
     }
   }
}
