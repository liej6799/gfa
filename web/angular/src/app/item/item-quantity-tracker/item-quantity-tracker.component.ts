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
import { DatatableComponent } from '@swimlane/ngx-datatable';


@Component({
  selector: 'app-item-quantity-tracker',
  templateUrl: './item-quantity-tracker.component.html',
  providers: [ListService],
})
export class ItemQuantityTrackerComponent implements OnChanges {
  @Input() item = '';

  form = this.fb.group({
    name: [null]
  });

  isModalOpen = false;
  itemQuantity = { items: [], totalCount: 0 } as PagedResultDto<ItemDto>;

  page = 1;
  pageSize = 10;

  @ViewChild(DatatableComponent, { static: false }) dataTable: DatatableComponent
  constructor(
    public readonly list: ListService,
    private itemService: ItemService,
    private fb: FormBuilder,
    @Inject(LOCALE_ID) private locale: string,
  ) { }

  
  ngOnChanges(changes: SimpleChanges): void {
    if (this.item) {    
      this.itemService.get(this.item).subscribe((response) => {
        this.form.controls.name.setValue(response.name);
      });

      const itemStreamCreator = query =>
        this.itemService.getQuantityTrackerByInput({ ...query, itemId: this.item, skipCount: (this.page -1) * this.pageSize});
      this.list.hookToQuery(itemStreamCreator).subscribe(response => {
        this.itemQuantity = response;
        this.isModalOpen = true;
      });
    }
  }
}
