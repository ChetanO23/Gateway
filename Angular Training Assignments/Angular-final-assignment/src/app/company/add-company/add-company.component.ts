import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Company } from 'src/app/model/company.model';
import { CompanyServiceService } from 'src/app/services/company-service.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-add-company',
  templateUrl: './add-company.component.html',
  styleUrls: ['./add-company.component.css']
})
export class AddCompanyComponent implements OnInit {

  submitted = false;

  addCompanyForm !: FormGroup;
  company !: Company[];
  constructor(private formBuilder: FormBuilder,
               private router:Router,
               private companyServiceService : CompanyServiceService) { }

  ngOnInit(): void {
    this.addCompanyForm = this.formBuilder.group({
      id : [Math.floor(Math.random()*10)+ (new Date()).getTime()],
      name : ['', [Validators.required, Validators.minLength(5)]],
      email: ['', [Validators.required, Validators.email, Validators.pattern("^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$")]],
      address: ['', Validators.required],
      totalEmployees: ['', Validators.required],
      totalBranch: ['', Validators.required],
      isActive: ['', Validators.required],
      branch : this.formBuilder.array([this.formBuilder.group({id : Math.floor(Math.random()*10)+ (new Date()).getTime() , name: '', address: ''})])
    });
  }

  get registerFormControl() {
    return this.addCompanyForm.controls;
  }

  get branchs()
  {
    return this.addCompanyForm.get('branch') as FormArray;
  }

  onSubmit()
  { 
    debugger;
    this.submitted = true;
    if(this.addCompanyForm.invalid)
    {
      Swal.fire({  
        icon: 'error',
        title: 'Please Fill All Details',
        timer: 1500
      }) 
      return;
    }else {
      // console.log(this.addCompanyForm.value);
      // companies.company.push(this.addCompanyForm.value)
      //debugger;
      this.companyServiceService.create(this.addCompanyForm.value).subscribe(
        res => {
          
          debugger;
          this.alertWithSuccess();
          this.router.navigate(['/dashboard-company']);
         // setTimeout("location.reload(true);", 100);
          this.addCompanyForm.reset();
         
        }
      );
    }
  
  }
  alertWithSuccess() {
    debugger;
    Swal.fire('Great...', 'Your company is added succesfully!', 'success') 
  }

  addBranch()
  {
    this.branchs.push(this.formBuilder.group({id : '', name: '', address: ''}))
  }

  deleteBranch(index : number) {
    this.branchs.removeAt(index);
  }

}
