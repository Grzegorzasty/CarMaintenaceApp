import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { RepairDetails } from 'src/app/_models/repair_details';
import { RepairService } from 'src/app/_services/repair.service';

@Component({
  selector: 'app-repair-edit',
  templateUrl: './repair-edit.component.html',
  styleUrls: ['./repair-edit.component.css']
})
export class RepairEditComponent implements OnInit {
  
  editRepairForm: FormGroup;
  repairDetails: RepairDetails;
  checkBoxValues: string[];
  date: string;

  constructor(private fb: FormBuilder, private repairService: RepairService, private route: ActivatedRoute, private toastr: ToastrService) { }

  async ngOnInit(): Promise<void> {
    await this.loadRepair();
    this.initializeForm();
    console.log(this.repairDetails)
  }

  async loadRepair(){
    this.repairDetails = await this.repairService.getRepairDetailsById(+this.route.snapshot.paramMap.get('id'));
    this.date = this.repairDetails.date.toString().slice(0,10);
    this.checkBoxValues = this.repairDetails.checkBoxValues.split(',');
  }
  checkBoxes(name: string)
  {
    return this.checkBoxValues.includes(name, 0);
  }

  initializeForm(){
    this.editRepairForm = this.fb.group({
    id: [this.repairDetails.id],
    laborPrice: [this.repairDetails.laborPrice, Validators.required],
    partsPrice: [this.repairDetails.partsPrice, Validators.required],
    keyWords: [this.repairDetails.keyWords, Validators.maxLength(200)],
    description: [this.repairDetails.description, Validators.maxLength(200)],
    workshopName: [this.repairDetails.workshopName, Validators.required],
    checkBoxValues: [],
    })
  }
  keyWordsValuesFill(event){
    if(event.target.checked){
     this.checkBoxValues.push(event.target.name);
    }
    else{
     this.checkBoxValues.splice(this.checkBoxValues.indexOf(event.target.name), 1);

    }
  }
  updateRepair(){
    this.editRepairForm.value.checkBoxValues = this.checkBoxValues.toString();
    console.log(this.editRepairForm.value)
    this.repairService.updateRepair(this.repairDetails).subscribe(() => {
      this.toastr.success('Profile updated successfully');
      this.editRepairForm.reset(this.editRepairForm.value);
    })
  }
}
