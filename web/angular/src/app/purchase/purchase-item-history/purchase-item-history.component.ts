import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit, Input, Output, OnChanges, SimpleChanges, EventEmitter } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { ItemService } from '@proxy/items';

import { PurchaseItemService, PurchaseItemDto } from '@proxy/purchases';
import { SortEvent,  } from 'src/app/helper/NgbdSortableHeader';
@Component({
  selector: 'app-purchase-item-history',
  templateUrl: './purchase-item-history.component.html',
  providers: [ListService],
})

export class PurchaseItemHistoryComponent implements OnChanges {
  @Input() item = '';
  @Output() purchase = new EventEmitter<object>();
  isModalOpen = false;
  purchaseItem = { purchaseItems: [], totalCount: 0 } as PagedResultDto<PurchaseItemDto>;

  form = this.fb.group({
    name: [null]
  });

  page = 1;
  pageSize = 10;

  column: string;
  direction: string;


  constructor(public readonly list: ListService, private purchaseItemService: PurchaseItemService, private fb: FormBuilder, private itemService: ItemService) { }
  ngOnChanges(): void {
    if (this.item) {
      this.itemService.get(this.item).subscribe((response) => {
        this.form.controls.name.setValue(response.name);
      });
  
      const itemStreamCreator = (query) => this.purchaseItemService.getItemHistory({ ...query, itemId: this.item,
        skipCount: (this.page - 1) * this.pageSize,
        sorting: this.column + ' ' + this.direction });
      this.list.hookToQuery(itemStreamCreator).subscribe((response) => {
        this.purchaseItem = response;
        this.isModalOpen = true;
      });
    }
  }
  viewPurchase(id: string, itemName: string) {
    this.purchase.emit({ id, itemName });
  }

  onSort({ column, direction }: SortEvent) {
    this.column = column;
    this.direction = direction;
    this.ngOnChanges();
  }
}


