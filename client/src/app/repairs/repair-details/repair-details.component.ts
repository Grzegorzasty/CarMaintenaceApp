import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { DateInputComponent } from 'src/app/_forms/date-input/date-input.component';
import { RepairDetails } from 'src/app/_models/repair_details';
import { DateTime } from 'luxon';
import { RepairService } from 'src/app/_services/repair.service';

@Component({
  selector: 'app-repair-details',
  templateUrl: './repair-details.component.html',
  styleUrls: ['./repair-details.component.css']
})
export class RepairDetailsComponent implements OnInit {

  repairDetails: RepairDetails;
  date: string;
  checkBoxValues: string[];

  constructor(private repairService: RepairService, private route: ActivatedRoute) { }

  async ngOnInit(): Promise<void> {
    this.checkBoxValues = [];
    await this.loadRepair();
  }
  async loadRepair(){
    this.repairDetails = await this.repairService.getRepairDetailsById(+this.route.snapshot.paramMap.get('id'));
    this.date = DateTime.fromJSDate(new Date(this.repairDetails.date)).toFormat('dd/MM/yyyy');
    this.checkBoxValues = this.repairDetails.checkBoxValues.split(',');
  }
  keyWordsValuesFill(event){
    if(event.target.checked){
     this.checkBoxValues.push(event.target.id);
    }
    else{
     this.checkBoxValues.splice(this.checkBoxValues.indexOf(event.target.id), 1);
    }
  }
  checkBoxes(id: string)
  {
    return this.checkBoxValues.includes(id, 0);
  }
}
