import { Component, OnInit } from '@angular/core';
import { Company } from 'src/app/model/company.model';
import { CompanyServiceService } from 'src/app/services/company-service.service';

@Component({
  selector: 'app-list-company',
  templateUrl: './list-company.component.html',
  styleUrls: ['./list-company.component.css']
})
export class ListCompanyComponent implements OnInit {
  company!: Company;

  constructor(private companyServiceService: CompanyServiceService) { }

  ngOnInit(): void {

    this.company = this.companyServiceService.getCompany();
  }

}
