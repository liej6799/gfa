import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { SaleService, SaleDto } from '@proxy/sales';
import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { formatDate } from '@angular/common';

@Component({
  selector: 'app-sale',
  templateUrl: './sale.component.html',
  styleUrls: ['./sale.component.scss'],
  providers: [ListService],
})
export class SaleComponent implements OnInit {
  sale = { sales: [], totalCount: 0 } as PagedResultDto<SaleDto>;
  paging = 0;
  selectedSalesItem = '';

  form = this.fb.group({
    startDate: [null, [Validators.required]],
    endDate: [null, [Validators.required]],
  });

  constructor(
    public readonly list: ListService,
    private saleService: SaleService,
    private fb: FormBuilder
  ) {}

  ngOnInit() {
    this.onChanges();

    this.form.controls.startDate.setValue(
      formatDate(new Date().setMonth(new Date().getMonth() - 1), 'yyyy-MM-dd', 'en')
    );
    this.form.controls.endDate.setValue(formatDate(new Date(), 'yyyy-MM-dd', 'en'));
  }
  onChanges() {
    this.form.valueChanges.subscribe(val => {
      if (this.form.invalid) return;
      this.paging = 0;

      const itemStreamCreator = query =>
        this.saleService.getList({
          ...query,
          startDate: this.form.controls.startDate.value,
          endDate: this.form.controls.endDate.value,
        });
      this.list.hookToQuery(itemStreamCreator).subscribe(response => {
        this.sale = response;
      });
    });
  }

  viewItem(id: string) {
    this.selectedSalesItem = id;
  }
}
