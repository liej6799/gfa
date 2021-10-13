import { ListService, PagedResultDto } from '@abp/ng.core';
import { formatDate } from '@angular/common';
import { Component, OnInit, Input, Output, OnChanges, SimpleChanges, Inject, LOCALE_ID } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { PurchaseItemService, PurchaseItemDto, PurchaseService } from '@proxy/purchases';
@Component({
  selector: 'app-purchase-item',
  templateUrl: './purchase-item.component.html',
  providers: [ListService],
})

export class PurchaseItemComponent implements OnChanges {

  form = this.fb.group({
    datePurchase: [null],
    sourceId: [null],
    vendorName: [null]
  });


  @Input() item = '';
  @Input() filter = '';
  isModalOpen = false;
  purchaseItem = { purchaseItems: [], totalCount: 0 } as PagedResultDto<PurchaseItemDto>;

  constructor(public readonly list: ListService, private purchaseItemService: PurchaseItemService, private fb: FormBuilder, @Inject(LOCALE_ID) private locale: string,
    private purchaseService: PurchaseService) { }

  transformDate(date) {
    return formatDate(date, 'medium', this.locale);
  }

  ngOnChanges(changes: SimpleChanges): void {
    if (this.item) {
      this.list.filter = this.filter;

      this.purchaseService.get(this.item).subscribe((response) => {
        response.sourceId
        this.form.controls.datePurchase.setValue(this.transformDate(response.datePurchase));
        this.form.controls.sourceId.setValue(response.sourceId);
        this.form.controls.vendorName.setValue(response.vendorName);
      });


      const itemStreamCreator = (query) => this.purchaseItemService.getList({ ...query, purchaseId: this.item });
      this.list.hookToQuery(itemStreamCreator).subscribe((response) => {
        this.purchaseItem = response;

        this.isModalOpen = true;
      });
    }
  }
}