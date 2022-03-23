import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Repair } from 'src/app/_models/repair';

@Component({
  selector: 'app-repair-card',
  templateUrl: './repair-card.component.html',
  styleUrls: ['./repair-card.component.css']
})
export class RepairCardComponent implements OnInit {
  @Input() repair: Repair;
  
  constructor(public router: Router) { }

  ngOnInit(): void {
  }

}
