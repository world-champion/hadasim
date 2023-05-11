import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { User } from '../Models/User';
import { UserServiceService } from '../Service/user-service.service';
import Swal from 'sweetalert2';
@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.scss']
})
export class UserComponent {
  UserForm!: FormGroup;
 constructor(private formBuilder: FormBuilder,private userService:UserServiceService){}
 newUser=new User(0,"","","","","",0,new Date(),"","");
 val:boolean=true
 ngOnInit(){
  this.UserForm = this.formBuilder.group({
    "firstName": ['', [Validators.required, 
      Validators.minLength(2),
      Validators.maxLength(50),
      Validators.pattern('[a-zA-Z ]*')]],
    "lastName": ['', [Validators.required, 
      Validators.minLength(2),
      Validators.maxLength(50),
      Validators.pattern('[a-zA-Z ]*')]],
    "identity": ['',  [Validators.required,
    Validators.minLength(9),
    Validators.maxLength(9),
    Validators.pattern('[0-9]+')]],
    "city": ['', [Validators.required, 
      Validators.minLength(2),
      Validators.maxLength(50),
      Validators.pattern('[a-zA-Z ]*')]],
    "street": ['', [Validators.required, 
      Validators.minLength(2),
      Validators.maxLength(50)]],
    "numHome": ['', [Validators.required]],
    "birthDate": ['', Validators.required],
    "cellPhone": ['', [Validators.required, Validators.pattern('[0-9]+'), 
                    Validators.minLength(9)]],
    "phone": ['', [Validators.required, Validators.pattern('[0-9]+'),
                  Validators.minLength(9)]]
 }as Record<string, any>);
}
 addUser(newUser:User){
  this.userService.addUser(newUser).subscribe((addUser)=>{
    this.newUser=addUser
    this.UserForm.controls['id'];
  })
  this.newUser=new User(0,"","","","","",0,new Date(),"","")
 }
 onSubmit(){
  if (!this.checkAgian()) {
    const newUser: User = {
      id:0,
      firstName: this.UserForm.value.firstName,
      lastName: this.UserForm.value.lastName,
      identity: this.UserForm.value.identity,
      city: this.UserForm.value.city,
      street: this.UserForm.value.street,
      numHome: this.UserForm.value.numHome,
      birthDate: this.UserForm.value.birthDate,
      cellPhone: this.UserForm.value.cellPhone,
      phone: this.UserForm.value.phone,
      
    };
    this.addUser(newUser)
    this.ngOnInit();
  } else {
    this.showAlert();
  }
 }
 checkAgian():boolean{
  console.log(this.UserForm.controls['birthDate'].invalid)
  console.log(
  this.UserForm.controls['firstName'].invalid )
  console.log(
       this.UserForm.controls['lastName'].invalid )
       console.log(
       this.UserForm.controls['identity'].invalid )
       console.log(
       this.UserForm.controls['city'].invalid )
       console.log(
       this.UserForm.controls['street'].invalid )
       console.log(
       this.UserForm.controls['numHome'].invalid )
       console.log(
      this.UserForm.controls['birthDate'].invalid )
      console.log(
      this.UserForm.controls['cellPhone'].invalid )
      console.log(
      this.UserForm.controls['phone'].invalid)
  return (this.UserForm.controls['birthDate'].invalid||
  this.UserForm.controls['firstName'].invalid ||
       this.UserForm.controls['lastName'].invalid ||
       this.UserForm.controls['identity'].invalid ||
       this.UserForm.controls['city'].invalid ||
       this.UserForm.controls['street'].invalid ||
       this.UserForm.controls['numHome'].invalid ||
      this.UserForm.controls['birthDate'].invalid ||
      this.UserForm.controls['cellPhone'].invalid ||
      this.UserForm.controls['phone'].invalid)

 }
 showAlert() {
  Swal.fire({
    title: 'there are wrong parameter!',
    icon: 'error',
    confirmButtonText: 'OK'
  });
}
}
