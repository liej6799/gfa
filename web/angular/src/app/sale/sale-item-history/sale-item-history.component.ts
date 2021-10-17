import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit, Input, Output, OnChanges, SimpleChanges, EventEmitter } from '@angular/core';

import { SaleItemService, SaleItemDto } from '@proxy/sales';
@Component({
  selector: 'app-sale-item-history',
  templateUrl: './sale-item-history.component.html',
  providers: [ListService],
})

export class SaleItemHistoryComponent implements OnChanges {
  @Input() item = '';
  @Output() sale = new EventEmitter<object>();
  isModalOpen = false;
  saleItem = { saleItems: [], totalCount: 0 } as PagedResultDto<SaleItemDto>;

  constructor(public readonly list: ListService, private saleItemServices: SaleItemService) { }
  ngOnChanges(changes: SimpleChanges): void {
    if (this.item) {
      const itemStreamCreator = (query) => this.saleItemServices.getItemHistory({ ...query, itemId: this.item });
      this.list.hookToQuery(itemStreamCreator).subscribe((response) => {
        this.saleItem = response;
        this.isModalOpen = true;
      });
    }
  }
  viewSale(id: string, itemName: string) {
    console.log(id)
    console.log(itemName)
    this.sale.emit({ id, itemName });
  }
}