import { NgModule } from '@angular/core';
import { PurchaseItemModule } from '../purchase/purchase-item.module';
import { SaleItemModule } from '../sale/sale-item.module';

import { SharedModule } from '../shared/shared.module';

import { ItemRoutingModule } from './item-routing.module';
import { ItemComponent } from './item.component';


@NgModule({
  declarations: [
    ItemComponent,


  ],
  imports: [
    SharedModule,
    ItemRoutingModule,
    PurchaseItemModule,
    SaleItemModule,
  ]
})
export class ItemModule { }
