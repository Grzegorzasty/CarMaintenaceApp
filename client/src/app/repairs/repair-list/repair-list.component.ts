import { Component, OnInit } from '@angular/core';
import { ActivatedRoute} from '@angular/router';
import * as Repair from 'src/app/_models/repair';
import { RepairService } from 'src/app/_services/repair.service';

@Component({
  selector: 'app-repair-list',
  templateUrl: './repair-list.component.html',
  styleUrls: ['./repair-list.component.css']
})
export class RepairListComponent implements OnInit {

  repairs: Repair.Repair[];

  constructor(private repairService: RepairService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.loadRepairs();
  }
  loadRepairs(){
    this.repairService.getRepairsByVehicleId(+this.route.snapshot.paramMap.get('id')).subscribe(repairs => {this.repairs = repairs;})
  }
}
