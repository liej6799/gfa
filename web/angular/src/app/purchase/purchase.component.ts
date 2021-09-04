import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { PurchaseService, PurchaseDto } from '@proxy/purchases';

@Component({
  selector: 'app-purchase',
  templateUrl: './purchase.component.html',
  styleUrls: ['./purchase.component.scss'],
  providers: [ListService],
})
export class PurchaseComponent implements OnInit {

  purchase = { purchases: [], totalCount: 0 } as PagedResultDto<PurchaseDto>;

  constructor(public readonly list: ListService, private purchaseService: PurchaseService) {}

  ngOnInit() {
    const itemStreamCreator = (query) => this.purchaseService.getList(query);

    this.list.hookToQuery(itemStreamCreator).subscribe((response) => {
      this.purchase = response;
    });
  }
}
