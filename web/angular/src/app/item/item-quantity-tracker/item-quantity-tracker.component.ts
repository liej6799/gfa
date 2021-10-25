import { ListService, PagedResultDto } from '@abp/ng.core';
import { formatDate } from '@angular/common';
import {
  Component,
  OnInit,
  Input,
  Output,
  OnChanges,
  SimpleChanges,
  Inject,
  LOCALE_ID,
  ViewChild,
} from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ItemService, ItemDto } from '@proxy/items';
import { DatatableComponent } from '@swimlane/ngx-datatable';;


@Component({
  selector: 'app-item-quantity-tracker',
  templateUrl: './item-quantity-tracker.component.html',
  providers: [ListService],
})
export class ItemQuantityTrackerComponent implements OnChanges {
    isItemReady = false;
  @Input() item = '';
  tableOffset = 0;
  isModalOpen = false;
  itemQuantity = { items: [], totalCount: 0 } as PagedResultDto<ItemDto>;
  @ViewChild(DatatableComponent, { static: false }) table: DatatableComponent;

  constructor(
    public readonly list: ListService,
    private itemService: ItemService,
    private fb: FormBuilder,
    @Inject(LOCALE_ID) private locale: string,
  ) { }

  transformDate(date) {
    return formatDate(date, 'medium', this.locale);
  }

  ngOnChanges(changes: SimpleChanges): void {
    this.tableOffset = 0;

    if (this.item) {
        
      const itemStreamCreator = query =>
        this.itemService.getQuantityTrackerByInput({ ...query, itemId: this.item });
      this.list.hookToQuery(itemStreamCreator).subscribe(response => {
        this.isItemReady = false;
        this.itemQuantity = response;
        this.isModalOpen = true;
        this.isItemReady = true;
    
      });
    }
  }

    onChange(event: any): void {
        console.log('onchanges')
    }
}
