import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Repair } from 'src/app/_models/repair';
import { DateTime } from 'luxon';

@Component({
  selector: 'app-repair-card',
  templateUrl: './repair-card.component.html',
  styleUrls: ['./repair-card.component.css']
})
export class RepairCardComponent implements OnInit {
  @Input() repair: Repair;
  repairDate: DateTime;
  
  constructor(public router: Router) { }

  ngOnInit(): void {
    console.log(this.repair.date)
    this.repairDate = DateTime.fromJSDate(new Date(this.repair.date)).toFormat('dd/MM/yyyy');
  }

}
