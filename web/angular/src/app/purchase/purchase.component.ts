import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { PurchaseService, PurchaseDto, purchaseGroupOptions, PurchaseGroup } from '@proxy/purchases';
import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { formatDate } from '@angular/common';
import { Vendors } from '@proxy';
import { ThisReceiver } from '@angular/compiler';
import { THEME_SHARED_ROUTE_PROVIDERS } from '@abp/ng.theme.shared';

@Component({
  selector: 'app-purchase',
  templateUrl: './purchase.component.html',
  styleUrls: ['./purchase.component.scss'],
  providers: [ListService],
})
export class PurchaseComponent implements OnInit {


  form = this.fb.group({
    startDate: [null, [Validators.required]],
    endDate: [null, [Validators.required]],
    groupBy: [null, [Validators.required]]
  });

  purchaseGroups = purchaseGroupOptions;

  isVendor = false;
  isNone = true;
  paging = 0;
  purchase = { purchases: [], totalCount: 0 } as PagedResultDto<PurchaseDto>;
  selectedItem = '';
  
  constructor(public readonly list: ListService, private purchaseService: PurchaseService, private fb: FormBuilder) {}

  ngOnInit() {
    this.form.controls.startDate.setValue(formatDate(new Date().setMonth(new Date().getMonth() - 1),'yyyy-MM-dd','en'))
    this.form.controls.endDate.setValue(formatDate(new Date(),'yyyy-MM-dd','en'))
    this.form.controls.groupBy.setValue(PurchaseGroup.None)

    this.onChanges();
  }

  onChanges(): void {
    this.form.valueChanges.subscribe(val => {
      if (this.form.invalid) return;
      this.paging = 0;
      //console.log(this.paging)
      if (this.form.controls.groupBy.value == PurchaseGroup.Vendor)
      {
        this.isVendor = true;
        this.isNone = false;
      }
      else if (this.form.controls.groupBy.value == PurchaseGroup.None)
      {
        this.isVendor = false;
        this.isNone = true;
      }


      const itemStreamCreator = (query) => this.purchaseService.getList({...query, startDate: this.form.controls.startDate.value,  endDate: this.form.controls.endDate.value, groupBy: this.form.controls.groupBy.value });
      this.list.hookToQuery(itemStreamCreator).subscribe((response) => {
        this.purchase = response;
      });
    });
  }


  viewItem(id: string) {
    this.selectedItem = id;
  }
}
