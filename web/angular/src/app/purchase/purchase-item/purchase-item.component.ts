import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit, Input, Output, OnChanges, SimpleChanges } from '@angular/core';
import { PurchaseItemService, PurchaseItemDto } from '@proxy/purchases';
@Component({
  selector: 'app-purchase-item',
  templateUrl: './purchase-item.component.html',
  providers: [ListService],
})

export class PurchaseItemComponent  implements OnChanges {
  @Input() item = ''; 
  isModalOpen = false;
  purchaseItem = { purchaseItems: [], totalCount: 0 } as PagedResultDto<PurchaseItemDto>;
  
  constructor(public readonly list: ListService, private purchaseItemService: PurchaseItemService) {}
  ngOnChanges(changes: SimpleChanges): void {
    if(this.item)
    {
      const itemStreamCreator = (query) => this.purchaseItemService.getListFilter({...query, purchaseId: this.item});
      this.list.hookToQuery(itemStreamCreator).subscribe((response) => {
        this.purchaseItem = response;
        this.isModalOpen = true;
      });
    }
  }
}