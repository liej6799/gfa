import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';

import { SaleRoutingModule } from './sale-routing.module';
import { SaleComponent } from './sale.component';
import { SaleItemModule } from './sale-item.module';


@NgModule({
  declarations: [
    SaleComponent
  ],
  imports: [
    SaleRoutingModule,
    SaleItemModule
  ]
})
export class SaleModule { }
