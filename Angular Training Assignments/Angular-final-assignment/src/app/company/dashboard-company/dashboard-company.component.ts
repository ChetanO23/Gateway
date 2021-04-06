import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { CompanyServiceService } from 'src/app/services/company-service.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-dashboard-company',
  templateUrl: './dashboard-company.component.html',
  styleUrls: ['./dashboard-company.component.css']
})
export class DashboardCompanyComponent implements OnInit {

  companies: any = [];
  addCompanyForm !: FormGroup;
  constructor(private httpClient: HttpClient, private router:Router, private companyServiceService : CompanyServiceService) { }

  ngOnInit(): void {
   
    this.httpClient.get("http://localhost:3000/company").subscribe(data =>{
      console.log(data);
      this.companies = data;  
    })
  }

  loadCompanyToEdit(id : number)
  {
    this.companyServiceService.getById(id).subscribe(company => {
      this.companyServiceService.companyDetails(company);
      this.router.navigate(['/edit-company']);
    })
  }

  deleteCompany(id : number)
  {
    debugger;
    this.alertWithwarning();
      this.companyServiceService.delete(id).subscribe(res => {
       // setTimeout("location.reload(true);", 100);
        console.log(res);
      });
  }
  alertWithwarning() {
    debugger;
    Swal.fire('Warning...', 'Are you Sure to want to delete?', 'warning') 
  }
  companyList(id: number)
  {
    this.companyServiceService.getById(id).subscribe(company => {
      this.companyServiceService.companyDetails(company);
      this.router.navigate(['/list-company']);
    })
  }




}

