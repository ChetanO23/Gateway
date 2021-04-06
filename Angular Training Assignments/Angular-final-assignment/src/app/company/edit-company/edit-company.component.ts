import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Company } from 'src/app/model/company.model';
import { CompanyServiceService } from 'src/app/services/company-service.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-edit-company',
  templateUrl: './edit-company.component.html',
  styleUrls: ['./edit-company.component.css']
})
export class EditCompanyComponent implements OnInit {

  submitted = false;

  addCompanyForm !: FormGroup;
  company !: Company;
  

  constructor(private formBuilder: FormBuilder, private router:
    Router, private companyServiceService : CompanyServiceService) { }

  ngOnInit(): void {
    this.addCompanyForm = this.formBuilder.group({
      id : ['', [Validators.required]],
      name : ['', [Validators.required, Validators.minLength(5)]],
      email: ['', [Validators.required, Validators.email, Validators.pattern("^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$")]],
      address: ['', Validators.required],
      totalEmployees: ['', Validators.required],
      totalBranch: ['', Validators.required],
      isActive: ['', Validators.required],
      branch : this.formBuilder.array([])
    });

    this.company = this.companyServiceService.getCompany();
    
    for(const index in this.company.branch){
        this.addBranch();
    }
      this.addCompanyForm.setValue(this.company)
  }

  get registerFormControl() {
    return this.addCompanyForm.controls;
  }

  get branchs()
  {
    return this.addCompanyForm.get('branch') as FormArray;
  }

  onCreate() : FormGroup {
    return this.formBuilder.group({
      id : Math.floor(Math.random()*10)+ (new Date()).getTime() ,
      name: '', 
      address: ''
    })
  }

  onSubmit()
  { 
    debugger;
    this.submitted = true;
    
    if(this.addCompanyForm.invalid)
    {
      return;
    }

    else {
      console.log(this.company);
      this.companyServiceService.update(this.addCompanyForm.value).subscribe(
        res => {
         this.successNotification();
          this.router.navigate(['/dashboard-company']);
         // setTimeout("location.reload(true);", 100);
          this.addCompanyForm.reset();
        }
      );
    }
  }
  successNotification(){
    Swal.fire('Your changes are Done Successfully', 'Thank you', 'success')
  }
  addBranch()
  {
    this.branchs.push(this.onCreate())
  }

  deleteBranch(index : number) {
    this.branchs.removeAt(index);
  }

}