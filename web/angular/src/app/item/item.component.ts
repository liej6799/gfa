import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { ItemService, ItemDto } from '@proxy/items';

@Component({
  selector: 'app-item',
  templateUrl: './item.component.html',
  styleUrls: ['./item.component.scss'],
  providers: [ListService],
})
export class ItemComponent implements OnInit {
  item = { items: [], totalCount: 0 } as PagedResultDto<ItemDto>;

  constructor(public readonly list: ListService, private itemService: ItemService) {}

  ngOnInit() {
    const itemStreamCreator = (query) => this.itemService.getList(query);

    this.list.hookToQuery(itemStreamCreator).subscribe((response) => {
      this.item = response;
    });
  }
}
