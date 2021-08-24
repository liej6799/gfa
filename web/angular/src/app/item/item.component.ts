import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit, Pipe } from '@angular/core';
import { ItemService, ItemDto } from '@proxy/items';

@Pipe({name: 'round'})
export class RoundPipe {
  transform (input:number) {
    return Math.floor(input);
  }
}


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
    const itemStreamCreator = (query) => this.itemService.getListFilter(query);

    this.list.hookToQuery(itemStreamCreator).subscribe((response) => {
      this.item = response;
    });
  }
}

