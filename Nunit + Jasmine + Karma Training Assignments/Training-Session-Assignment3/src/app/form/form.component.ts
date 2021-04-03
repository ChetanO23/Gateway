import { Component, OnInit } from '@angular/core';
import { NgForm, FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';


@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {
  userForm:any;
  constructor(private formBuilder:FormBuilder) { }

  ngOnInit(): void {
    this.userForm = this.formBuilder.group({
      email:['',[Validators.required,Validators.email]],
      username:['',[Validators.required]]
    })
  }

}
