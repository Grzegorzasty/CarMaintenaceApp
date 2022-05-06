import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { RepairDetails } from 'src/app/_models/repair_details';
import { RepairService } from 'src/app/_services/repair.service';
import { DateTime } from 'luxon';

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
    this.checkBoxValues = [];
    await this.loadRepair();
    this.initializeForm();
  }

  async loadRepair(){
    this.repairDetails = await this.repairService.getRepairDetailsById(+this.route.snapshot.paramMap.get('id'));
    this.date = DateTime.fromJSDate(new Date(this.repairDetails.date)).toFormat('dd/MM/yyyy');
    this.checkBoxValues = this.repairDetails.checkBoxValues.split(',');
  }
  checkBoxes(id: string)
  {
    return this.checkBoxValues.includes(id, 0);
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
     this.checkBoxValues.push(event.target.id);
    }
    else{
     this.checkBoxValues.splice(this.checkBoxValues.indexOf(event.target.id), 1);
    }
  }
  updateRepair(){
    this.editRepairForm.value.checkBoxValues = this.checkBoxValues.toString();
    this.repairDetails = this.editRepairForm.value;
    this.repairService.updateRepair(this.repairDetails).subscribe(() => {
      this.toastr.success('Profile updated successfully');
      this.editRepairForm.reset(this.editRepairForm.value);
    })
  }
}
