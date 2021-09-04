import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';

import { PurchaseRoutingModule } from './purchase-routing.module';
import { PurchaseComponent } from './purchase.component';


@NgModule({
  declarations: [
    PurchaseComponent
  ],
  imports: [
    SharedModule,
    PurchaseRoutingModule
  ]
})
export class PurchaseModule { }
