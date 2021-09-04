import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { ItemService, ItemDto } from '@proxy/items';
import { PurchaseItemService, PurchaseItemDto } from '@proxy/purchases';


@Component({
  selector: 'app-item',
  templateUrl: './item.component.html',
  styleUrls: ['./item.component.scss'],
  providers: [ListService],
})
export class ItemComponent implements OnInit {

  isModalOpen = false;
  item = { items: [], totalCount: 0 } as PagedResultDto<ItemDto>;
  purchaseItem = { purchaseItems: [], totalCount: 0 } as PagedResultDto<PurchaseItemDto>;
  constructor(public readonly list: ListService, private itemService: ItemService,  private purchaseItemService: PurchaseItemService) {}

  ngOnInit() {
    const itemStreamCreator = (query) => this.itemService.getListFilter(query);

    this.list.hookToQuery(itemStreamCreator).subscribe((response) => {
      this.item = response;
    });
  }


  viewPuchaseHistory(id: string) {

    const purchaseItemStreamCreator = (query) =>  this.purchaseItemService.getItemPurchaseHistoryList({...query, itemId: id});

    this.list.hookToQuery(purchaseItemStreamCreator).subscribe((response) => {
      this.purchaseItem = response;
    });
    
    this.isModalOpen = true;
  }
}

