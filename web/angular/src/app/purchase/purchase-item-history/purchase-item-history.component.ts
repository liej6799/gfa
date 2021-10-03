import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit, Input, Output, OnChanges, SimpleChanges,EventEmitter } from '@angular/core';

import { PurchaseItemService, PurchaseItemDto } from '@proxy/purchases';
@Component({
  selector: 'app-purchase-item-history',
  templateUrl: './purchase-item-history.component.html',
  providers: [ListService],
})

export class PurchaseItemHistoryComponent  implements OnChanges {
  @Input() item = ''; 
  @Output() purchase = new EventEmitter<object>();
  isModalOpen = false;
  purchaseItem = { purchaseItems: [], totalCount: 0 } as PagedResultDto<PurchaseItemDto>;
  
  constructor(public readonly list: ListService, private purchaseItemService: PurchaseItemService) {}
  ngOnChanges(changes: SimpleChanges): void {
    if(this.item)
    {
      const itemStreamCreator = (query) => this.purchaseItemService.getItemPurchaseHistoryList({...query, itemId: this.item});
      this.list.hookToQuery(itemStreamCreator).subscribe((response) => {
        this.purchaseItem = response;
        this.isModalOpen = true;
      });
    }
  }
  viewPurchase(id: string, itemName: string) {
    this.purchase.emit({id, itemName});
  }
}