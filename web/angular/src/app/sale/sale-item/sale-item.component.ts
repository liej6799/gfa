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
} from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { SaleItemService, SaleItemDto, SaleService } from '@proxy/sales';
@Component({
  selector: 'app-sale-item',
  templateUrl: './sale-item.component.html',
  providers: [ListService],
})
export class SaleItemComponent implements OnChanges {
  @Input() item = '';
  isModalOpen = false;
  saleItem = { saleItems: [], totalCount: 0 } as PagedResultDto<SaleItemDto>;

  constructor(
    public readonly list: ListService,
    private saleItemService: SaleItemService,
    private fb: FormBuilder,
    @Inject(LOCALE_ID) private locale: string,
    private saleService: SaleService
  ) {}

  transformDate(date) {
    return formatDate(date, 'medium', this.locale);
  }

  ngOnChanges(changes: SimpleChanges): void {
    if (this.item) {
      const itemStreamCreator = query =>
        this.saleItemService.getList({ ...query, saleId: this.item });
      this.list.hookToQuery(itemStreamCreator).subscribe(response => {
        this.saleItem = response;
        this.isModalOpen = true;
      });
    }
  }
}
