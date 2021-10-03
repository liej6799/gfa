import { NgModule } from '@angular/core';

import { SaleItemComponent} from './sale-item/sale-item.component';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  declarations: [
    SaleItemComponent
    
  ],
  imports: [
    SharedModule
  ],
  exports: [
    SaleItemComponent,
    SharedModule
  ]
})
export class SaleItemModule { }
