import { NgModule } from '@angular/core';

import { PurchaseRoutingModule } from './purchase-routing.module';
import { PurchaseComponent } from './purchase.component';
import { PurchaseItemModule } from './purchase-item.module';

@NgModule({
  declarations: [
    PurchaseComponent,
  ],
  imports: [
    PurchaseRoutingModule,
    PurchaseItemModule
  ]
})
export class PurchaseModule { }
