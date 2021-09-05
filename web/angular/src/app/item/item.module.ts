import { NgModule } from '@angular/core';
import { PurchaseItemHistoryComponent } from '../purchase/purchase-item-history/purchase-item-history.component';
import { SharedModule } from '../shared/shared.module';

import { ItemRoutingModule } from './item-routing.module';
import { ItemComponent } from './item.component';


@NgModule({
  declarations: [
    PurchaseItemHistoryComponent,
    ItemComponent
    
    
  ],
  imports: [
    SharedModule,
    ItemRoutingModule
  ]
})
export class ItemModule { }
