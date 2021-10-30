import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit, Input, Output, OnChanges, SimpleChanges, EventEmitter, ViewChildren, QueryList, Directive } from '@angular/core';
import { FormBuilder } from '@angular/forms';

import { ItemService } from '@proxy/items';
import { SaleItemService, SaleItemDto } from '@proxy/sales';
import { NgbdSortableHeader, SortEvent } from 'src/app/helper/NgbdSortableHeader';

@Component({
  selector: 'app-sale-item-history',
  templateUrl: './sale-item-history.component.html',
  providers: [ListService],

})

export class SaleItemHistoryComponent implements OnChanges {
  @Input() item = '';
  @Output() sale = new EventEmitter<object>();

  form = this.fb.group({
    name: [null]
  });

  isModalOpen = false;
  saleItem = { items: [], totalCount: 0 } as PagedResultDto<SaleItemDto>;

  page = 1;
  pageSize = 10;

  column = '';
  direction = '';

  constructor(public readonly list: ListService, private saleItemServices: SaleItemService, private fb: FormBuilder,
    private itemServices: ItemService) { }
  ngOnChanges(): void {
    if (this.item) {
      this.itemServices.get(this.item).subscribe((response) => {
        this.form.controls.name.setValue(response.name);
      });

      const itemStreamCreator = (query) => this.saleItemServices.getItemHistory({
        ...query, itemId: this.item, skipCount: (this.page - 1) * this.pageSize,
        sorting: this.column + ' ' + this.direction
      });
      this.list.hookToQuery(itemStreamCreator).subscribe((response) => {
        this.saleItem = response;
        this.isModalOpen = true;
      });
    }
  }

  viewSale(id: string, itemName: string) {
    this.sale.emit({ id, itemName });
  }

  @ViewChildren(NgbdSortableHeader) headers: QueryList<NgbdSortableHeader>;

  onSort({ column, direction }: SortEvent) {
    this.column = column;
    this.direction = direction;
    this.ngOnChanges();
  }
}