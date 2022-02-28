import { Injectable } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';

@Injectable({
  providedIn: 'root'
})
export class LoadingSpinnerService {
  busyRequestCount = 0;

  constructor(private spinnerService: NgxSpinnerService) 
  {
    
  }
  busy(){
    this.busyRequestCount++;
    this.spinnerService.show(undefined, {
      type: 'ball-clip-rotate-multiple',
      bdColor: 'rgba(0,0,0,0.4)',
      color: '#fff'
    });
  }

  idle(){
    this.busyRequestCount--;
    if(this.busyRequestCount <= 0){
      this.busyRequestCount = 0;
      this.spinnerService.hide();
    }
  }
}
