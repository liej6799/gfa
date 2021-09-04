import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { PurchaseService, PurchaseDto } from '@proxy/purchases';
import { PurchaseItemService, PurchaseItemDto } from '@proxy/purchases';
@Component({
  selector: 'app-purchase',
  templateUrl: './purchase.component.html',
  styleUrls: ['./purchase.component.scss'],
  providers: [ListService],
})
export class PurchaseComponent implements OnInit {

  isModalOpen = false;

  purchase = { purchases: [], totalCount: 0 } as PagedResultDto<PurchaseDto>;
  purchaseItem = { purchaseItems: [], totalCount: 0 } as PagedResultDto<PurchaseItemDto>;

  constructor(public readonly list: ListService, private purchaseService: PurchaseService, private purchaseItemService: PurchaseItemService) {}

  ngOnInit() {
    const itemStreamCreator = (query) => this.purchaseService.getList(query);

    this.list.hookToQuery(itemStreamCreator).subscribe((response) => {
      this.purchase = response;
    });
  }

  viewItem(id: string) {

    const purchaseItemStreamCreator = (query) =>  this.purchaseItemService.getListFilter({...query, purchaseId: id});

    this.list.hookToQuery(purchaseItemStreamCreator).subscribe((response) => {
      this.purchaseItem = response;
      this.isModalOpen = true;
    });
  }
}
