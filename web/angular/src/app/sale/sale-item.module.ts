import { NgModule } from '@angular/core';

import { SaleItemComponent } from './sale-item/sale-item.component';
import { SharedModule } from '../shared/shared.module';
import { SaleItemHistoryComponent } from './sale-item-history/sale-item-history.component';

@NgModule({
  declarations: [
    SaleItemComponent,
    SaleItemHistoryComponent
  ],
  imports: [
    SharedModule
  ],
  exports: [
    SaleItemComponent,
    SaleItemHistoryComponent,
    SharedModule
  ]
})
export class SaleItemModule { }
