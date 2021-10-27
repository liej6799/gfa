import { NgModule } from '@angular/core';

import {  ItemQuantityTrackerComponent } from './item-quantity-tracker.component';
import { SharedModule } from '../../shared/shared.module';
import {NgbPaginationModule, NgbAlertModule} from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  declarations: [
    ItemQuantityTrackerComponent,
  ],
  imports: [
    SharedModule,
    NgbPaginationModule, 
    NgbAlertModule
  ],
  exports: [
    ItemQuantityTrackerComponent,
    SharedModule
  ]
})
export class ItemQuantityTrackerModule { }
