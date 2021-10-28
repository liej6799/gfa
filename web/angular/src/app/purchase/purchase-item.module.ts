import { NgModule } from '@angular/core';

import { PurchaseItemComponent } from './purchase-item/purchase-item.component';
import { PurchaseItemHistoryComponent } from './purchase-item-history/purchase-item-history.component';
import { SharedModule } from '../shared/shared.module';


@NgModule({
  declarations: [
    PurchaseItemComponent,
    PurchaseItemHistoryComponent,

  ],
  imports: [
    SharedModule,

  ],
  exports: [
    PurchaseItemComponent,
    PurchaseItemHistoryComponent,
    SharedModule
  ]
})
export class PurchaseItemModule { }
