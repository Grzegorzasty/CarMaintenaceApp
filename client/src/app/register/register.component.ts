import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { AbstractControl, FormControl, FormGroup, ValidatorFn, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @Output() cancelRegister = new EventEmitter();

  model: any = {};
  registerForm: FormGroup;

  constructor(private accountService: AccountService, private toastr: ToastrService) { }

  ngOnInit(): void {
    this.initializeForm();
  }

  initializeForm(){
    this.registerForm = new FormGroup({
      username: new FormControl('', Validators.required),
      password: new FormControl('', Validators.required),
      confirmPassword: new FormControl('', [Validators.required, this.matchValues('password')])
    })
    this.registerForm.controls.password.valueChanges.subscribe(() => {
      this.registerForm.controls.password.updateValueAndValidity();
    })
  }

  matchValues(matchTo: string): ValidatorFn
  {
    return (control: AbstractControl) => {
      return control?.value === control?.parent?.controls[matchTo].value ? null : {isMatching: true}
    }
  }
  
  register(){
    // this.accountService.register(this.model).subscribe(response =>{
    //   console.log(response);
    //   this.cancel();
    // }, error => 
    // {
    //   console.log(error);
    //   this.toastr.error(error.error);
    // })

    console.log(this.registerForm.value)
  }

  cancel(){
    this.cancelRegister.emit(false);
  }

}