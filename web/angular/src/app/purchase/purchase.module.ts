import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';

import { PurchaseRoutingModule } from './purchase-routing.module';
import { PurchaseComponent } from './purchase.component';
import { PurchaseItemComponent} from './purchase-item/purchase-item.component';

@NgModule({
  declarations: [
    PurchaseItemComponent,
    PurchaseComponent
    
  ],
  imports: [
    SharedModule,
    PurchaseRoutingModule
  ]
})
export class PurchaseModule { }
