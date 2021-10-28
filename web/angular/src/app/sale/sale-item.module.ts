import { NgModule } from '@angular/core';

import { SaleItemComponent } from './sale-item/sale-item.component';
import { SharedModule } from '../shared/shared.module';
import { SaleItemHistoryComponent } from './sale-item-history/sale-item-history.component';
import { NgbPaginationModule } from '@ng-bootstrap/ng-bootstrap';
import { NgbdSortableHeader } from '../helper/NgbdSortableHeader';
@NgModule({
  declarations: [
    SaleItemComponent,
    SaleItemHistoryComponent,
    NgbdSortableHeader
  ],
  imports: [
    SharedModule,
    NgbPaginationModule,
  ],
  exports: [
    SaleItemComponent,
    SaleItemHistoryComponent,
    SharedModule
  ]
})
export class SaleItemModule { }
