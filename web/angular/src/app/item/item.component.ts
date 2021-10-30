import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { ItemService, ItemDto } from '@proxy/items';
import { PurchaseItemService, PurchaseItemDto } from '@proxy/purchases';
import { Output, EventEmitter } from '@angular/core';
import { SortEvent } from '../helper/NgbdSortableHeader';

@Component({
  selector: 'app-item',
  templateUrl: './item.component.html',
  styleUrls: ['./item.component.scss'],
  providers: [ListService],
})
export class ItemComponent implements OnInit {

  selectedPurchaseItemHistory = '';
  selectedPurchaseItem = '';
  selectedPurchaseItemFilter = '';

  selectedSaleItemHistory = '';
  selectedSaleItem = '';
  selectedSaleItemFilter = '';

  selectedItemQuantityTracker = '';
  item = { items: [], totalCount: 0 } as PagedResultDto<ItemDto>;

  page = 1;
  pageSize = 10;

  column: string = '';
  direction: string = '';

  constructor(public readonly list: ListService, private itemService: ItemService) { }

  ngOnInit() {
    const itemStreamCreator = (query) => this.itemService.getListFilter({...query, 
      skipCount: (this.page - 1) * this.pageSize,
      sorting: this.column + ' ' + this.direction });

    this.list.hookToQuery(itemStreamCreator).subscribe((response) => {
      this.item = response;
    });
  }


  viewPuchaseHistory(id: string) {
    this.selectedPurchaseItemHistory = id;
  }

  navigatePurchase(input) {
    this.selectedPurchaseItemFilter = input.itemName;
    this.selectedPurchaseItem = input.id;
  }

  viewSaleHistory(id: string) {
    this.selectedSaleItemHistory = id;
  }

  navigateSale(input) {
    this.selectedSaleItemFilter = input.itemName;
    this.selectedSaleItem = input.id;
  }

  viewQuantityTracker(id: string) {
    this.selectedItemQuantityTracker = id;
  }

  onSort({ column, direction }: SortEvent) {
    console.log(column);
    this.column = column;
    this.direction = direction;
    this.ngOnInit();
  }
}

