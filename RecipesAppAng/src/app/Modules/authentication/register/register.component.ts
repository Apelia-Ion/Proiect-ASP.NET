import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { AuthService } from 'src/app/auth.service';
import { Register } from 'src/app/models/register';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  registrationForm = this.fb.group({
    email: [''],
    password:['']
  });
  constructor(
    private fb : FormBuilder,
   // private authService : AuthService           //circular dependency !!
    ) 
    { }

  ngOnInit(): void {
  }

  // onRegister(){
  //   var newUser = new Register(); 
  //   this.authService.register(newUser).subscribe();
  // }

}
